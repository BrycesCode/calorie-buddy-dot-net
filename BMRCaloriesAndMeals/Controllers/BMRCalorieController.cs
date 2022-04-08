using BMRCaloriesAndMeals.Interfaces.BMR;
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

        public BMRCalorieController(IBMRServices bmrServices, ICalorieServices calorieServices)
        {
            _bmrServices = bmrServices;
            _calorieServicers = calorieServices;
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
        public ActionResult<double> returnCaloriesNeededDaily([FromBody]ActiviyLevelModel activityLevel, double BMR)
        {
            var caloriesNeededDaily = _calorieServicers.CalculateCaloriesNeededDaily(activityLevel, BMR);
            return Ok(caloriesNeededDaily);
        }
    }
}
