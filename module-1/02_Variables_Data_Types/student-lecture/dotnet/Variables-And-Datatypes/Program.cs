using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises = 36;           
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
            string myName = "Jack";
            Console.WriteLine(myName);

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfButtons = 5;
            Console.WriteLine(numberOfButtons);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            int phoneBatteryPercent = 50;
            Console.WriteLine(phoneBatteryPercent.ToString() + "%");
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int difference = 121 - 27;
            Console.WriteLine(difference);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double addition = 12.3 + 32.1;
            Console.WriteLine(addition);

            /*
            12. Create a string that holds your full name.
            */
            string myFullName = "Jack Egan";
            Console.WriteLine(myFullName);

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string concatenatedName = "Hello, " + myFullName;
            Console.WriteLine(concatenatedName);

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            concatenatedName = concatenatedName + " Esquire";
            Console.WriteLine(concatenatedName);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            concatenatedName += " Esquire";
            Console.WriteLine(concatenatedName);

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string holdSaw = "Saw";
            holdSaw += "2";
            Console.WriteLine(holdSaw);

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            holdSaw += "0";
            Console.WriteLine(holdSaw);

            /*
            18. What is 4.4 divided by 2.2?
            */
            double division = 4.4 / 2.2;
            Console.WriteLine(division);

            /*
            19. What is 5.4 divided by 2?
            */
            division = 5.4 / 2.0;
            Console.WriteLine(division);

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            int newDivision = (int)5 / 2;
            Console.WriteLine(newDivision);

            /*
            21. What is 5.0 divided by 2?
            */
            division = 5.0 / 2;
            Console.WriteLine(division);

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double bankBalance = 1234.56;
            Console.WriteLine(bankBalance.ToString("C"));

            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;
            Console.WriteLine(remainder);

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int smallVariable = 3;
            int largeVariable = 1000000000;
            Console.WriteLine(smallVariable * largeVariable);
            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            Console.WriteLine(doneWithExercises);

            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;
            Console.WriteLine(doneWithExercises);

            Console.ReadLine();
        }
    }
}
