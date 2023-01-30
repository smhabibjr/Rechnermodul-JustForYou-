using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public class ValidationModul
    {

        public string Schule(string user_input)
        {
            string result = "";
            var errorList = new ArrayList();
            int[] allGrades = new int[0];

            string remove_extra_commas = Regex.Replace(user_input, ",+", ",").Trim(',');
            string[] gradesList = remove_extra_commas.Split(',');

            foreach (string grade in gradesList)
            {
                Array.Resize(ref allGrades, allGrades.Length + 1);
                allGrades[allGrades.Length - 1] = Convert.ToInt32(grade);

            }

            if (allGrades.Length > 6)
            {
                errorList.Add({ "key": 0, "value":"Die maximale Notenlänge beträgt 6" });
            }
            else
            {
                result = remove_extra_commas;
            }





            int errList = errorList.Count;
            return errList.ToString();



            //int summe_der_noten = 0;
            //for (int i = 0; i < allGrades.Length; i++)
            //{
            //    summe_der_noten = summe_der_noten + allGrades[i];
            //}
            //decimal _summe_der_noten = summe_der_noten;
            //decimal _anzahl_der_noten = allGrades.Length;
            //decimal durchschnitt_der_noten = _summe_der_noten / _anzahl_der_noten;
            //decimal empfehlung_ergebnisse = Decimal.Round(durchschnitt_der_noten);
            //result = "Anzahl der Noten: " + allGrades.Length +
            //    " Summe der Noten: " + summe_der_noten +
            //    " Durchschnitt der Noten " + Decimal.Round(durchschnitt_der_noten, 2) +
            //    " Empfehlung ergebnisse " + empfehlung_ergebnisse;

            //return result;
        }

        public int Produkt(int a, int b)
        {
            return a * b;
        }

        public int Deviation(int a, int b)
        {
            return 25;
        }
    }
}
