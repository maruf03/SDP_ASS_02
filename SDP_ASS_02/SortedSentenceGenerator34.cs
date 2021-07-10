using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_ASS_02
{
    public class SortedSentenceGenerator34 : IStrategy34
    {
        private List<String> vocabulary;
        private readonly Random _random;

        public SortedSentenceGenerator34()
        {
            vocabulary = new List<string>();
            _random = new Random();
        }
        public void AddWord(string word)
        {
            vocabulary.Add(word.ToLower());
        }

        public String GenerateSentence()
        {
            if (vocabulary.Count == 0)
                throw new NullReferenceException("no words in vocabulary");
            int noOfWords = RandomNumber(1, 20);
            List<String> sentence = new List<string>();
            for (int i = 0; i < noOfWords; i++)
            {
                String word = vocabulary[RandomNumber(0, vocabulary.Count-1)];
                sentence.Add(word);
            }

            sentence.Sort();
            Console.WriteLine("SortedSentenceGenerator");
            return String.Join(" ", sentence);
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
