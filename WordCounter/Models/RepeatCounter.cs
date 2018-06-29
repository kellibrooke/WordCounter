using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            RepeatCounter newTest = new RepeatCounter();
            Console.WriteLine("Enter a sentence.");
            string theSentence = Console.ReadLine();

        }
    }
    public class RepeatCounter
    {
        private string[] _userSentence;
        private string _userCheckWord;

        private Dictionary<string, int> _wordTally = new Dictionary<string, int>();

        public void SetUserSentence(string userSentence)
        {
            string[] validaterSentence = this.SentenceToWords(userSentence);
            if (this.SentenceContainsNoPunctuation(validaterSentence))
            {
                string lowerCaseSentence = userSentence.ToLower();
                _userSentence = this.SentenceToWords(lowerCaseSentence);
            }
            else
            {
                _userSentence = new string[] {};
            }
        }

        public string[] GetUserSentence()
        {
            return _userSentence;
        }

        public void SetUserCheckWord(string userWord)
        {
            if (this.WordContainsNoPunctuation(userWord))
            {
                string lowerCaseWord = userWord.ToLower();
                _userCheckWord = lowerCaseWord;
            }
            else
            {
                _userCheckWord = String.Empty;
            }
        }

        public string GetUserCheckWord()
        {
            return _userCheckWord;
        }

        public Dictionary<string, int> GetWordTally()
        {
            return _wordTally;
        }

        public string[] SentenceToWords(string userSentence)
        {
            string[] userWords = userSentence.Split(' ');
            return userWords;
        }

        public bool SentenceContainsNoPunctuation(string[] userWords)
        {
            for (int x=0; x<userWords.Length; x++)
            {
                foreach (char letter in userWords[x])
                {
                    if(!Char.IsLetter(letter))
                    {
                          return false;
                    }
                }
            }
            return true;
        }

        public bool WordContainsNoPunctuation(string userWord)
        {
            char[] wordArray = userWord.ToCharArray();
            foreach (char letter in wordArray)
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

        public int WordRepeatAmount(string userWord)
        {
            int numberOfRepeats;
            _wordTally.TryGetValue(userWord, out numberOfRepeats);
            return numberOfRepeats;
        }

    }
}
