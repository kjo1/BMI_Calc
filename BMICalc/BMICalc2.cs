using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalc
{
    class BMICalc2
    {
        private double bmi;
        private string category;

        public BMICalc2(double height, double weight, Units u)
        {
            if (height < 0 || weight < 0)
            {
                throw new ArgumentOutOfRangeException("The value for height and weight cannot be negative.");
            }
            else
            {
                double bmi = weight / Math.Pow(height, 2);
                if (u == Units.Imperial)
                    bmi *= 703;
            }
        }

        public double BMI2
        {
            get { return Math.Round(bmi, 2); }
        }

        public string Category
        {
            get
            {
                if (String.IsNullOrEmpty(category))
                {
                    if (bmi < 15)
                    {
                        category = "Very severely underweight.";
                    }
                    else if (bmi <= 16)
                    {
                        category = " Severely underweight.";
                    }
                    else if (bmi <= 18.5)
                    {
                        category = " Underweight.";
                    }
                    else if (bmi <= 25)
                    {
                        category = " Normal.";
                    }
                    else if (bmi <= 30)
                    {
                        category = " Overweight.";
                    }
                    else if (bmi <= 35)
                    {
                        category = " Obese Class I (Moderately obese).";
                    }
                    else if (bmi <= 40)
                    {
                        category = " Obese Class II (Severely obese).";
                    }
                    else
                    {
                        category = " Obese Class III (Very severely obese).";
                    }                    
                }
                return category;
            }
        }
    }
}
