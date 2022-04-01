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
        public ActionResult<string> ReturnBMR(string gender, double weight, int height, int age)
        {
            double BMR;

            if (gender.ToLower() == "male")
            {
                BMR = 10 * weight + 6.25 * height - 5 * age + 5;
                return Ok(BMR.ToString());
            }
            else if(gender.ToLower() == "female")
            {
                BMR = 10 * weight + 6.25 * height - 5 * age - 161;
                return Ok(BMR.ToString());
            }
            else
            {
                return Ok("Please enter female or male");
            }
        }
    }
}
