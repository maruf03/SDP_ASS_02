using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDP_ASS_02
{
    public class OrderedSentenceGenerator34 : IStrategy34
    {
        private List<String> vocabulary;
        private readonly Random _random;

        public OrderedSentenceGenerator34()
        {
            vocabulary = new List<string>();
            _random = new Random();
        }
        public void AddWord(string word)
        {
            char[] charArray = word.ToUpper().ToCharArray();
            Array.Reverse(charArray);
            vocabulary.Add(new string(charArray));
        }

        public String GenerateSentence()
        {
            if (vocabulary.Count == 0)
                throw new NullReferenceException("no words in vocabulary");
            int noOfWords = RandomNumber(1, 20);
            Dictionary<int, List<String>> sentence = new Dictionary<int, List<string>>();
            for (int i = 0; i < noOfWords; i++)
            {
                int index = RandomNumber(0, vocabulary.Count - 1);
                String word = vocabulary[index];
                if (!sentence.ContainsKey(index))
                {
                    sentence.Add(index, new List<string>());
                }
                sentence[index].Add(word);
            }

            List<String> generatedSentence = new List<string>();
            foreach (var wordList in sentence.OrderBy(i => i.Key))
            {
                generatedSentence.AddRange(wordList.Value);
            }

            Console.WriteLine("OrderedSentenceGenerator");
            return String.Join(" ", generatedSentence);
        }

        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public List<string> GetVocabularyList()
        {
            return vocabulary;
        }
    }
}
