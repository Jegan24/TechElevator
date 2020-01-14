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
            //this is one line of comments
            /*
             * this is  
             * a 
             * multi
             * line
             * comment
             */
            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half = .5;
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
            Console.WriteLine("Seasons of firefly:"+seasonsOfFirefly);

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
            string yourName = "your name";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numMouseButtons = 3;

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            double percentPhoneBatterLeft = 99.0;

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int value1 = 121;
            int value2 = 27;
            int diff = value1 - value2;

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum = 12.3 + 32.1;

            /*
            12. Create a string that holds your full name.
            */
            string fullName = "Katie Dwyer";

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string hello = "Hello, ";
            string greeting = hello + fullName;

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            fullName = fullName + " Esquire";


            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            fullName += " Esquire";

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string scaryMovieName = "Saw " + 2;

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            scaryMovieName += "0";

            /*
            18. What is 4.4 divided by 2.2?
            */
            double divResult18 = 4.4 / 2.2;

            /*
            19. What is 5.4 divided by 2?
            */
            double divResult19 = 5.4 / 2;

            /*BONUS*/
            double testValue = (divResult18 + divResult19) / 3.2 * 5;
            bool isClassFun = true;


            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            int result = 5 / 2;
            Console.WriteLine("The resut of 5 /2 is " + result);

            /*
            21. What is 5.0 divided by 2?
            */
            double resultB = 5.0 / 2;
            Console.WriteLine("The resut of 5.0 / 2 is " + resultB);

            double resultC = 5 / 2;
            Console.WriteLine("The resut of 5 / 2  stored in a double is " + resultC);

            int five = 5; 
            double resultD = (double) five / 2;
            Console.WriteLine("The resut of (double) 5 / 2  is " + resultD);

            //int five = 5;
            double resultE = (double)(five / 2);
            Console.WriteLine("The resut of (double)(five / 2) is " + resultE);

            /*More bonus stuff*/
            double x = 5;
            int y = (int) x;

            x = y; //putting it in a bigger box - not losing data
            //y = x; // you have to cast this to explicitly confirm that you are a-ok with losing data

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double bankBalance = 1234.56;

            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int three = 3;
            long billion = 1000000000; 
            double  multiplicationResult = three * billion;
            Console.WriteLine("3 and 1,000,000,000 is " + multiplicationResult);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;

            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

            //practice some literals
            float f = (float) 3.0;
            float f2 = 3.0F;

            decimal d = (decimal) 3.0;
            decimal d2 = 3.0M;

            long l = 3; 
            Console.ReadLine();
        }
    }
}
