using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace TSVFile
{
    public class WordCollection : Collection<WordItem>
    {
        /// <summary>
        /// 從字串陣列載入資料。
        /// </summary>
        public void LoadFromStringArray(string[] lines)
        {
            this.Clear();

            if (lines == null)
                return;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                WordItem item = new WordItem(line);
                if (!string.IsNullOrWhiteSpace(item.Word))
                    this.Add(item);
            }
        }

        /// <summary>
        /// 讀取 WordCards.txt。使用 BOM 偵測，能正常讀 UTF-16 Unicode 或 UTF-8。
        /// </summary>
        public void LoadFromFile(string filePath)
        {
            string[] lines;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8, true))
            {
                string text = reader.ReadToEnd();
                lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            }

            LoadFromStringArray(lines);
        }

        /// <summary>
        /// 將 WordCollection 物件的資料儲存到檔案中。
        /// </summary>
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.Unicode))
            {
                foreach (WordItem item in this)
                {
                    writer.WriteLine(item.ToLineString());
                }
            }
        }
    }
}
