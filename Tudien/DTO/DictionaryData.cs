using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudien.DTO
{
    public class DictionaryData
    {
        private string key;
        private string meaning;
        private string explanation;

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public string Meaning
        {
            get
            {
                return meaning;
            }

            set
            {
                meaning = value;
            }
        }

        public string Explanation
        {
            get
            {
                return explanation;
            }

            set
            {
                explanation = value;
            }
        }

        public void setUp(string a, string b, string c)
        {
            Key = a;
            Meaning = b;
            Explanation = c;
        }
    }
}
