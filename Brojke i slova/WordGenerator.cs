using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojke_i_slova
{
    class WordGenerator
    {
        public static string Generate(List<string> letters, int length)
        {
            for(int k = length; k >= 1; k--)
            {
                // Open file with words of length k and try to find
                // a word that contains only letters from list "letters"
                string name = "HR" + k.ToString()+".txt";
                string text = System.IO.File.ReadAllText(name);
                string[] words = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(string word in words)
                {
                    List<string> word_letters = StringToList(word);
                    if (CustomSublist(word_letters, letters))
                        return word;
                }
            }

            return "X";
        }

        static public List<string> StringToList(string word)
        {
            List<string> L = new List<string>();
            word = word.ToLower();

            for(int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == 'd' && word[i + 1] == 'ž')
                {
                    L.Add("dž");
                    i++;
                }
                else if (word[i] == 'l' && word[i + 1] == 'j')
                {
                    L.Add("lj");
                    i++;
                }
                else if (word[i] == 'n' && word[i + 1] == 'j')
                {
                    L.Add("nj");
                    i++;
                }
                else L.Add(word[i].ToString());
            }
            L.Add(word[word.Length - 1].ToString());
            return L;
        } 

        static public bool CustomSublist(List<string> list1, List<string> list2)
        {
            List<string> list3 = new List<string>(list2);

            foreach (string a in list1)
            {
                if (!list3.Contains(a))
                    return false;
                else
                    list3.Remove(a);
            }
            return true;
        }

        public static string Evaluate(string userWord)
        {
            if (userWord != "")
            {
                int k = userWord.Length;
                // Open file with words of length k and
                // try to find the selected word
                string name = "HR" + k.ToString() + ".txt";
                string text = System.IO.File.ReadAllText(name);
                string[] words = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word.ToLower() == userWord.ToLower())
                        return "Correct!";
                }

                return "False!";
            }
            return "Please give a word.";
        }
    }
}
