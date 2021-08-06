using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringstermer.Exempel.Klasser.Utparameter
{
    public class Utparameter_demo
    {
        string currentDate;
        public string CurrentDate { get { return currentDate; } }
        public Utparameter_demo()
        {
            currentDate = GetLocalDate();
        }

        private string GetLocalDate()
        {
            DateTime dateValue = DateTime.Now;
            CultureInfo culture = CultureInfo.CurrentCulture;
            return dateValue.ToString(culture);
        }
    }
}
