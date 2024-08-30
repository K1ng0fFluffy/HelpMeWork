using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class LanguageDetector
    {
		private Dictionary<string,float> languagePropabilities;

		public Dictionary<string,float> LanguageProbabilities
		{
			get { return languagePropabilities; }
			set { languagePropabilities = value; }
		}

	}
}
