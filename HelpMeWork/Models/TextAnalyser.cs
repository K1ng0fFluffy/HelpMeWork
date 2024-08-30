using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class TextAnalyser
    {
		private int wordCount;
        private int sentenceCount;
        private int searchWordCount;

        public int WordCount
		{
			get { return wordCount; }
			set { wordCount = value; }
		}
		
		public int SentenceCount
		{
			get { return sentenceCount; }
			set { sentenceCount = value; }
		}
		
		public int SearchWordCount
		{
			get { return searchWordCount; }
			set { searchWordCount = value; }
		}

	}
}
