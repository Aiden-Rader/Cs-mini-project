namespace BodyStatsCalculator
{
    class BodyCalcHelper
    {
        /// <summary>
        /// Calculates a set of body statistics including BMI, BMI category, and estimated body fat percentage.
        /// </summary>
        /// <param name="weight_kg">The user's weight in kilograms</param>
        /// <param name="height_cm">The user's height in centimeters</param>
        /// <param name="age">The user's age in years</param>
        /// <param name="gender">The user's gender, either "Male" or "Female"</param>
        /// <returns>A string containing the calculated body statistics</returns>
        public static string CalculateBodyStats(double weight_kg, double height_cm, int age, string gender)
        {
            double bmi = CalculateBMI(weight_kg, height_cm);
            string category = GetBMICategory(bmi);
            double body_fat = EstimateBodyFatFromBMI(bmi, age, gender);

            return $"BMI: {bmi:F2} ({category})\nEstimated Body Fat %: {body_fat:F2}%";
        }

        /// <summary>
        /// Calculates a person's Body Mass Index (BMI) based on their weight (in kilograms) and height (in centimeters).
        /// </summary>
        /// <param name="weight_kg">The person's weight in kilograms</param>
        /// <param name="height_cm">The person's height in centimeters</param>
        /// <returns>The person's Body Mass Index (BMI)</returns>
        public static double CalculateBMI(double weight_kg, double height_cm)
        {
            if (height_cm <= 0 || weight_kg <= 0)
            {
                return 0.0;
            }

            double height_m = height_cm / 100.0;
            return weight_kg / (height_m * height_m);
        }

        /// <summary>
        /// Returns a string indicating the BMI category for a given Body Mass Index (BMI).
        /// </summary>
        /// <param name="bmi">The Body Mass Index (BMI)</param>
        /// <returns>A string indicating the BMI category, one of "Underweight", "Normal", "Overweight", or "Obese"</returns>
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

        /// <summary>
        /// Estimates the body fat percentage of a person based on their age and body mass index (BMI).
        /// </summary>
        /// <param name="bmi">The person's body mass index (BMI)</param>
        /// <param name="age">The person's age in years</param>
        /// <param name="gender">The person's gender, either "Male" or "Female"</param>
        /// <returns>The estimated body fat percentage of the person</returns>
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
