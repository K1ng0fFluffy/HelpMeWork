using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMeWork.Models
{
    public class TextProcessorModel
    {
		private string inputText;
		private string _id;
        private TextFormatter textFormatter;

        public string _ID
		{
			get { return _id; }
			set { _id = value; }
		}

		public string InputText
		{
			get { return inputText; }
			set { inputText = value; }
		}

		public TextFormatter TextFormatter
		{
			get { return textFormatter; }
			set { textFormatter = value; }
		}

	}
}
