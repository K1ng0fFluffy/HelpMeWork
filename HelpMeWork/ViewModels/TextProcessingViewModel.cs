using HelpMeWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace HelpMeWork.ViewModels
{
    public class TextProcessingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private readonly GrammarChecker grammarChecker;
        private readonly LanguageDetector languageDetector;
        private readonly SpellChecker spellChecker;
        private readonly SynonymFinder synonymFinder;
        private readonly TextAnalyser textAnalyser;
        private readonly TextFormatter textFormatter;

        private string inputText;

        public string InputText
        {
            get 
            {
                return inputText;
            }
            set
            {
                inputText = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> SpellCheckResult { get; set; }
        public ObservableCollection<GrammarError> GrammarCheckResult { get; set; }
        public string FormattedText { get; set; }

        // Commands?

        public TextProcessingViewModel()
        {
            grammarChecker = new GrammarChecker();
            languageDetector = new LanguageDetector();
            spellChecker = new SpellChecker();
            synonymFinder = new SynonymFinder();
            textAnalyser = new TextAnalyser();
            textFormatter = new TextFormatter();

            SpellCheckResult = new ObservableCollection<string>();
            GrammarCheckResult = new ObservableCollection<GrammarError>();
            GrammarCheckResult = new ObservableCollection<GrammarError>();
        }

        private void CheckGrammar()
        {

        }

        private void DetectCurrentLanguage()
        {

        }

        private void CheckSpelling()
        {

        }

        private void FindSynonym()
        {

        }

        private void AnalyzeText()
        {

        }

        private void FormatText()
        {

        }
    }
}
