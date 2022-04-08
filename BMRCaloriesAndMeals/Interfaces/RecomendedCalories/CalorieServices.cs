using BMRCaloriesAndMeals.Interfaces.BMR;
using BMRCaloriesAndMeals.Models.CalorieModels;

namespace BMRCaloriesAndMeals.Interfaces.RecomendedCalories
{
    public class CalorieServices : ICalorieServices
    {
        public double CalculateCaloriesNeededDaily(ActiviyLevelModel activityLevel, double BMR)
        {
            double caloriesBurnedWeekly = CalorieExtensions.ReturnCaloriesBurnedWeekly(activityLevel);
            var caloriesBurnedDaily = caloriesBurnedWeekly / 7;
            double caloriesNeededDaily;
            switch (activityLevel.WeightGoal.ToLower())
            {
                case "gain":
                    caloriesNeededDaily = caloriesBurnedDaily + BMR + 200; //plus 200 to make them in a caloric overload
                    return caloriesNeededDaily;
                case "lose":
                    caloriesNeededDaily = caloriesBurnedDaily + BMR - 200; //minus 200 to make them in a caloric deficit
                    return caloriesNeededDaily;
                case "maintain":
                    caloriesNeededDaily = caloriesBurnedDaily + BMR; //just want to eat how many calories your body burns to maintain
                    return caloriesNeededDaily;
                default:
                    return caloriesBurnedDaily;

            }
        }
    }
    







    public static class CalorieExtensions
    {
        public static double ReturnCaloriesBurnedWeekly(ActiviyLevelModel activityLevel)
        {
            double caloriesBurnedWeekly;
            if (activityLevel.Gender == "male")
            {
                caloriesBurnedWeekly = 0;
                switch (activityLevel.ActivityLevel)
                {
                    case 1:
                        caloriesBurnedWeekly = 300 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 2:
                        caloriesBurnedWeekly = 460 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 3:
                        caloriesBurnedWeekly = 730 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 4:
                        caloriesBurnedWeekly = 920 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    default:
                        return caloriesBurnedWeekly;

                }

            }
            else if (activityLevel.Gender == "female")
            {
                caloriesBurnedWeekly = 0;

                switch (activityLevel.ActivityLevel)
                {
                    case 1:
                        caloriesBurnedWeekly = 240 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 2:
                        caloriesBurnedWeekly = 370 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 3:
                        caloriesBurnedWeekly = 580 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    case 4:
                        caloriesBurnedWeekly = 740 * activityLevel.ActivityFrequency;
                        return caloriesBurnedWeekly;
                    default:
                        return caloriesBurnedWeekly;
                }
            }
            else
            {
                return 0;
            }
        }
    }


}
