using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace WordCards
{
    public partial class frmWordCards : Form
    {
        /// <summary>
        /// 單字清單。
        /// </summary>
        private readonly WordCollection _WordList = new WordCollection();

        /// <summary>
        /// Windows Media Player 播放器。
        /// </summary>
        private readonly WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        private readonly string strWordFile = Path.Combine(Application.StartupPath, "WordCards.txt");

        /// <summary>
        /// 是否自動播放。
        /// </summary>
        private bool isPlay = false;

        public frmWordCards()
        {
            InitializeComponent();
            LoadLogoAndIcon();
        }

        private void LoadLogoAndIcon()
        {
            string logoPath = Path.Combine(Application.StartupPath, "WordCards_Logo.png");
            if (File.Exists(logoPath))
                picLogo.Image = Image.FromFile(logoPath);

            string iconPath = Path.Combine(Application.StartupPath, "WordCards.ico");
            if (File.Exists(iconPath))
                Icon = new Icon(iconPath);
        }

        /// <summary>
        /// 顯示單字。
        /// </summary>
        private void ShowWord(WordItem word)
        {
            if (word == null)
                return;

            txtWord.Text = word.Word;
            txtPhonogram.Text = word.Phonogram;
            txtExplain.Text = word.Explain;
        }

        /// <summary>
        /// 將單字加入到播放清單。
        /// </summary>
        private void UpdateWordList()
        {
            lstWordList.BeginUpdate();
            lstWordList.Items.Clear();

            foreach (WordItem item in _WordList)
                lstWordList.Items.Add(item);

            lstWordList.EndUpdate();
        }

        private void frmWordCards_Load(object sender, EventArgs e)
        {
            if (!File.Exists(strWordFile))
            {
                MessageBox.Show($"找不到單字檔\n{strWordFile}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            _WordList.LoadFromFile(strWordFile);

            if (_WordList.Count > 0)
            {
                UpdateWordList();
                lstWordList.SelectedIndex = 0;
                ShowWord(_WordList[0]);
                tsslMessage.Text = $"單字數量：{_WordList.Count}";
            }
            else
            {
                tsslMessage.Text = "沒有讀到單字資料";
            }
        }

        /// <summary>
        /// 播放單字音檔。
        /// </summary>
        public void PlayWord(WordItem word)
        {
            if (word == null)
                return;

            string soundPath = word.SoundPath ?? string.Empty;
            if (!Path.IsPathRooted(soundPath))
                soundPath = Path.Combine(Application.StartupPath, soundPath);

            if (File.Exists(soundPath))
            {
                wmp.URL = soundPath;
                wmp.settings.autoStart = false;
                wmp.settings.mute = false;
                wmp.controls.play();
                tsslMessage.Text = $"播放：{word.Word}";
            }
            else
            {
                tsslMessage.Text = $"找無 {word.SoundPath} 音效檔";
            }
        }

        /// <summary>
        /// 播放目前選取的單字。
        /// </summary>
        private void PlaySelectedWord()
        {
            if (lstWordList.SelectedItem != null && lstWordList.SelectedIndex >= 0 && lstWordList.SelectedIndex < _WordList.Count)
            {
                int idx = lstWordList.SelectedIndex;
                ShowWord(_WordList[idx]);
                PlayWord(_WordList[idx]);
            }
        }

        private void lstWordList_Click(object sender, EventArgs e)
        {
            if (isPlay == true)
                btnAutoPlay.PerformClick();

            if (lstWordList.SelectedItem != null && lstWordList.SelectedItem.ToString().Length != 0)
                PlaySelectedWord();
        }

        /// <summary>
        /// 將單字清單的選項移動指定格數。
        /// offset = 1 是下一個；offset = -1 是上一個。
        /// </summary>
        private void MoveWordList(int offset)
        {
            if (lstWordList.Items.Count == 0)
                return;

            lstWordList.Focus();

            int currentIndex = lstWordList.SelectedIndex;
            if (currentIndex < 0)
                currentIndex = 0;

            int nextIndex = (currentIndex + offset) % lstWordList.Items.Count;
            if (nextIndex < 0)
                nextIndex += lstWordList.Items.Count;

            lstWordList.SelectedIndex = nextIndex;
            CenterSelectedWord();
        }

        /// <summary>
        /// 將單字清單的選項移到上一個。
        /// </summary>
        private void PreviousWordList()
        {
            MoveWordList(-1);
        }

        /// <summary>
        /// 將單字清單的選項移到下一個。
        /// </summary>
        private void NextWordList()
        {
            MoveWordList(1);
        }

        /// <summary>
        /// 讓目前選取的單字盡量保持在清單中間。
        /// </summary>
        private void CenterSelectedWord()
        {
            if (lstWordList.SelectedIndex < 0 || lstWordList.Items.Count == 0)
                return;

            int itemHeight = Math.Max(1, lstWordList.GetItemHeight(0));
            int lstRows = Math.Max(1, lstWordList.Height / itemHeight);
            if (lstWordList.SelectedIndex >= lstRows / 2)
                lstWordList.TopIndex = Math.Max(0, lstWordList.SelectedIndex - lstRows / 2);
            else
                lstWordList.TopIndex = 0;
        }

        private void timPlayer_Tick(object sender, EventArgs e)
        {
            NextWordList();
            PlaySelectedWord();
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            lstWordList.Focus();

            if (isPlay == false)
            {
                btnAutoPlay.Text = "Stop";
                isPlay = true;
                PlaySelectedWord();
                timPlayer.Start();
            }
            else
            {
                btnAutoPlay.Text = "Play";
                isPlay = false;
                timPlayer.Stop();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (isPlay == true)
                btnAutoPlay.PerformClick();

            PreviousWordList();
            PlaySelectedWord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isPlay == true)
                btnAutoPlay.PerformClick();

            NextWordList();
            PlaySelectedWord();
        }

        private void frmWordCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isPlay == true)
                return;

            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    NextWordList();
                    PlaySelectedWord();
                    e.Handled = true;
                    break;

                case (char)Keys.Back:
                    PreviousWordList();
                    PlaySelectedWord();
                    e.Handled = true;
                    break;

                case (char)Keys.Space:
                    if (lstWordList.SelectedIndex >= 0)
                        PlaySelectedWord();
                    e.Handled = true;
                    break;
            }
        }

        private void lstWordList_DoubleClick(object sender, EventArgs e)
        {
            lstWordList.Focus();
            if (lstWordList.SelectedIndex < 0 || lstWordList.SelectedIndex >= _WordList.Count)
                return;

            int idx = lstWordList.SelectedIndex;
            using (frmEditWord edit = new frmEditWord(_WordList[idx]))
            {
                DialogResult result = edit.ShowDialog(this);
                if (result == DialogResult.Yes)
                {
                    UpdateWordList();
                    lstWordList.SelectedIndex = idx;
                    PlaySelectedWord();
                    _WordList.SaveToFile(strWordFile);
                    tsslMessage.Text = $"已儲存：{_WordList[idx].Word}";
                }
            }
        }

        private void frmWordCards_FormClosing(object sender, FormClosingEventArgs e)
        {
            timPlayer.Stop();
            try
            {
                wmp.controls.stop();
            }
            catch
            {
                // 關閉程式時若播放器尚未初始化，直接略過。
            }
        }
    }
}
