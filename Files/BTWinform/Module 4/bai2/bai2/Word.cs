using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Word
    {
        private String english;
        private String vietnamese;

        public Word(String en, String vi)
        {
            english = en;
            vietnamese = vi;
        }

        public string English
        {
            get
            {
                return english;
            }

            set
            {
                english = value;
            }
        }

        public string Vietnamese
        {
            get
            {
                return vietnamese;
            }

            set
            {
                vietnamese = value;
            }
        }
    }
}
