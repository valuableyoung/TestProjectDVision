using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLetter
{
     class DataBaseLetterInfo
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string To { get; set; }
        public string Sender { get; set; }
        public string LetterBody { get; set; }

        public DataBaseLetterInfo(string Subject, string To, string Sender, string LetterBody )
        {
            this.Subject = Subject;
            this.To = To;
            this.Sender = Sender;
            this.LetterBody = LetterBody;
            Date = DateTime.Now;
            
        }
        public DataBaseLetterInfo()
        {

        }
    }
}
