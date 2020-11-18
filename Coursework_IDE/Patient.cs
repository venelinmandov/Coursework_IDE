using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_IDE
{
    public class Patient
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }

        public string lastName { get; set; }
        public string egn { get; set; }

        public string sex { get; set; }

        public DateTime birthday { get; set; }

        public override string ToString()
        {
            return $"{firstName} {lastName} {egn}";
        }

    }
}
