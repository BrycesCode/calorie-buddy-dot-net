using BMRCaloriesAndMeals.Interfaces.BMR;
using BMRCaloriesAndMeals.Interfaces.Macros;
using BMRCaloriesAndMeals.Interfaces.RecomendedCalories;
using BMRCaloriesAndMeals.Models;
using BMRCaloriesAndMeals.Models.CalorieModels;
using Microsoft.AspNetCore.Mvc;

namespace BMRCaloriesAndMeals.Controllers
{
    public class BMRCalorieController : Controller
    {
        private readonly IBMRServices _bmrServices;
        private readonly ICalorieServices _calorieServicers;
        private readonly IMacroSplit _macroSplit;

        public BMRCalorieController(IBMRServices bmrServices, ICalorieServices calorieServices, IMacroSplit macroSplit)
        {
            _bmrServices = bmrServices;
            _calorieServicers = calorieServices;
            _macroSplit = macroSplit;
        }

        /// <summary>
        /// The endpoint below calculates the BMR (kcal/day) for user based on the Miffin-St Jeor equation
        /// </summary>
        /// <returns>
        /// Users BMR
        /// 10*weight+6.25*height-5*age+5 for men
        /// 10*weight+6.25*height-5*age-161 for men
        /// </returns>

        [HttpGet("/findBMR")]
        public ActionResult<string> ReturnBMR(BMRModel userBMRModel)
        {
            var bmr = _bmrServices.CalculateBMR(userBMRModel);
            var test = _macroSplit.GetMacroSplits(2500, "gain");
            if (bmr == 0)
            {
                return Ok("Please enter male/female for gender");
            }
            else
            {
                return Ok(bmr);
            }
        }

        /// <summary>
        /// returns calories needed daily based on weight goal (gain, lose, maintain)
        /// </summary>
        [HttpPost("/CaloriesNeededDaily")]
        public ActionResult<CaloriesNeededAndMacroSplits> returnCaloriesNeededDaily([FromBody]ActiviyLevelModel activityLevel, double BMR)
        {
            CaloriesNeededAndMacroSplits macrosNeededDaily = new CaloriesNeededAndMacroSplits();
            var caloriesNeededDaily = _calorieServicers.CalculateCaloriesNeededDaily(activityLevel, BMR);
            var macroSplit = _macroSplit.GetMacroSplits(caloriesNeededDaily, activityLevel.WeightGoal);
            macrosNeededDaily.TotalCalories = caloriesNeededDaily;
            macrosNeededDaily.MacroSplit=macroSplit;
            macrosNeededDaily.GramsOfProtein = macroSplit.protein / 4;
            macrosNeededDaily.GramsOfFat = macroSplit.fat / 9;
            macrosNeededDaily.GramsOfCarbs = macroSplit.carbs / 4;
            return Ok(macrosNeededDaily);
        }
    }
}
