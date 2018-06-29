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
    }
}
