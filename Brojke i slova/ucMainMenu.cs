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
    public partial class ucMainMenu : UserControl
    {
        public ucMainMenu()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).showOptions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).initBrojke();
            ((Form1)ParentForm).showBrojke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            System.IO.StreamReader file = new System.IO.StreamReader("highscores.txt");
            string line = "";
            Dictionary<string, int> scorelist = new Dictionary<string, int>();
            while ((line = file.ReadLine()) != null)
            {
                string[] vals = line.Split(new char[] { ' ' });
                if (scorelist.ContainsKey(vals[0]))
                {
                    if (scorelist[vals[0]] < Convert.ToInt32(vals[1]))
                    {
                        scorelist.Remove(vals[0]);
                        scorelist.Add(vals[0], Convert.ToInt32(vals[1]));
                    }
                }
                else
                {
                    scorelist.Add(vals[0], Convert.ToInt32(vals[1]));
                }
            }
            file.Close();
            file.Dispose();
            var ordered = scorelist.OrderByDescending(x => x.Value);
            op.scorelist = ordered.ToDictionary<KeyValuePair<string, int>, string, int>(pair => pair.Key, pair => pair.Value);
            ((Form1)ParentForm).initHighscore();
            ((Form1)ParentForm).showHighscore();
        }
    }
}
