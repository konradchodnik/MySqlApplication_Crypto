using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlApp.Models
{
    public class DanePass
    {
        private string hasloPass;
        public string HasloPass
        {
            get { return hasloPass; }
            set { hasloPass = value; }
        }

        private string haslosaltPass;
        public string HaslosaltPass
        {
            get { return haslosaltPass; }
            set { haslosaltPass = value; }
        }

        public DanePass(string haslopass, string haslosaltpass)
        {
            HasloPass = hasloPass;
            HaslosaltPass = haslosaltpass;
        }
    }
}
