using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class SpellChecker
    {
		private Dictionary<string,List<string>> spellCheckDictionary;
        private string word;
        private int errorCount;

        public Dictionary<string,List<string>> SpellCheckDictionary
		{
			get { return spellCheckDictionary; }
			set { spellCheckDictionary = value; }
		}
		
		public string Word
		{
			get { return word; }
			set { word = value; }
		}
		
		public int ErrorCount
		{
			get { return errorCount; }
			set { errorCount = value; }
		}

	}
}
