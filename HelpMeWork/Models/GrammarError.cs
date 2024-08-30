using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class GrammarError
    {
		private bool grammarErrorPresent;
        private string errorMessage;
        private int startIndex;
        private int endIndex;
        private List<string> suggestionSuggestion;

        public bool GrammarErrorPresent
		{
			get { return grammarErrorPresent; }
			set { grammarErrorPresent = value; }
		}
		
		public string ErrorMessage
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}
		
		public int StartIndex
		{
			get { return startIndex; }
			set { startIndex = value; }
		}
		
		public int EndIndex
		{
			get { return endIndex; }
			set { endIndex = value; }
		}
		
		public List<string> MyProperty
		{
			get { return suggestionSuggestion; }
			set { suggestionSuggestion = value; }
		}

	}
}
