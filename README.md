# Calorie Buddy
### Summary
This API was create for a personal training company that wanted to add the functionality of easily accessing meals, estimating calorie counts, and finding BMR based on `gener, height, weight, activity level, goal, and activity frequency`. The client requested a database with high quality meals that would be prompted to users based on caloric needs according to the API.

### roadmap
- Return list of macro splits based on recommended calories/day
- Create DB with custom meals and calorie counts for each macro.
- Barcode scanning
- Ability for users to add meals to database after verification
- Deploy to web using Azure
# Endpoints
## /FindBMR (Get)
This endpoint calculates BMR of user by taking in an object of a BMRModel which is shown below. This will then calculate and return the users BMR, meant to be used for the endpoint of `/CaloriesNeededDaily`.
- Age
 - Height (inches)
- Weight (pounds)
- Gender This will then calculate and return the users BMR, meant to be used for the endpoint of `/CaloriesNeededDaily`
## /CaloriesNeededDaily (Post)
This endpoint calculates how many calories the user needs based on an object of activity level and BMR, the activity level object is as follows below. This will then return a calorie goal to the user that they should try to hit everyday. This will eventually return meals for the user to eat that match macros/calories per day.
- Gender
-   Activity Level
    -   1 = Light Activity (cleaning, office work, golf, baseball)
    -   2 = Moderate Activity (Gardening, cycling @ 5.5mph, dancing, basketball, walking briskly)
    -   3 = Strenuous (jogging, football, swimming)
    -   4 = Very Strenuous (skiing, running)
-   Activity Frequency
    -   1 = 1-2 days
    -   2 = 2-4 days
    -   3 = 5-7 days
-   Weight Goal
    -   Gain
    -   Lose
    -   Maintain

## Used By

This project is used by the following companies:

-   MP Personal Training

### Acknowledgements

-   [What is BMR?](https://www.active.com/fitness/calculators/bmr)
-   [Burn Rate Calculator](https://www.urmc.rochester.edu/encyclopedia/content.aspx?ContentTypeID=41&ContentID=CalorieBurnCalc&CalorieBurnCalc_Parameters=160)
### Support

For support, email [bradystohler15@gmail.com](mailto:bradystohler15@gmail.com)
