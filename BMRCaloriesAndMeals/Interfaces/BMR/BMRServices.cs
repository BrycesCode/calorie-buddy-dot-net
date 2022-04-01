using BMRCaloriesAndMeals.Models;

namespace BMRCaloriesAndMeals.Interfaces.BMR
{
    public class BMRServices : IBMRServices
    {
        public double CalculateBMR(BMRModel userBMRModel)
        {
            double BMR;

            if (userBMRModel.Gender.ToLower() == "male")
            {
                BMR = 10 * userBMRModel.Weight + 6.25 * userBMRModel.Height - 5 * userBMRModel.Age + 5;
                return BMR;
            }
            else if (userBMRModel.Gender.ToLower() == "female")
            {
                BMR = 10 * userBMRModel.Weight + 6.25 * userBMRModel.Age - 161;
                return BMR;
            }
            else
            {
                return 0;
            }
        }
    }
}
