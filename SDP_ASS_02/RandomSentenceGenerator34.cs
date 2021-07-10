using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_ASS_02
{
    public class RandomSentenceGenerator34 : IStrategy34
    {
        private List<String> vocabulary;
        private readonly Random _random;

        public RandomSentenceGenerator34()
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
            String sentence = "";
            for (int i = 0; i < noOfWords; i++)
            {
                String word = vocabulary[RandomNumber(0, vocabulary.Count-1)];
                sentence += (word + " ");
            }

            sentence = sentence.Trim();
            Console.WriteLine("RandomSentenceGenerator");
            return sentence;
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
