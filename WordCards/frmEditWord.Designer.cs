using System.Drawing;
using System.Windows.Forms;

namespace WordCards
{
    partial class frmEditWord
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpWord;
        private GroupBox grpPhonogram;
        private GroupBox grpSoundPath;
        private GroupBox grpExplain;
        private TextBox txtWord;
        private TextBox txtPhonogram;
        private TextBox txtSoundPath;
        private TextBox txtExplain;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Location = new System.Drawing.Point(12, 12);
            this.grpWord.Name = "grpWord";
            this.grpWord.Size = new System.Drawing.Size(360, 58);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字";
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Location = new System.Drawing.Point(12, 24);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(336, 22);
            this.txtWord.TabIndex = 0;
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Location = new System.Drawing.Point(12, 76);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Size = new System.Drawing.Size(360, 58);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.Location = new System.Drawing.Point(12, 24);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(336, 22);
            this.txtPhonogram.TabIndex = 0;
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Location = new System.Drawing.Point(12, 140);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Size = new System.Drawing.Size(360, 58);
            this.grpSoundPath.TabIndex = 2;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoundPath.Location = new System.Drawing.Point(12, 24);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(336, 22);
            this.txtSoundPath.TabIndex = 0;
            // 
            // grpExplain
            // 
            this.grpExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Location = new System.Drawing.Point(12, 204);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Size = new System.Drawing.Size(360, 184);
            this.grpExplain.TabIndex = 3;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.Location = new System.Drawing.Point(12, 24);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(336, 148);
            this.txtExplain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(280, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditWord
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 444);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.MinimumSize = new System.Drawing.Size(320, 420);
            this.Name = "frmEditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "編輯單字";
            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
