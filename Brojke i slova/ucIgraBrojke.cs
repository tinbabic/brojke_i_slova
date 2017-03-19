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
    public partial class ucIgraBrojke : UserControl
    {
        public ucIgraBrojke()
        {
            InitializeComponent();
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber1.Text);
            labNumericExpression.Text += btnNumber1.Text;
            btnNumber1.Enabled = false;
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber2.Text);
            labNumericExpression.Text += btnNumber2.Text;
            btnNumber2.Enabled = false;
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber3.Text);
            labNumericExpression.Text += btnNumber3.Text;
            btnNumber3.Enabled = false;
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber4.Text);
            labNumericExpression.Text += btnNumber4.Text;
            btnNumber4.Enabled = false;
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber5.Text);
            labNumericExpression.Text += btnNumber5.Text;
            btnNumber5.Enabled = false;
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnNumber6.Text);
            labNumericExpression.Text += btnNumber6.Text;
            btnNumber6.Enabled = false;
        }

        private void btnOperatorPlus_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorPlus.Text);
            labNumericExpression.Text += btnOperatorPlus.Text;
        }

        private void btnOperatorMinus_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorMinus.Text);
            labNumericExpression.Text += btnOperatorMinus.Text;
        }

        private void btnOperatorTimes_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorTimes.Text);
            labNumericExpression.Text += btnOperatorTimes.Text;
        }

        private void btnOperatorDivide_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorDivide.Text);
            labNumericExpression.Text += btnOperatorDivide.Text; 
        }

        private void btnOperatorPower_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorPower.Text);
            labNumericExpression.Text += btnOperatorPower.Text; 
        }

        private void btnOperatorOpenBracket_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorOpenBracket.Text);
            labNumericExpression.Text += btnOperatorOpenBracket.Text;  
        }

        private void btnOperatorCloseBracket_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            op.tokens.Add(btnOperatorCloseBracket.Text);
            labNumericExpression.Text += btnOperatorCloseBracket.Text;   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            labNumericExpression.Text = "";
            foreach(Control i in grpNumbersToChose.Controls)
            {
                i.Enabled = true;
            }
            op.tokens.Clear();
        }

        private void labNumericExpression_TextChanged(object sender, EventArgs e)
        {
            Options op = Options.Instance;
            string[] tokens = op.tokens.ToArray();
            int error;
            int val = ExpressionEvaluator.Evaluate(tokens, out error);
            labResult.Text = val.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).initSlova();
            ((Form1)ParentForm).showSlova();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).timerDisable();
            ((Form1)ParentForm).endBrojke();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            ((Form1)ParentForm).showMain();
        }
    }
}
