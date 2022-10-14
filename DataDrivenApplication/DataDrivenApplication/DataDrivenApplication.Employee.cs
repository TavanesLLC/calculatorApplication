using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataDrivenApplication
{
    public class Employee
    {
        public string? Name { get; set; }

        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                Regex regex = new Regex(@"/^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/");
                Match match =  regex.Match(value);
                if(match.Success)
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Invalid email formate");
                }

            }
        }
    }
}
