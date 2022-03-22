using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    class CD
    {
        private string uitvoerder;
        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string Uitvoerder
        {
            get { return uitvoerder; }
            set { uitvoerder = value; }
        }

        public CD(string Uitvoerder, string Titel)
        {
            uitvoerder = Uitvoerder;
            titel = Titel;
        }
        public CD()
        {
            titel = "Titel";
            uitvoerder = "Uitvoerder";
        }
        //REMEMBER!!
        //Optie 2: (check main)

        //public override string ToString()
        //{
        //    return this.titel + " - " + this.uitvoerder;
        //}
    }
}
