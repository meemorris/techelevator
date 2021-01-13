namespace Exercises
{
    public partial class Exercises
    {
        /*
         Dessert Island Diner believes a meal isn't a meal without dessert. All meals come with
         a free dessert.

         There are three categories of free desserts: "standard", "special", and "ginormous".
         The meal amount determines the dessert category: <= $10 (standard), <= $15 (special),
         > $15 (ginormous). Unless it is your birthday -- on that day, an additional $5 is added
         when calculating the category to potentially bump you up to the next delicious category.

         For instance, if the amount of the meal was $7, and it is your birthday, $5 is added to
         $7 when determining the dessert category, which means you would qualify for a "special".

         YourCakeAndEatItToo(4.99, false) → "standard"
         YourCakeAndEatItToo(4.99, true) → "standard"
         YourCakeAndEatItToo(7.00, false) → "standard"
         YourCakeAndEatItToo(7.00, true) → "special"
         YourCakeAndEatItToo(10.00, false) → "standard"
         YourCakeAndEatItToo(10.00, true) → "special"
         YourCakeAndEatItToo(11.00, false) → "special"
         */
        public string YourCakeAndEatItToo(double mealAmount, bool isBirthday)
        {
            return "";
        }
    }
}
