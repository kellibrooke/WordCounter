using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userSentence;
        private string _userCheckWord;

        private Dictionary<string, int> wordTally = new Dictionary<string, int>();

        public string ConvertToLowerCase(string userSentence)
        {
            return userSentence.ToLower();
        }

        public string[] SentenceToWords(string userSentence)
        {
            string[] userWords = userSentence.Split(' ');
            return userWords;
        }

        public bool ContainsNoPunctuation(string userWord)
        {
            char[] individualLetters = userWord.ToCharArray();
            foreach (char letter in individualLetters)
            {
                if (!(IsLetter(individualLetters)))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
