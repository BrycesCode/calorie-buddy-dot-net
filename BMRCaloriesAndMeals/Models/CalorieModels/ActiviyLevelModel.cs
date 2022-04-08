namespace BMRCaloriesAndMeals.Models.CalorieModels
{
    public class ActiviyLevelModel
    {
        public string Gender { get; set; }
        /// <summary>
        /// ALL VALUES BASED OFF 1 HOUR
        /// 1 - Light Activity (cleaning, office work, golf, baseball)
        /// 2 - moderate (gardening, cyclying 5.5mph, dancing, basketball, walking briskly)
        /// 3 - strenuous (jogging, football, swimming)
        /// 4 - very strenuous (skiing, running)
        /// </summary>
        public int ActivityLevel { get; set; }

        /// <summary>
        /// 1=1-2 days
        /// 2=2-4 days
        /// 3 = 5-7days
        /// </summary>
        public int ActivityFrequency { get; set; }

        /// <summary>
        /// gain
        /// lose
        /// maintain
        /// </summary>
        public string WeightGoal { get; set; }
    }
}
