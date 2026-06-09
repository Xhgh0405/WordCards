using System;
using System.Linq;

namespace WordCards
{
    public class WordItem
    {
        public string Word { get; set; } = string.Empty;
        public string Phonogram { get; set; } = string.Empty;
        public string SoundPath { get; set; } = string.Empty;
        public string Explain { get; set; } = string.Empty;

        public WordItem()
        {
        }

        /// <summary>
        /// 建構子：把 TSV 檔案中的單行資料拆成 Word、Phonogram、SoundPath、Explain。
        /// </summary>
        /// <param name="str">單行的單字資料</param>
        public WordItem(string str)
        {
            string[] strLists = (str ?? string.Empty).Split('\t');
            if (strLists.Length >= 3)
            {
                Word = strLists[0];
                Phonogram = strLists[1];
                SoundPath = strLists[2];
                Explain = string.Join(Environment.NewLine, strLists.Skip(3));
            }
        }

        /// <summary>
        /// 將 WordItem 物件轉換回 TSV 格式：Word\tPhonogram\tSoundPath\tExplain。
        /// </summary>
        public string ToLineString()
        {
            string strExplain = (Explain ?? string.Empty).Replace(Environment.NewLine, "\t").Replace("\r", "\t").Replace("\n", "\t");
            return $"{Word}\t{Phonogram}\t{SoundPath}\t{strExplain}";
        }

        public override string ToString()
        {
            return Word;
        }
    }
}
