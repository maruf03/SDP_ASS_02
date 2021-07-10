using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_ASS_02
{
    public partial class SentenceGeneratorForm34 : Form
    {
        private GeneratorContext34 context;
        private String _defaultStrategy;
        public SentenceGeneratorForm34()
        {
            InitializeComponent();
            context = new GeneratorContext34();
            context.AddStrategy("Ordered Sentence Generator", new OrderedSentenceGenerator34()); 
            context.AddStrategy("Random Sentence Generator", new RandomSentenceGenerator34());
            context.AddStrategy("Sorted Sentence Generator", new SortedSentenceGenerator34());
            StrategyList.SelectedIndex = 0;
            _defaultStrategy = StrategyList.Items[0].ToString();
            context.SetStrategy(_defaultStrategy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(word.Text))
                return;
            VocabularyList.Items.Add(word.Text);
            context.AddWord(word.Text);
            word.Clear();
            word.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String sentence = context.GenerateSentence();
                MessageBox.Show(this, sentence);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(this, "No words in Vocabulary");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrategyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _defaultStrategy = StrategyList.Items[StrategyList.SelectedIndex].ToString();
            context.SetStrategy(_defaultStrategy);
            VocabularyList.Items.Clear();
            var vocabulary = context.GetVocabularyList();

            for (int i = 0; i < vocabulary.Count; i++)
                VocabularyList.Items.Add(new ListViewItem(vocabulary[i]));
        }
    }
}
