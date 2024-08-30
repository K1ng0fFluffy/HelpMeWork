using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class TextFormatter
    {
		private string formattingRules;
        private GrammarChecker grammarChecker;
        private GrammarError grammarError;
        private LanguageDetector languageDetector;
        private SpellChecker spellChecker;
        private SynonymFinder synonymFinder;
        private TextAnalyser textAnalyser;


        public string FormattingRules
		{
			get { return formattingRules; }
			set { formattingRules = value; }
		}
        public GrammarChecker GrammarChecker
        {
            get { return grammarChecker; }
            set { grammarChecker = value; }
        }
        public GrammarError GrammarError
		{
			get { return grammarError; }
			set { grammarError = value; }
		}
		public LanguageDetector LanguageDetector
		{
			get { return languageDetector; }
			set { languageDetector = value; }
		}
		public SpellChecker SpellChecker
		{
			get { return spellChecker; }
			set { spellChecker = value; }
		}
		public SynonymFinder SynonymFinder
		{
			get { return synonymFinder; }
			set { synonymFinder = value; }
		}
		public TextAnalyser TextAnalyzer
		{
			get { return textAnalyser; }
			set { textAnalyser = value; }
		}
	}
}
