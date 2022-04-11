
# Calorie Buddy

This API was created for my girlfriend's website, she is a personal trainer and wanted functionallity for her clients to be able to easily access meals or an estimated calorie count based on their gender, height, weight, and activity levels.

## Roadmap
- Return list of macro splits based on recommended calories/day
- Create DB with custom meals and calorie counts for each macro.
- Barcode scanning
- Ability for users to add meals to database after verification
- Deploy to web using Azure

# Documentation

## Endpoints

#### Current Endpoints
- ### /findBMR
    - This endpoint calculates BMR of user by taking in an object of a BMRModel which is shown below. This will then calculate and return the users BMR, meant to be used for the endpoint of '/CaloriesNeededDaily'.
        - Age
        - Height (inches)
        - Weight (pounds)
        - Gender
        This will then calculate and return the users BMR, meant to be used for the endpoint of '/CaloriesNeededDaily'.
- ### /CaloriesNeededDaily
    - this endpoint calculates how many calories the user needs based on an object of activity level and BMR, the activity level object is as follows below.         This will then return a calorie goal to the user that they should try to hit everyday. This will eventually return meals for the user to eat that match macros/calories per day.
        - Gender
        - Activity Level
            - 1 = Light Activity (cleaning, office work, golf, baseball)
            - 2 = Moderate Activity (Gardening, cycling @ 5.5mph, dancing, basketball, walking briskly)
            - 3 = Strenuous (jogging, football, swimming)
            - 4 = Very Strenuous (skiing, running)
        - Activity Frequency
            - 1 = 1-2 days
            - 2 = 2-4 days
            - 3 = 5-7 days
        - Weight Goal
            - Gain
            - Lose
            - Maintain

# Used By

This project is used by the following companies:

- MP Personal Training


## Acknowledgements

 - [What is BMR?](https://www.active.com/fitness/calculators/bmr)
 - [Burn Rate Calculator](https://www.urmc.rochester.edu/encyclopedia/content.aspx?ContentTypeID=41&ContentID=CalorieBurnCalc&CalorieBurnCalc_Parameters=160)



## Support

For support, email bradystohler15@gmail.com

