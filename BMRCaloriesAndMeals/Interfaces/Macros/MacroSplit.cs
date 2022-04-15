using BMRCaloriesAndMeals.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace BMRCaloriesAndMeals.Interfaces.Macros
{
    public class MacroSplit : IMacroSplit
    {
        private readonly IConfiguration _configuration;

        public MacroSplit(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MacroSplitModel GetMacroSplits(double calories, string goal)
        {
            MacroSplitModel macroSplit = new MacroSplitModel();

            if (goal == "gain")
            {
                macroSplit = new MacroSplitModel()
                {
                    protein = _configuration.GetValue<double>("MacroSplits:weight-gain:protein"),
                    carbs = _configuration.GetValue<double>("MacroSplits:weight-gain:carbs"),
                    fat = _configuration.GetValue<double>("MacroSplits:weight-gain:fat")
                };
                macroSplit.protein = calories * macroSplit.protein;
                macroSplit.carbs = calories * macroSplit.carbs;
                macroSplit.fat = calories * macroSplit.fat;
            }else if(goal == "lose")
            {
                macroSplit = new MacroSplitModel()
                {
                    protein = _configuration.GetValue<double>("MacroSplits:weight-loss:protein"),
                    carbs = _configuration.GetValue<double>("MacroSplits:weight-loss:carbs"),
                    fat = _configuration.GetValue<double>("MacroSplits:weight-loss:fat")
                };
                macroSplit.protein = calories * macroSplit.protein;
                macroSplit.carbs = calories * macroSplit.carbs;
                macroSplit.fat = calories * macroSplit.fat;
            }
            else
            {
                macroSplit = new MacroSplitModel()
                {
                    protein = _configuration.GetValue<double>("MacroSplits:maitanence:protein"),
                    carbs = _configuration.GetValue<double>("MacroSplits:maitanence:carbs"),
                    fat = _configuration.GetValue<double>("MacroSplits:maitanence:fat")
                };
                macroSplit.protein = calories * macroSplit.protein;
                macroSplit.carbs = calories * macroSplit.carbs;
                macroSplit.fat = calories * macroSplit.fat;
            }


            return macroSplit;
            //if (goal == "gain")
            //{
            //    var intakePercentage = JsonConvert.DeserializeObject<MacroSplitModel>(_configuration.GetSection("MacrSplits").GetSection("weight-gain"));
            //    macroSplit
            //}

        }
    }
}
