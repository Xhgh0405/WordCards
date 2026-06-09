using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TSVFile
{
    public partial class frmTSVFile : Form
    {
        /// <summary>
        /// 單字清單。
        /// </summary>
        private readonly WordCollection _WordList = new WordCollection();

        /// <summary>
        /// 關於視窗。
        /// </summary>
        private readonly frmAbout about = new frmAbout();

        public frmTSVFile()
        {
            InitializeComponent();
            string iconPath = Path.Combine(Application.StartupPath, "WordCards.ico");
            if (File.Exists(iconPath))
                Icon = new Icon(iconPath);
        }

        /// <summary>
        /// 更新 ListView 的內容。
        /// </summary>
        private void UpdateListView()
        {
            lvwWord.BeginUpdate();
            lvwWord.Items.Clear();

            foreach (WordItem item in _WordList)
            {
                ListViewItem lvi = new ListViewItem(item.Word);
                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);
                lvwWord.Items.Add(lvi);
            }

            lvwWord.EndUpdate();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "開啟檔案";
                ofd.InitialDirectory = Application.StartupPath;

                DialogResult dr = ofd.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    _WordList.LoadFromFile(ofd.FileName);
                    UpdateListView();
                    tsslMessage.Text = $"{_WordList.Count} 單字已成功載入";
                }
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            about.ShowDialog(this);
        }

        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要離開嗎?", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            tsslMessage.Text = "請開啟檔案";
        }
    }
}
