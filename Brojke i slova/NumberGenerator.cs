using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojke_i_slova
{
    public class NumberGenerator
    {
        public static int Distance(int a, int b)
        {
            if (a < b)
                return b - a;
            return a - b;
        }

        public static string Generate(string s, string operators, out int outputValue)
        { 
            string[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[parts.Length-1];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = int.Parse(parts[i]);

            int targetValue = int.Parse(parts[parts.Length-1]);

            // Generate all non-trivial subsets of array 'numbers'
            // starting with the whole set

            string outputExpression = "";
            outputValue = 0;

            for (int i = (int)Math.Pow(2, numbers.Length)-1; i > 0; i--)
            {
                List<int> combination = new List<int>();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if ((i & (1 << (numbers.Length - j - 1))) != 0)
                    {
                        combination.Add(numbers[j]);
                    }
                } 
                     
                int approximation;
                string result = OneIteration(combination.ToArray(), targetValue, operators, out approximation);
                if (Distance(approximation, targetValue) < Distance(outputValue, targetValue))
                {
                    outputValue = approximation;
                    outputExpression = result;
                }
            }

            return outputExpression;
        }

        static string OneIteration(int[] numbers, int targetValue, string operators, out int approximation)
        {
            int targetKey = (targetValue << numbers.Length) + (1 << numbers.Length) - 1;
            // (value << numbers.Length) represents expression value
            // (1 << numbers.Length) - 1 represents mask with all bits set to 1,
            // i.e. mask in which each input number has been used exactly once
            // to build the expression.

            HashSet<int> solvedKeys = new HashSet<int>();
            // Each number in the collection indicates that corresponding value + mask
            // has been reached using arithmetical operations.

            Dictionary<int, int> keyToLeftParent = new Dictionary<int, int>();
            // For each solved key (value + mask), there is an entry indicating
            // result of the expression on the left side of the arithmetic
            // operator. Missing value indicates that key represents the
            // raw number (taken from the input list), rather than
            // the result of a calculation.

            Dictionary<int, int> keyToRightParent = new Dictionary<int, int>();
            // Same as keyToLeftParent, only indicating the right parent
            // used to build the expression.

            Dictionary<int, char> keyToOperator = new Dictionary<int, char>();
            // Indicates arithmetic operator used to build this node
            // from left and right parent nodes. Missing value for a given key
            // indicates that key is a raw value taken from input array,
            // rather than result of an arithmetic operation.

            Queue<int> queue = new Queue<int>();
            // Keys (value + mask pairs) that have not been processed yet

            // First step is to initialize the structures:
            // Add all input values into corresponding array entries and
            // add them to the queue so that the operation can begin

            for (int i = 0; i < numbers.Length; i++)
            {
                int key = (numbers[i] << numbers.Length) + (1 << i);

                solvedKeys.Add(key);
                queue.Enqueue(key);
            }

            // Now expand entries one at the time until queue is empty,
            // i.e. until there are no new entries populated.
            // Additional stopping condition is that target key has been generated,
            // which indicates that problem has been solved and there is no need to
            // expand nodes any further.

            while (queue.Count > 0 && !solvedKeys.Contains(targetKey))
            {
                int curKey = queue.Dequeue();

                int curMask = curKey & ((1 << numbers.Length) - 1);
                int curValue = curKey >> numbers.Length;

                // Now first take a snapshot of all keys that
                // have been reached because this collection is going to
                // change during the following operation

                int[] keys = new int[solvedKeys.Count];
                solvedKeys.CopyTo(keys);

                for (int i = 0; i < keys.Length; i++)
                {

                    int mask = keys[i] & ((1 << numbers.Length) - 1);
                    int value = keys[i] >> numbers.Length;

                    if ((mask & curMask) == 0)
                    {
                        // Masks are disjoint, i.e. two entries do not use
                        // the same input number twice.
                        // This is sufficient condition to combine the two entries

                        for (int op = 0; op < 8; op++)
                        {

                            char opSign = '\0';
                            int newValue = 0;

                            switch (op)
                            {
                                case 0: // Addition
                                    newValue = curValue + value;
                                    opSign = '+';
                                    break;
                                case 1: // Subtraction - another value subtracted from current
                                    newValue = curValue - value;
                                    opSign = '-';
                                    break;
                                case 2: // Subtraction - current value subtracted from another
                                    newValue = value - curValue;
                                    opSign = '-';
                                    break;
                                case 3: // Multiplication
                                    newValue = curValue * value;
                                    opSign = '*';
                                    break;
                                case 4: // Division - current divided by another
                                    newValue = -1;  // Indicates failure to divide
                                    if (value != 0 && curValue % value == 0)
                                        newValue = curValue / value;
                                    opSign = '/';
                                    break;
                                case 5: // Division - other value divided by current
                                    newValue = -1;  // Indicates failure to divide
                                    if (curValue != 0 && value % curValue == 0)
                                        newValue = value / curValue;
                                    opSign = '/';
                                    break;
                                case 6: // Exponents - current to the power of other
                                    newValue = -1;
                                    if (value >= 0)
                                        newValue = (int)Math.Pow(curValue, value);
                                    opSign = '^';
                                    break;
                                case 7: // Exponents - other to the power of current
                                    newValue = -1;
                                    if(value >= 0)
                                        newValue = (int)Math.Pow(value, curValue);
                                    opSign = '^';
                                    break;
                            }

                            if (newValue >= 0 && operators.Contains(opSign))
                            {
                                // Ignore negative values - they can always be created
                                // the other way around, by subtracting them
                                // from a larger value so that positive value is reached.

                                int newMask = (curMask | mask);
                                // Combine the masks to indicate that all input numbers
                                // from both operands have been used to produce
                                // the resulting expression

                                int newKey = (newValue << numbers.Length) + newMask;

                                if (!solvedKeys.Contains(newKey))
                                {
                                    // We have reached a new entry.
                                    // This expression should now be added
                                    // to data structures and processed further
                                    // in the following steps.

                                    // Populate entries that describe newly created expression
                                    solvedKeys.Add(newKey);

                                    if (op == 2 || op == 5 || op == 7)
                                    {
                                        // Special cases - antireflexive operations
                                        // with interchanged operands
                                        keyToLeftParent.Add(newKey, keys[i]);
                                        keyToRightParent.Add(newKey, curKey);
                                    }
                                    else
                                    {
                                        keyToLeftParent.Add(newKey, curKey);
                                        keyToRightParent.Add(newKey, keys[i]);
                                    }

                                    keyToOperator.Add(newKey, opSign);

                                    // Add expression to list of reachable expressions
                                    solvedKeys.Add(newKey);

                                    // Add expression to the queue for further expansion
                                    queue.Enqueue(newKey);
                                }
                            }
                        }
                    }
                }
            }

            // Print best approximation of targetValue

            int testedValue = targetValue;
            int testedKey = targetKey;

            while (testedValue >= 0)
            {
                if (solvedKeys.Contains(testedKey))
                {
                    approximation = testedValue;
                    return ExpressionAsString(keyToLeftParent, keyToRightParent, keyToOperator, testedKey, numbers.Length);
                }
               
                if (testedValue < targetValue)
                    testedValue = targetValue + (targetValue - testedValue);
                else
                    testedValue = targetValue - (testedValue - targetValue) - 1; 

                testedKey = (testedValue << numbers.Length) + (1 << numbers.Length) - 1;
            }
            approximation = 0;
            return "";
        }

        static string ExpressionAsString(Dictionary<int, int> keyToLeftParent, Dictionary<int, int> keyToRightParent, 
                                         Dictionary<int, char> keyToOperator, int key, int numbersCount)
        {
            if (!keyToOperator.ContainsKey(key))
                return (key >> numbersCount).ToString();
            else
            {
                string s1, s2, s3;

                // Recursively print the left operand
                s1=ExpressionAsString(keyToLeftParent, keyToRightParent, keyToOperator, keyToLeftParent[key], numbersCount);

                // Then print the operation sign
                s2=(keyToOperator[key]).ToString();

                // Finally, print the right operand
                s3=ExpressionAsString(keyToLeftParent, keyToRightParent, keyToOperator, keyToRightParent[key], numbersCount);

                return "(" + s1 + s2 + s3 + ")";
            }
        }
    }
}
