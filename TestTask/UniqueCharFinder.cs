using System;
using System.Collections.Generic;

namespace TestTask
{
    public class UniqueCharFinder
    {
        public char FindFirstUniqueCharInText(string text)
        {
            List<char> _firstUniqueCharInWord = FindFirstUniqueCharsInWords(SplitText(text));

            string _firstuniqueCharsString = string.Join("", _firstUniqueCharInWord);

            return FindFirstUniqueCharInString(_firstuniqueCharsString);
        }

        private IEnumerable<string> SplitText(string text)
        {
            return text.ToLower().Split(' ');
        }

        private List<char> FindFirstUniqueCharsInWords(IEnumerable<string> words)
        {
            var _firstUniqueCharInWord = new List<char>();

            foreach (string word in words)
                _firstUniqueCharInWord.Add(FindFirstUniqueCharInString(word));

            return _firstUniqueCharInWord;
        }

        private char FindFirstUniqueCharInString(string word)
        {
            if (word.Length == 1)
            {
                return Convert.ToChar(word);
            }
            
            for (int i = 0; i < word.Length-1; i++)
            {
                bool _duplicated = false;

                for (int j = i+1; j < word.Length; j++)
                {
                    if (word[j] == word[i])
                    {
                        _duplicated = true;
                        word = word.Replace(word[j], ' ');
                        break;
                    }
                }

                if (!_duplicated)
                    return word[i];
            }

            return ' ';
        }
    }
}