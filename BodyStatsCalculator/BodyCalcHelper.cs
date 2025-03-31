namespace BodyStatsCalculator
{
    class BodyCalcHelper
    {
        public static string CalculateBodyStats(double weight_kg, double height_cm, int age, string gender)
        {
            double bmi = CalculateBMI(weight_kg, height_cm);
            string category = GetBMICategory(bmi);
            double body_fat = EstimateBodyFatFromBMI(bmi, age, gender);

            return $"BMI: {bmi:F2} ({category})\nEstimated Body Fat %: {body_fat:F2}%";
        }

        public static double CalculateBMI(double weight_kg, double height_cm)
        {
            if (height_cm <= 0 || weight_kg <= 0)
            {
                return 0.0;
            }

            double height_m = height_cm / 100.0;
            return weight_kg / (height_m * height_m);
        }

        public static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 24.9)
            {
                return "Normal";
            }
            else if (bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        private static double EstimateBodyFatFromBMI(double bmi, int age, string gender)
        {
            if (gender == "Male")
            {
                return (1.20 * bmi) + (0.23 * age) - 16.2;
            }
            else if (gender == "Female")
            {
                return (1.20 * bmi) + (0.23 * age) - 5.4;
            }

            return 0.0;
        }
    }
}
