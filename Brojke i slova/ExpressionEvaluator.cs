using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojke_i_slova
{
    class ExpressionEvaluator
    {
        public static int Evaluate(string[] tokens, out int error)
        {
            error = 0;
            Queue<string> outputQueue = new Queue<string>();
            // Reverse Polish Notation Expression
            outputQueue = getRPN(tokens, out error);
            if (error == 1)  return 0;

            int result = calculateRPN(outputQueue, out error);
            return result;
        }

        static Queue<string> getRPN(string[] token, out int error)
        {
            error = 0;
            Stack<string> operatorStack = new Stack<string>();
            Queue<string> outputQueue = new Queue<string>();

            //Shunting Yard Algorithm 
            for (int i = 0; i < token.Length; i++)
            {
                if (isANumber(token[i]))
                {
                    outputQueue.Enqueue(token[i]);
                }
                else if (token[i].Equals("^"))
                {
                    operatorStack.Push(token[i]);
                }
                else if (operatorPrecedence(token[i]) != -1)
                {
                    while (operatorStack.Count != 0 && operatorPrecedence(operatorStack.Peek()) >= operatorPrecedence(token[i]))
                    {
                        outputQueue.Enqueue(operatorStack.Pop());
                    }
                    operatorStack.Push(token[i]);
                }
                else if (token[i].Equals("("))
                {
                    operatorStack.Push(token[i]);
                }
                else if (token[i].Equals(")"))
                {
                    try
                    {
                        while (!operatorStack.Peek().Equals("("))
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                    }
                    catch
                    {
                        error = 1;
                        return outputQueue;
                    }
                    operatorStack.Pop();
                }
            }

            while (operatorStack.Count != 0)
            {
                outputQueue.Enqueue(operatorStack.Pop());
            }

            return outputQueue;
        }

        static bool isANumber(string n)
        {
            int retNum;
            bool isNumeric = int.TryParse(n, out retNum);
            return isNumeric;
        }

        static int operatorPrecedence(string n)
        {
            int precedence = -1;
            char c = n[0];
            switch (c)
            {
                case '+':
                case '-':
                    precedence = 2;
                    break;
                case '*':
                case '/':
                    precedence = 3;
                    break;
                case '^':
                    precedence = 4;
                    break;

                default:
                    precedence = -1;
                    break;
            }
            return precedence;
        }

        static int calculateRPN(Queue<string> inputQueue, out int error)
        {
            error = 0;
            Stack<string> outputStack = new Stack<string>();

            while (inputQueue.Count != 0)
            {
                string s = inputQueue.Dequeue();
                if (isANumber(s))
                {
                    outputStack.Push(s);
                }
                else
                {
                    if (outputStack.Count < 2)
                    {
                        error = 1;
                        return 0;
                    }
                    else
                    {
                        string value1, value2;
                        int a, b, result = 0;
                        value2 = outputStack.Pop();
                        value1 = outputStack.Pop();
                        a = Int32.Parse(value1);
                        b = Int32.Parse(value2);

                        if (s.Equals("+")) result = a + b;
                        else if (s.Equals("-")) result = a - b;
                        else if (s.Equals("*")) result = a * b;
                        else if (s.Equals("/"))
                        {
                            if (b == 0 || a % b != 0)
                            {
                                error = 1;
                                return 0;
                            }
                            result = a / b;
                        }
                        else if (s.Equals("^"))
                        {
                            if (b < 0)
                            {
                                error = 1;
                                return 0;
                            }
                            result = (int)Math.Pow(a, b);
                        }

                        string retVal = Convert.ToString(result);
                        outputStack.Push(retVal);
                    }
                }
            }

            if (outputStack.Count == 1)
            {
                int outcome = Int32.Parse(outputStack.Pop());
                return outcome;
            }
            else
            {
                error = 1;
                return 0;
            }
        }
    }
}
