using BMRCaloriesAndMeals.Models;

namespace BMRCaloriesAndMeals.Interfaces.Macros
{
    public interface IMacroSplit
    {
        /// All info in service layer based on: https://www.cookinglight.com/eating-smart/macro-diet-counting-macros-weight-loss-better-nutrition#:~:text=If%20you're%20counting%20macros,%2C%2030%2D40%25%20fat.

        public MacroSplitModel GetMacroSplits(double calories, string goal);
    }
}
