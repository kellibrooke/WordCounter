using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userSentence;
        private string _userCheckWord;

        private Dictionary<string, int> _wordTally = new Dictionary<string, int>();

        public Dictionary<string, int> GetTally()
        {
          return _wordTally;
        }

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
            foreach (char letter in userWord)
            {
                if(!Char.IsLetter(letter))
                {
                      return false;
                }
            }
            return true;
        }

        public void CreateWordTally(string[] userWords)
        {
            foreach (string word in userWords)
            {
              if (_wordTally.ContainsKey(word))
              {
                  _wordTally[word] += 1;
              }
              else
              {
                  _wordTally.Add(word, 1);
              }
            }
        }
    }
}
