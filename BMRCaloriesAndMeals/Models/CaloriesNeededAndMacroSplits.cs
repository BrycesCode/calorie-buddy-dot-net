namespace BMRCaloriesAndMeals.Models
{
    public class CaloriesNeededAndMacroSplits
    {
        public double TotalCalories { get; set; }
        public double GramsOfCarbs { get; set; }
        public double GramsOfFat { get; set; }
        public double GramsOfProtein { get; set; }
        public MacroSplitModel MacroSplit { get; set; }
    }
}
