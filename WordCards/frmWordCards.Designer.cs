using System.Drawing;
using System.Windows.Forms;

namespace WordCards
{
    partial class frmWordCards
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstWordList;
        private Panel palMain;
        private Panel palHeader;
        private Panel palControl;
        private Label lblTitle;
        private Label lblSubTitle;
        private Label txtWord;
        private Label txtPhonogram;
        private Label txtExplain;
        private PictureBox picLogo;
        private Button btnAutoPlay;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblHelp;
        private Label lblEditTip;
        private StatusStrip ssWord;
        private ToolStripStatusLabel tsslMessage;
        private Timer timPlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.lblEditTip = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.palControl = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtExplain = new System.Windows.Forms.Label();
            this.txtPhonogram = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.Label();
            this.palHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.palMain.SuspendLayout();
            this.palControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.palHeader.SuspendLayout();
            this.ssWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWordList
            // 
            this.lstWordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.lstWordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lstWordList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 17;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(176, 461);
            this.lstWordList.TabIndex = 0;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            this.lstWordList.DoubleClick += new System.EventHandler(this.lstWordList_DoubleClick);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.palMain.Controls.Add(this.lblEditTip);
            this.palMain.Controls.Add(this.lblHelp);
            this.palMain.Controls.Add(this.palControl);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Controls.Add(this.palHeader);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(176, 0);
            this.palMain.Name = "palMain";
            this.palMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.palMain.Size = new System.Drawing.Size(668, 461);
            this.palMain.TabIndex = 1;
            // 
            // lblEditTip
            // 
            this.lblEditTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditTip.AutoSize = true;
            this.lblEditTip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lblEditTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.lblEditTip.Location = new System.Drawing.Point(26, 405);
            this.lblEditTip.Name = "lblEditTip";
            this.lblEditTip.Size = new System.Drawing.Size(137, 15);
            this.lblEditTip.TabIndex = 7;
            this.lblEditTip.Text = "雙擊左側單字可以修改";
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblHelp.Location = new System.Drawing.Point(491, 380);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(146, 45);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "Enter：下一個\r\nBackspace：上一個\r\nSpace：重播";
            // 
            // palControl
            // 
            this.palControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.palControl.BackColor = System.Drawing.Color.Transparent;
            this.palControl.Controls.Add(this.btnPrevious);
            this.palControl.Controls.Add(this.btnAutoPlay);
            this.palControl.Controls.Add(this.btnNext);
            this.palControl.Location = new System.Drawing.Point(430, 226);
            this.palControl.Name = "palControl";
            this.palControl.Size = new System.Drawing.Size(212, 42);
            this.palControl.TabIndex = 5;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(93)))), ((int)(((byte)(150)))));
            this.btnPrevious.Location = new System.Drawing.Point(0, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(66, 32);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "上一個";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnAutoPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAutoPlay.ForeColor = System.Drawing.Color.White;
            this.btnAutoPlay.Location = new System.Drawing.Point(72, 4);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(66, 32);
            this.btnAutoPlay.TabIndex = 1;
            this.btnAutoPlay.Text = "Play";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(93)))), ((int)(((byte)(150)))));
            this.btnNext.Location = new System.Drawing.Point(144, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一個";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(493, 105);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(88, 108);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(235)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExplain.Location = new System.Drawing.Point(28, 214);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Padding = new System.Windows.Forms.Padding(12);
            this.txtExplain.Size = new System.Drawing.Size(380, 178);
            this.txtExplain.TabIndex = 3;
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
            this.txtPhonogram.Location = new System.Drawing.Point(28, 168);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(392, 34);
            this.txtPhonogram.TabIndex = 2;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Font = new System.Drawing.Font("Microsoft JhengHei UI", 38F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(96)))), ((int)(((byte)(180)))));
            this.txtWord.Location = new System.Drawing.Point(24, 96);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(410, 70);
            this.txtWord.TabIndex = 1;
            // 
            // palHeader
            // 
            this.palHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.palHeader.Controls.Add(this.lblSubTitle);
            this.palHeader.Controls.Add(this.lblTitle);
            this.palHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.palHeader.Location = new System.Drawing.Point(0, 0);
            this.palHeader.Name = "palHeader";
            this.palHeader.Size = new System.Drawing.Size(668, 76);
            this.palHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 48);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(206, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Click Play to start auto review mode";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(26, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Word Cards";
            // 
            // ssWord
            // 
            this.ssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssWord.Location = new System.Drawing.Point(0, 439);
            this.ssWord.Name = "ssWord";
            this.ssWord.Size = new System.Drawing.Size(844, 22);
            this.ssWord.TabIndex = 2;
            this.ssWord.Text = "ssWord";
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(56, 17);
            this.tsslMessage.Text = "Message";
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            this.timPlayer.Tick += new System.EventHandler(this.timPlayer_Tick);
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.ssWord);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(760, 410);
            this.Name = "frmWordCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWordCards_FormClosing);
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.palControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.palHeader.ResumeLayout(false);
            this.palHeader.PerformLayout();
            this.ssWord.ResumeLayout(false);
            this.ssWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
