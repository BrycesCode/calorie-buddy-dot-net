using BMRCaloriesAndMeals.Models;

namespace BMRCaloriesAndMeals.Interfaces.BMR
{
    public interface IBMRServices
    {
        public double CalculateBMR(BMRModel userBMRModel);
    }
}
