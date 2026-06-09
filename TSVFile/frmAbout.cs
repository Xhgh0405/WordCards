using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TSVFile
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            LoadProjectInfo();
        }

        private void LoadProjectInfo()
        {
            Text = "關於 TSV資料檔讀取";
            lblProductName.Text = "TSV資料檔讀取";
            lblVersion.Text = $"版本 {Assembly.GetExecutingAssembly().GetName().Version}";
            lblCopyright.Text = "Copyright © 2026";
            lblCompany.Text = "元智大學資工系";
            txtDescription.Text = "視窗程式設計 II - 資料檔讀取與自訂類別集合";

            string logoPath = Path.Combine(Application.StartupPath, "WordCards_Logo.png");
            if (File.Exists(logoPath))
                picLogo.Image = Image.FromFile(logoPath);

            string iconPath = Path.Combine(Application.StartupPath, "WordCards.ico");
            if (File.Exists(iconPath))
                Icon = new Icon(iconPath);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
