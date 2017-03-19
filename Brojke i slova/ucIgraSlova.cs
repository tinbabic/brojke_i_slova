using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brojke_i_slova
{
    public partial class ucIgraSlova : UserControl
    {
        public ucIgraSlova()
        {
            InitializeComponent();
        }

        private void btnLetter1_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter1.Text;
            btnLetter1.Enabled = false;
        }

        private void btnLetter2_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter2.Text;
            btnLetter2.Enabled = false;
        }

        private void btnLetter3_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter3.Text;
            btnLetter3.Enabled = false;
        }

        private void btnLetter4_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter4.Text;
            btnLetter4.Enabled = false;
        }

        private void btnLetter5_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter5.Text;
            btnLetter5.Enabled = false;
        }

        private void btnLetter6_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter6.Text;
            btnLetter6.Enabled = false;
        }

        private void btnLetter7_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter7.Text;
            btnLetter7.Enabled = false;
        }

        private void btnLetter8_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter8.Text;
            btnLetter8.Enabled = false;
        }

        private void btnLetter9_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text += btnLetter9.Text;
            btnLetter9.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labLetterExpression.Text = "";
            for(int i = 0; i < op.letters.Count; i++)
            {
                grpLettersToChoose.Controls["btnLetter" + (i + 1)].Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.currentRound++;
            ((Form1)ParentForm).initBrojke();
            ((Form1)ParentForm).showBrojke();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.currentRound = 1;
            ((Form1)ParentForm).showMain();
            System.IO.StreamWriter file = new System.IO.StreamWriter("highscores.txt", true);
            file.WriteLine(op.playerName + " " + op.score);
            file.Close();
            file.Dispose();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).timerDisable();
            ((Form1)ParentForm).endSlova();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).showMain();
        }
    }
}
