using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_calculator
{
    public class Settings
    {
        #region settings
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public string Operator { get; set; }
        public bool Two { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
        public int M4 { get; set; }
        public int countM { get; set; }
        public int M5 { get; set; }
        public int M6 { get; set; }
        public int M7 { get; set; }
        public int M8 { get; set; }
        public int countM2 { get; set; }
        public int countButton { get; set; }
        public bool ans { get; set; }

        public Settings(int First, int Second, int Third, string Operator, bool Two)
        {
            this.First = First;
            this.Second = Second;
            this.Third = Third;
            this.Operator = Operator;
            this.Two = Two;
        }
        #endregion
        #region math
        public string Math()
        {
            int first;
            if (Two == false && ans == false)
            {
                first = First;
            }
            else if (Two == true && ans == false)
            {
                first = Second;
            }
            else
            {
                first = Third;
            }
            string Roman = "";
            while (first >= 1000){Roman += "M";first = first - 1000;}
            while (first >= 900){Roman += "CM"; first = first - 900;}
            while (first >= 500){Roman += "D";first = first - 500;}
            while (first >= 400){Roman += "CD"; first = first - 400;}
            while (first >= 100){Roman += "C";first = first - 100;}
            while (first >= 90){Roman += "XC"; first = first - 90;}
            while (first >= 50){Roman += "L";first = first - 50;}
            while (first >= 40){Roman += "XL"; first = first - 40;}
            while (first >= 10){Roman += "X";first = first - 10;}
            while (first >= 9){Roman += "IX"; first = first - 9;}
            while (first >= 5){Roman += "V";first = first - 5;}
            while (first >= 4){Roman += "IV"; first = first - 4;}
            while (first >= 1){Roman += "I";first = first - 1;}
            return Roman;
        }
        public string Math4()
        {
            int third = Third;
            string Roman = "";
            while (third <= -1000) { Roman += "M"; third = third + 1000; }
            while (third <= -900) { Roman += "CM"; third = third + 900; }
            while (third <= -500) { Roman += "D"; third = third + 500; }
            while (third <= -400) { Roman += "CD"; third = third + 400; }
            while (third <= -100) { Roman += "C"; third = third + 100; }
            while (third <= -90) { Roman += "XC"; third = third + 90; }
            while (third <= -50) { Roman += "L"; third = third + 50; }
            while (third <= -40) { Roman += "XL"; third = third + 40; }
            while (third <= -10) { Roman += "X"; third = third + 10; }
            while (third <= -9) { Roman += "IX"; third = third + 9; }
            while (third <= -5) { Roman += "V"; third = third + 5; }
            while (third <= -4) { Roman += "IV"; third = third + 4; }
            while (third <= -1) { Roman += "I"; third = third + 1; }
            return Roman;
        }
        #endregion
        #region count
        public void Count()
        {
            if (countM == 3) { M4 = First; countM = 0; }
            else if (countM == 2) { M3 = First; countM = 3; }
            else if (countM == 1) { M2 = First; countM = 2; }
            else { M1 = First; countM = 1; }
            return;
        }
        public void Count2()
        {
            if (countM2 == 3) { M8 = Second; countM2 = 0; }
            else if (countM2 == 2) { M7 = Second; countM2 = 3; }
            else if (countM2 == 1) { M6 = Second; countM2 = 2; }
            else { M5 = Second; countM2 = 1; }
            return;
        }
        #endregion
    }
}
