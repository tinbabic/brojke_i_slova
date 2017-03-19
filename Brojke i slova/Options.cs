using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojke_i_slova
{
    public class Options
    {
        private static Options instance;
        private Options() { }
        public static Options Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Options();
                }
                return instance;
            }
        }
        /// <summary>
        /// Options for the game "Brojke" -> will be set in the "Postavke" userControl
        /// defaults are set here
        /// </summary>
        public string numbers;
        public int smallNumbers = 4;
        public int largeNumbers = 2;
        public string operators = "+*-/";
        public int targetValue = 437;
        public int timerNumbers = 30;
        public int currentTimerNumbers;
        public List<string> tokens = new List<string>();

        /// <summary>
        /// Options for the game "Slova" -> will be set in the "Postavke" userControl
        /// defaults are set here
        /// </summary>
        public int numberOfVowels = 3;
        public int numberOfConsonants = 6;
        public List<string> letters = new List<string>();
        public int timerLetters = 30;
        public int currentTimerLetters;

        /// <summary>
        /// Rounds to be played, one round consists of one instance of Brojke and one of Slova
        /// As well as global options such as player name, score and current round
        /// </summary>
        public int numberOfRounds = 2;
        public int currentRound = 1;
        public bool isNumberRound = true;
        public int score = 0;
        public string playerName = "Gost";
        public Dictionary<string, int> scorelist;
    }
}
