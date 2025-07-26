using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class hiringDate
    {

        public int day { get; set; }
        public int month { get; set; }
        public long year { get; set; }


        public hiringDate()
        {

        }

        public hiringDate(int day, int month, long year)
        {
            this.day = (day >= 1 || day <= 31) ?day : throw new ArgumentException("Invalid day.");
            this.month = (month >= 1 || month <= 12)? month : throw new ArgumentException("Invalid month.");
           this.year = (year > 1900 || year < DateTime.Now.Year )? year : throw new ArgumentException("Invalid Year.");
        }

        public override string ToString()
        {
            return $"{day:00}/{month:00}/{year}";
        }
    }
}
