using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brojke_i_slova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void showOptions()
        {
            optionsMenu.Enabled = true;
            optionsMenu.Visible = true; 
            mainMenu.Visible = false;
            mainMenu.Enabled = false;
            brojke.Enabled = false;
            brojke.Visible = false;
            slova.Enabled = false;
            slova.Visible = false;
            scores.Enabled = false;
            scores.Visible = false;
        }
        public void showMain()
        {
            optionsMenu.Enabled = false;
            optionsMenu.Visible = false;
            mainMenu.Visible = true;
            mainMenu.Enabled = true;
            brojke.Enabled = false;
            brojke.Visible = false;
            slova.Enabled = false;
            slova.Visible = false;
            scores.Enabled = false;
            scores.Visible = false;
        }
        public void showBrojke()
        {
            optionsMenu.Enabled = false;
            optionsMenu.Visible = false;
            mainMenu.Visible = false;
            mainMenu.Enabled = false;
            brojke.Enabled = true;
            brojke.Visible = true;
            slova.Enabled = false;
            slova.Visible = false;
            scores.Enabled = false;
            scores.Visible = false;
        }
        public void showSlova()
        {
            optionsMenu.Enabled = false;
            optionsMenu.Visible = false;
            mainMenu.Visible = false;
            mainMenu.Enabled = false;
            brojke.Enabled = false;
            brojke.Visible = false;
            slova.Enabled = true;
            slova.Visible = true;
            scores.Enabled = false;
            scores.Visible = false;
        }
        public void showHighscore()
        {
            optionsMenu.Enabled = false;
            optionsMenu.Visible = false;
            mainMenu.Visible = false;
            mainMenu.Enabled = false;
            brojke.Enabled = false;
            brojke.Visible = false;
            slova.Enabled = false;
            slova.Visible = false;
            scores.Enabled = true;
            scores.Visible = true;
        }
        public void initHighscore()
        {
            Options op = Options.Instance;
            var datasource = from row in op.scorelist select new { Player = row.Key, Score = row.Value };
            DataGridView grid = (DataGridView)scores.Controls["dataGrid"];
            grid.DataSource = datasource.ToList();
            int height = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                height += row.Height;
            }
            height += grid.ColumnHeadersHeight;

            int width = 0;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                width += col.Width;
            }
            width += grid.RowHeadersWidth;

            grid.ClientSize = new Size(width + 2, height + 2);
        }
        public void initSlova()
        {
            Options op = Options.Instance;
            HashSet<string> vowels = new HashSet<string>() { "a", "e", "i", "o", "u" };
            HashSet<string> consonants = new HashSet<string>() {"b","c","č","ć","d","dž","đ","f","g","h","j","k","l",
            "lj","m","n","nj","p","r","s","š","t","v","z","ž"};
            op.letters.Clear();

            Random rnd = new Random();
            //safety check, wovels + consonants must be max 9
            while(op.numberOfConsonants + op.numberOfVowels > 9)
            {
                op.numberOfConsonants--;
            }
            string[] consonantsasarray = consonants.ToArray();
            string[] vowelsasarray = vowels.ToArray();
            for (int i = 0; i < op.numberOfConsonants; i++)
            {
                int rand_index = rnd.Next(consonantsasarray.Length);
                op.letters.Add(consonantsasarray[rand_index]);
            }
            for(int i= 0; i < op.numberOfVowels; i++)
            {
                int rand_index = rnd.Next(vowelsasarray.Length);
                op.letters.Add(vowelsasarray[rand_index]);
            }
            var randomized = op.letters.OrderBy(item => rnd.Next());
            List<string> randletters = randomized.ToList();
            op.letters = randletters;
            for(int i = 1; i<= op.letters.Count; i++)
            {
                slova.Controls["grpLettersToChoose"]
                    .Controls["btnLetter" + i.ToString()].Text = op.letters[i - 1];
                slova.Controls["grpLettersToChoose"]
                    .Controls["btnLetter" + i.ToString()].Visible = true;
                slova.Controls["grpLettersToChoose"]
                    .Controls["btnLetter" + i.ToString()].Enabled = true;
            }
            slova.Controls["labLetterExpression"].Text = "";
            slova.Controls["labEvaluationResult"].Text = "";
            slova.Controls["labBestResult"].Text = "";
            slova.Controls["btnNext"].Visible = false;
            slova.Controls["btnMainMenu"].Visible = false;
            slova.Controls["btnBack"].Visible = false;
            op.isNumberRound = false;
            op.currentTimerLetters = op.timerLetters;
            slova.Controls["labTimer"].Text = op.currentTimerLetters.ToString();
            timer.Enabled = true;
        }
        public void endSlova()
        {
            Options op = Options.Instance;
            for (int i = 1; i <= op.letters.Count; i++)
            {
                slova.Controls["grpLettersToChoose"]
                    .Controls["btnLetter" + i.ToString()].Visible = false;
            }
            string wordexample = WordGenerator.Generate(op.letters, op.letters.Count);
            string myword = slova.Controls["labLetterExpression"].Text;
            string eval = WordGenerator.Evaluate(myword);
            slova.Controls["labEvaluationResult"].Text = eval;
            slova.Controls["labBestResult"].Text = wordexample;
            if(eval.Equals("Correct!"))
            {
                if(myword.Length == 9)
                {
                    op.score += 18;
                }
                else
                {
                    op.score += myword.Length;
                }
            }
            if (op.currentRound == op.numberOfRounds)
            {
                slova.Controls["btnMainMenu"].Visible = true;
            } else
            {
                slova.Controls["btnNext"].Visible = true;
                slova.Controls["btnBack"].Visible = true;
            }
        }
        public void initBrojke()
        {
            Options op = Options.Instance;
            Random rnd = new Random();
            op.tokens.Clear();
            op.targetValue = rnd.Next(1, 999);
            brojke.Controls["labNumberToGuess"].Text = op.targetValue.ToString();
            op.currentTimerNumbers = op.timerNumbers;
            brojke.Controls["labTimer"].Text = op.currentTimerNumbers.ToString();
            List<int> numbers = new List<int>();
            //safety check, largenum + small must always be 6
            while(op.largeNumbers + op.smallNumbers > 6)
            {
                op.smallNumbers--;
            }

            for(int i = 0; i < op.smallNumbers; i++)
            {
                int t = rnd.Next(1, 10);
                numbers.Add(t);
            }
            HashSet<int> largenum = new HashSet<int> { 25, 50, 75, 100 };
            for (int i = 0; i < op.largeNumbers; i++)
            {
                int[] largeasarray = largenum.ToArray();
                int rand_index = rnd.Next(largeasarray.Length);
                numbers.Add(largeasarray[rand_index]);
                largenum.Remove(largeasarray[rand_index]);
            }
            numbers.Sort();
            for(int i = 1; i<=numbers.Count; i++)
            {                
                brojke.Controls["grpNumbersToChose"]
                    .Controls["btnNumber" + i.ToString()].Text = numbers[i - 1].ToString();
                brojke.Controls["grpNumbersToChose"]
                    .Controls["btnNumber" + i.ToString()].Visible = true;
                brojke.Controls["grpNumbersToChose"]
                    .Controls["btnNumber" + i.ToString()].Enabled = true;
            }
            foreach(char c in op.operators)
            {
                switch(c)
                {
                    case '+':
                        brojke.Controls["grpOperators"].Controls["btnOperatorPlus"].Enabled = true;
                        brojke.Controls["grpOperators"].Controls["btnOperatorPlus"].Visible = true;
                        break;
                    case '-':
                        brojke.Controls["grpOperators"].Controls["btnOperatorMinus"].Enabled = true;
                        brojke.Controls["grpOperators"].Controls["btnOperatorMinus"].Visible = true;
                        break;
                    case '*':
                        brojke.Controls["grpOperators"].Controls["btnOperatorTimes"].Enabled = true;
                        brojke.Controls["grpOperators"].Controls["btnOperatorTimes"].Visible = true;
                        break;
                    case '/':
                        brojke.Controls["grpOperators"].Controls["btnOperatorDivide"].Enabled = true;
                        brojke.Controls["grpOperators"].Controls["btnOperatorDivide"].Visible = true;
                        break;
                    case '^':
                        brojke.Controls["grpOperators"].Controls["btnOperatorPower"].Enabled = true;
                        brojke.Controls["grpOperators"].Controls["btnOperatorPower"].Visible = true;
                        break;
                }
            }
            numbers.Add(op.targetValue);
            op.numbers = String.Join(" ", numbers);
            brojke.Controls["btnNext"].Visible = false;
            brojke.Controls["btnBack"].Visible = false;
            op.isNumberRound = true;
            timer.Enabled = true;
            brojke.Controls["labNumericExpression"].Text = "";
            brojke.Controls["labbestExpression"].Text = "";
            brojke.Controls["labResult"].Text = "";
            brojke.Controls["labBestResult"].Text = "";
        }
        public void endBrojke()
        {
            int val;
            Options op = Options.Instance;
            brojke.Controls["labbestExpression"].Text = NumberGenerator.Generate(op.numbers, op.operators, out val);
            brojke.Controls["labBestResult"].Text = val.ToString();
            int givenVal;
            if (brojke.Controls["labResult"].Text != "")
            {
                givenVal = Convert.ToInt32(brojke.Controls["labResult"].Text);
            } else
            {
                givenVal = 0;
            }
            int difference = Math.Abs(op.targetValue - givenVal);
            brojke.Controls["btnNext"].Visible = true;
            brojke.Controls["btnBack"].Visible = true;
            if (difference == 0)
            {
                op.score += 10;
            } else if(difference < 6)
            {
                op.score += 7;

            } else if(difference > 5 && difference < 11)
            {
                op.score += 5;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            if(op.isNumberRound)
            {
                if (op.currentTimerNumbers > 0)
                {
                    op.currentTimerNumbers--;
                    brojke.Controls["labTimer"].Text = op.currentTimerNumbers.ToString();
                } else
                {
                    timer.Enabled = false;
                    endBrojke();
                }
            } else
            {
                if(op.currentTimerLetters > 0)
                {
                    op.currentTimerLetters--;
                    slova.Controls["labTimer"].Text = op.currentTimerLetters.ToString();
                } else
                {
                    timer.Enabled = false;
                    endSlova();
                }
            }
        }
        public void timerEnable()
        {
            timer.Enabled = true;
        }
        public void timerDisable()
        {
            timer.Enabled = false;
        }
    }
    
}
