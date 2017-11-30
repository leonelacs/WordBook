using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

public class Libs
{
    public class Vocabulary
    {
        public string Word, Meaning, Phonetic;
        public Vocabulary(string Content_Word, string Content_Meaning, string Content_Phonetic)
        {
            this.Word = Content_Word;
            this.Meaning = Content_Meaning;
            this.Phonetic = Content_Phonetic;
        }
    }


    public class Wordbook
    {
        public List<Vocabulary> lstVocabularies = new List<Vocabulary>();
        static FileStream WBF = new FileStream("library.wbf", FileMode.Open, FileAccess.Read);
        StreamReader WBFLineReader = new StreamReader(WBF, Encoding.Default);

        public bool Initialize()
        {
            Vocabulary Content_Vocabulary;
            string Content_Line;
            bool sgn = true, flag;
            int count = 0;
            do
            {
                Content_Line = null;
                Content_Line = WBFLineReader.ReadLine();
                if (Content_Line == null)
                {
                    sgn = false;
                }
                else
                {
                    Content_Vocabulary = new Vocabulary(Content_Line.Trim().Split('\t')[0], Content_Line.Trim().Split('\t')[1], Content_Line.Trim().Split('\t')[2]);
                    lstVocabularies.Add(Content_Vocabulary);
                    count++;
                }
            }
            while (sgn);

            if (count > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;

        }

    }

    public class Statue
    {
        public int Index, Second;
        public bool IsRandom;



        public bool Initialize()
        {
            FileStream WBI = new FileStream("statue.wbi", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader WBILineReader = new StreamReader(WBI, Encoding.Default);
            string Content_Line = WBILineReader.ReadLine();
            bool flag = false;
            if (Content_Line != null)
            {
                {
                    Index = int.Parse(Content_Line);
                    if (Index >= 0)
                    {
                        Content_Line = null;
                        Content_Line = WBILineReader.ReadLine();
                        if (Content_Line != null && (Content_Line == "True" || Content_Line == "False"))
                        {
                            IsRandom = bool.Parse(Content_Line);
                            Content_Line = null;
                            Content_Line = WBILineReader.ReadLine();
                            if (Content_Line != null)
                            {
                                Second = int.Parse(Content_Line);
                                if (Second >= 1 && Second <= 120)
                                {
                                    flag = true;
                                }
                            }
                        }
                    }
                }
                WBILineReader.Close();
            }
            else
            {
                Save(0, false, 5);
            }
            return flag;
        }

        public void Save(int Value_Index, bool Is_IsRandom, int Value_Interval)
        {
            FileStream WBI = new FileStream("statue.wbi", FileMode.Create, FileAccess.Write);
            StreamWriter WBILineWriter = new StreamWriter(WBI, Encoding.Default);
            WBILineWriter.WriteLine(Value_Index.ToString());
            WBILineWriter.WriteLine(Is_IsRandom.ToString());
            WBILineWriter.WriteLine(Value_Interval.ToString());
            WBILineWriter.Close();
        }

    }
}
