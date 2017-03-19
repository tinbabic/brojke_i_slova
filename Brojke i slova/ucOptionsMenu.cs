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
    public partial class ucOptionsMenu : UserControl
    {
        public ucOptionsMenu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options.Instance.smallNumbers = (int)numSmall.Value;
            Options.Instance.largeNumbers = (int)numLarge.Value;
            Options.Instance.timerNumbers = (int)numNumTimer.Value;
            Options.Instance.operators = "";
            foreach(var item in listOperators.CheckedIndices)
            {
                switch(item.ToString())
                {
                    case "0":
                        Options.Instance.operators += "+";
                        break;
                    case "1":
                        Options.Instance.operators += "-";
                        break;
                    case "2":
                        Options.Instance.operators += "*";
                        break;
                    case "3":
                        Options.Instance.operators += "/";
                        break;
                    case "4":
                        Options.Instance.operators += "^";
                        break;
                }
            }

            Options.Instance.numberOfVowels = (int)numVowels.Value;
            Options.Instance.numberOfConsonants = (int)numConsonants.Value;
            Options.Instance.timerLetters = (int)numLetTimer.Value;

            Options.Instance.numberOfRounds = (int)numRounds.Value;
            Options.Instance.playerName = textPlayerName.Text;
            ((Form1)ParentForm).showMain();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).showMain();
        }
    }
}
