using BMRCaloriesAndMeals.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMRCaloriesAndMeals.Controllers
{
    public class BMRCalorieController : Controller
    {
        /// <summary>
        /// The endpoint below calculates the BMR (kcal/day) for user based on the Miffin-St Jeor equation
        /// </summary>
        /// <returns>
        /// Users BMR
        /// 10*weight+6.25*height-5*age+5 for men
        /// 10*weight+6.25*height-5*age-161 for men
        /// </returns>

        [HttpGet("/findBMR")]
        public ActionResult<string> ReturnBMR(BMRModel UserBMRModel)
        {
            double BMR;

            
            if (UserBMRModel.Gender.ToLower() == "male")
            {
                BMR = 10 * UserBMRModel.Weight + 6.25 * UserBMRModel.Height - 5 * UserBMRModel.Age + 5;
                return Ok(BMR.ToString());
            }
            else if(UserBMRModel.Gender.ToLower() == "female")
            {
                BMR = 10 * UserBMRModel.Weight + 6.25 * UserBMRModel.Height - 5 * UserBMRModel.Age - 161;
                return Ok(BMR.ToString());
            }
            else
            {
                return Ok("Please enter female or male");
            }
        }
    }
}
