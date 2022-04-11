
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
    - This endpoint calculates BMR of user by taking in an object of a BMRModel which is just an object of:
        - Age
        - Height (inches)
        - Weight (pounds)
        - Gender
        This will then calculate and return the users BMR, meant to be used for the endpoint of '/CaloriesNeededDaily'.
- ### /CaloriesNeededDaily
    - this endpoint calculates how many calories the user needs based on an object of activity level and BMR, the activity level object is as follows:
        - Gender
        - Activity level
            - 1 = 1-2 days
            - 2 = 2-4 days
            - 3 = 5-7 days
        - Weight Goal
            - Gain
            - Lose
            - Maintain
       This will then return a calorie goal to the user that they should try to hit everyday. This will eventually return meals for the user to eat that match macros/calories per day.
# Used By

This project is used by the following companies:

- MP Personal Training


## Acknowledgements

 - [What is BMR?](https://www.active.com/fitness/calculators/bmr)
 - [Burn Rate Calculator](https://www.urmc.rochester.edu/encyclopedia/content.aspx?ContentTypeID=41&ContentID=CalorieBurnCalc&CalorieBurnCalc_Parameters=160)



## Support

For support, email bradystohler15@gmail.com

