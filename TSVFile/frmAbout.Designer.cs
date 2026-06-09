using System.Drawing;
using System.Windows.Forms;

namespace TSVFile
{
    partial class frmAbout
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel;
        private PictureBox picLogo;
        private Label lblProductName;
        private Label lblVersion;
        private Label lblCopyright;
        private Label lblCompany;
        private TextBox txtDescription;
        private Button okButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.Controls.Add(this.picLogo, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCompany, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(460, 250);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.tableLayoutPanel.SetRowSpan(this.picLogo, 6);
            this.picLogo.Size = new System.Drawing.Size(155, 244);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Location = new System.Drawing.Point(167, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(290, 35);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "產品名稱";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(167, 35);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(290, 35);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "版本";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(167, 70);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(290, 35);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "著作權";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Location = new System.Drawing.Point(167, 105);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(290, 35);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "公司名稱";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(167, 143);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(290, 59);
            this.txtDescription.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(382, 222);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "確定";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "關於";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
