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
using static Libs;

namespace WordBook
{
    public partial class MainForm : Form
    {

        public Wordbook theBook = new Wordbook();
        public Statue theStatue = new Statue();
        public int idx = 0, Temp_idx;
        public MainForm()
        {
            InitializeComponent();
            theBook.Initialize();
            if (theStatue.Initialize())
            {
                lblWord.Text = theBook.lstVocabularies[theStatue.Index].Word;
                lblMeaning.Text = theBook.lstVocabularies[theStatue.Index].Meaning;
                lblPhonetic.Text = "[ " + theBook.lstVocabularies[theStatue.Index].Phonetic + " ]";
                nudSecond.Value = theStatue.Second;
                tmrAuto.Interval = theStatue.Second * 1000;
                if (theStatue.IsRandom)
                {
                    chkRandom.Checked = true;
                }
            }
            else
            {
                lblWord.Text = theBook.lstVocabularies.First<Vocabulary>().Word;
                lblMeaning.Text = theBook.lstVocabularies.First<Vocabulary>().Meaning;
                lblPhonetic.Text = "[ " + theBook.lstVocabularies.First<Vocabulary>().Phonetic + " ]";
            }
            this.TopMost = false;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            btnAuto.Enabled = false;
            btnAuto.Visible = false;
            btnManu.Enabled = true;
            btnManu.Visible = true;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            chkRandom.Enabled = true;
            btnManu.Focus();
            tmrAuto.Enabled = true;
            nudSecond.Enabled = true;
            lblInterval.Enabled = true;
            lblSecond.Enabled = true;
            btnSave.Enabled = true;
            btnInitial.Enabled = true;
            ntfIcon.ShowBalloonTip(500, "WordBook", "自动模式已开启", ToolTipIcon.Info);
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            btnAuto.Enabled = true;
            btnAuto.Visible = true;
            btnManu.Enabled = false;
            btnManu.Visible = false;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            chkRandom.Enabled = false;
            btnAuto.Focus();
            tmrAuto.Enabled = false;
            nudSecond.Enabled = false;
            lblInterval.Enabled = false;
            lblSecond.Enabled = false;
            btnSave.Enabled = true;
            btnInitial.Enabled = true;
            ntfIcon.ShowBalloonTip(500, "WordBook", "自动模式已关闭", ToolTipIcon.Info);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                lblWord.Text = theBook.lstVocabularies[idx-1].Word;
                lblMeaning.Text = theBook.lstVocabularies[idx-1].Meaning;
                lblPhonetic.Text = "[ " + theBook.lstVocabularies[idx-1].Phonetic + " ]";
                idx--;
                if(idx == 0)
                {
                    btnPrev.Enabled = false;
                }
                btnNext.Enabled = true;
                btnSave.Enabled = true;
                btnInitial.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                idx = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;
            if(idx < theBook.lstVocabularies.Count-1 && idx >= 0)
            {
                lblWord.Text = theBook.lstVocabularies[idx + 1].Word;
                lblMeaning.Text = theBook.lstVocabularies[idx + 1].Meaning;
                lblPhonetic.Text = "[ " + theBook.lstVocabularies[idx + 1].Phonetic + " ]";
                if(idx+1 == theBook.lstVocabularies.Count-1)
                {
                    btnNext.Enabled = false;
                }
                idx++;
                btnSave.Enabled = true;
                btnInitial.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void nudSecond_ValueChanged(object sender, EventArgs e)
        {
            tmrAuto.Interval = (int)nudSecond.Value * 1000;
            btnSave.Enabled = true;
            btnInitial.Enabled = true;
        }

        private void chkOnTheTop_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOnTheTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            btnInitial.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            theStatue.Save(idx, chkRandom.Checked, (int)nudSecond.Value);
            //MessageBox.Show("状态保存成功");
            ntfIcon.ShowBalloonTip(500, "WordBook", "状态保存成功", ToolTipIcon.Info);
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            btnInitial.Enabled = false;
            btnSave.Enabled = false;
            theStatue.Save(0, false, 5);
            lblWord.Text = theBook.lstVocabularies.First<Vocabulary>().Word;
            lblMeaning.Text = theBook.lstVocabularies.First<Vocabulary>().Meaning;
            lblPhonetic.Text = "[ " + theBook.lstVocabularies.First<Vocabulary>().Phonetic + " ]";
            btnPrev.Enabled = false;
            btnNext.Enabled = true;
            btnAuto.Enabled = true;
            btnAuto.Visible = true;
            btnManu.Enabled = false;
            btnManu.Visible = false;
            idx = 0;
            chkRandom.Checked = false;
            chkOnTheTop.Checked = false;
            nudSecond.Value = 5;
            tmrAuto.Interval = 5000;
            tmrAuto.Enabled = false;
            this.TopMost = false;
            //MessageBox.Show("状态初始化成功");
            ntfIcon.ShowBalloonTip(500, "WordBook", "状态初始化成功", ToolTipIcon.Info);
        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnInitial.Enabled = true;
        }



        private void tmrAuto_Tick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnInitial.Enabled = true;
            if (chkRandom.Checked == false)
            {
                if (idx < theBook.lstVocabularies.Count - 1 && idx >= 0)
                {
                    lblWord.Text = theBook.lstVocabularies[idx + 1].Word;
                    lblMeaning.Text = theBook.lstVocabularies[idx + 1].Meaning;
                    lblPhonetic.Text = "[ " + theBook.lstVocabularies[idx + 1].Phonetic + " ]";
                    if (idx + 1 == theBook.lstVocabularies.Count - 1)
                    {
                        idx = 0;
                    }
                    else
                    {
                        idx++;
                    }
                }
            }
            else
            {
                do
                {
                    Temp_idx = new Random().Next(0, theBook.lstVocabularies.Count);
                }
                while (Temp_idx == idx);
                idx = Temp_idx;
                lblWord.Text = theBook.lstVocabularies[idx].Word;
                lblMeaning.Text = theBook.lstVocabularies[idx].Meaning;
                lblPhonetic.Text = "[ " + theBook.lstVocabularies[idx].Phonetic + " ]";
            }
        }


    }

    


}
