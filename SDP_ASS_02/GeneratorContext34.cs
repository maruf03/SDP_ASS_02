using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_ASS_02
{
    public class GeneratorContext34: IStrategy34
    {
        private Dictionary<string, IStrategy34> StrategyMap;
        private IStrategy34 _strategy;

        public GeneratorContext34()
        {
            StrategyMap = new Dictionary<string, IStrategy34>();
            _strategy = null;
        }
        public void AddWord(string word)
        {
            _strategy.AddWord(word);
        }

        public string GenerateSentence()
        {
            return _strategy.GenerateSentence();
        }

        public void SetStrategy(string strategy)
        {
            _strategy = StrategyMap[strategy];
        }

        public void AddStrategy(string name, IStrategy34 strategy)
        {
            StrategyMap.Add(name, strategy);
        }

        public List<string> GetVocabularyList()
        {
            return _strategy.GetVocabularyList();
        }
    }
}
