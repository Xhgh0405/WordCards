using System.Windows.Forms;

namespace TSVFile
{
    partial class frmTSVFile
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip mnsWord;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiAbout;
        private ListView lvwWord;
        private ColumnHeader clhWord;
        private ColumnHeader clhPhonogram;
        private ColumnHeader clhSoundPath;
        private ColumnHeader clhExplain;
        private StatusStrip ssrWord;
        private ToolStripStatusLabel tsslMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.clhWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssrWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsWord.SuspendLayout();
            this.ssrWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsWord
            // 
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(784, 24);
            this.mnsWord.TabIndex = 0;
            this.mnsWord.Text = "mnsWord";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(38, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(103, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(103, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(47, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lvwWord
            // 
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhWord,
            this.clhPhonogram,
            this.clhSoundPath,
            this.clhExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 24);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(784, 395);
            this.lvwWord.TabIndex = 1;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            // 
            // clhWord
            // 
            this.clhWord.Text = "單字";
            this.clhWord.Width = 120;
            // 
            // clhPhonogram
            // 
            this.clhPhonogram.Text = "音標";
            this.clhPhonogram.Width = 120;
            // 
            // clhSoundPath
            // 
            this.clhSoundPath.Text = "音檔路徑";
            this.clhSoundPath.Width = 180;
            // 
            // clhExplain
            // 
            this.clhExplain.Text = "解釋";
            this.clhExplain.Width = 340;
            // 
            // ssrWord
            // 
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssrWord.Location = new System.Drawing.Point(0, 419);
            this.ssrWord.Name = "ssrWord";
            this.ssrWord.Size = new System.Drawing.Size(784, 22);
            this.ssrWord.TabIndex = 2;
            this.ssrWord.Text = "ssrWord";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(56, 17);
            this.tsslMessage.Text = "Message";
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.ssrWord);
            this.Controls.Add(this.mnsWord);
            this.MainMenuStrip = this.mnsWord;
            this.Name = "frmTSVFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSV資料檔讀取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
