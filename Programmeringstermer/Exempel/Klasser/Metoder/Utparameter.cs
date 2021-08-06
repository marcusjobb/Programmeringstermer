using System;
using System.Globalization;

namespace Programmeringstermer.Exempel.Klasser.Metoder.Utparameter
{
    public class Utparameter_demo
    {
        private string currentDate;
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