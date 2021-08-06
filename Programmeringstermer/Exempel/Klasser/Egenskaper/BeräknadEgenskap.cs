using System;

namespace Programmeringstermer.Exempel.Klasser.Egenskaper.BeräknadEgenskap
{
    //public void main()
    //{
    //    Person Marc = new Person();
    //    Marc.Birthday = new DateTime(1970, 6, 20);
    //    Console.WriteLine(Marc.Age);
    //}
    public class Person
    {
        private DateTime birthday = DateTime.Now;

        //DateTime är ett objekt som hjälper en med datumhantering
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            //Denna egenskapen lämnar ifrån sig åldern på personen, även
            //om det inte finns ett fält som håller reda på åldern i sig.
            //Agen beräknas baserat på fältet som anger personens birthday.
            //Denna egenskapen är "skrivskyddad", den kan inte skrivas till
            //(det finns ingen set metod)
            get
            {
                DateTime thisYear = new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);
                TimeSpan timePassed = thisYear - birthday;
                return (int)(timePassed.Days / 365.25);
            }
        }
    }
}