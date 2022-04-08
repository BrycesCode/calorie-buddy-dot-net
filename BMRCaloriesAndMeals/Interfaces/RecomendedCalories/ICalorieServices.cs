using BMRCaloriesAndMeals.Models.CalorieModels;

namespace BMRCaloriesAndMeals.Interfaces.RecomendedCalories
{
    /// <summary>
    /// This interface returns recommended calories a person should eat based off user activity level & BMR
    /// 1-Light
    /// 2-Moderate
    /// 3-Strenuous
    /// 4-Very Strenuous
    /// The calories based on exercise are based off of: https://www.onhealth.com/content/1/
    /// </summary
    public interface ICalorieServices
    {
        public double CalculateCaloriesNeededDaily(ActiviyLevelModel activityLevel, double BMR);
    }
}
