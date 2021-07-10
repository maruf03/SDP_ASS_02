using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_ASS_02
{
    public interface IStrategy34
    {
        public void AddWord(String word);
        public String GenerateSentence();

        public List<String> GetVocabularyList();
    }
}
