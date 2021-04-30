using System;

namespace Jones_James_CE09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * James M. Jones
             * 04/25/2021
             * DEV2000-O 02: Introduction to Development II
             * 3.6 Code Exercise 09: String Objects
             */

            bool keepMenuGoing = true;

            while (keepMenuGoing)
            {
                //Use a while loop to contain our menu options. I decided to use a for loop to loop through two string arrays and display the menu options.
                //This uses fewer lines of code and is easier to read. I can wrap this in a conditional statement as well.
                //It would also be easier to add more options to this menu in the future using this approach.
                string[] menuOptionNumbers = { "1", "2", "3" };

                string[] menuOptions = { "Run Credit Card Obscurer", "Run THE Search", "Exit The Program" };
                //If the arrays lengths are equal I can loop through their values with a single for loop.
                if (menuOptionNumbers.Length == menuOptions.Length)
                {
                    //use a for loop to loop through the array and display the menu option for each number in that array.
                    for (int i = 0; i < menuOptions.Length; i++)
                    {
                        //Output the menu option number and program titles.
                        Console.WriteLine("\r\n({0}) {1}", menuOptionNumbers[i], menuOptions[i]);
                    }
                }

                //Prompt the user to choose an option from the menu.
                Console.WriteLine("\r\nPlease type in the number of the command you want to run:");

                //listen for the user's input and capture the response.
                string menuChoice = Console.ReadLine();

                //Validate that the user can only select numbers: 1, 2 and 3.
                while (menuChoice != "1" && menuChoice != "2" && menuChoice != "3")
                {
                    //Tell the user the error.
                    Console.WriteLine("\r\nPlease only type in a valid choice. 1, 2 or 3.");

                    //Restate the question.
                    Console.WriteLine("\r\nPlease type in the number of the command you want to run:");

                    //Re-prompt the user.
                    menuChoice = Console.ReadLine();
                }

                //Use a conditional block to run the selected code.
                if (menuChoice == "1")
                {
                    //Function call for Credit Card Obscurer(MenuOption1)
                    MenuOption1();
                }
                else if (menuChoice == "2")
                {
                    MenuOption2();
                }
                else if (menuChoice == "3")
                {
                    //Exit the program.
                    //Exit the program.
                    Console.WriteLine("\r\nThank you for testing out my program!");
                    Console.WriteLine("Have a great day!");

                    //Change the bool variable to stop the loop.
                    keepMenuGoing = false;
                }

                //Clean up the terminal/console
                Console.WriteLine("\r\nPress ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        //Problem #1: Credit Card Obscurer

        //First, I need to create a menu option function for MenuOption1
        //This is for "Problem #1 Credit Card Obscurer"
        public static void MenuOption1()
        {
            //Next, I want to greet the user and explain a little bit about the program.
            Console.WriteLine("\r\nPlease enter your 12 to 16 digit card number:");

            //Listen for and capture the user's input. Do not forget to validate.
            string cardNumberInputString = Console.ReadLine();

            //Validation Loop - Be sure the user can only input numeric characters that are 12 to 16 characters long.
            while (string.IsNullOrWhiteSpace(cardNumberInputString) || cardNumberInputString.Length < 12 || cardNumberInputString.Length > 16)
            {
                //Tell the user the error
                Console.WriteLine("\r\nInvalid entry. Please enter a valid card number between 12 and 16 digits long:");

                //Restate the question/instructions
                Console.WriteLine("\r\nPlease enter your 12 and 16 digit card number:");

                //Re-prompt the user
                cardNumberInputString = Console.ReadLine();
            }

            //Function call Obscurer to
            string cardNumber= Obscurer(cardNumberInputString);

            Console.WriteLine("\r\n" + cardNumber);
            Console.WriteLine("You can now check out with your credit card ending in {0}.", cardNumber);
        }

        //Problem #2: THE Search

        //Next, I need to create a menu option function for MenuOption2
        //This is for "Problem #2: THE Search"
        public static void MenuOption2()
        {
            //Prompt the user for a sentence.
            Console.WriteLine("\r\nPlease enter your favorite sentence below:");

            //Listen for the user's input and validate that it is not left blank.
            string favoriteSentence = Console.ReadLine();

            //Validation loop
            while (string.IsNullOrWhiteSpace(favoriteSentence))
            {
                //Tell the user the error
                Console.WriteLine("\r\nNo input received. Please enter a valid sentence to continue:");

                //Re-state the question/instructions
                Console.WriteLine("\r\nPlease enter your favorite sentence below:");

                //Re-prompt the user
                favoriteSentence = Console.ReadLine();
            }

            //Create a string array to hold the favoriteSentence value.
            string[] favoriteSentenceArray = favoriteSentence.Split(" ");

            //foreach (string word in favoriteSentenceArray)
            //{
            //    Console.WriteLine(word);
            //}
            //Function Call Searcher() and store in a new variable for output.
            int theWordCounter = Searcher(favoriteSentenceArray);

            Console.WriteLine("Your sentence contains {0} word(s) and the word (the) appears {1} time(s).", favoriteSentenceArray.Length, theWordCounter);
        }

        //Next, I need to create a custom function called Obscurer.
        //This is for MenuOption1 - "Problem #1: Credit Card Obscurer"
        public static string Obscurer(string cardNumber)
        {
            //Create a character array to hold the 12 to 16 characters of the cardNumber
            char[] cardNumberArray = cardNumber.ToCharArray();

            //cardNumberArray[0] = 'X';
            //cardNumber = cardNumber.Replace(cardNumber[i], cardNumberArray[i]);
            //Convert the cardNumberArray index back to a string
            //string newCardNumber = new string(cardNumberArray);

            //Create a new variable to add an "X" for each time the loop cycles through the string indexes.
            string cardNumberX = "X";

            //Loop through the array using a for loop since we are changing information based on the string length.
            for (int i = 0; i < cardNumberArray.Length - 4; i++)
            {
                //Add an X each time the loop cycles.
                cardNumberX += "X";
            }
            //I decided to use a conditional to test if the card number length is 12 characters long.
            if (cardNumber.Length == 12)
            {//Adds the last four indexes of the card number if the card number length is 12 characters long.
                cardNumberX += cardNumber.Substring(8);
            //Also, test if the card number length is 13 characters long.
            }
            else if (cardNumber.Length == 13)
            {//Adds the last four indexes of the card number if the card number length is 13 characters long.
                cardNumberX += cardNumber.Substring(9);
            //Adds the last four indexes of the card number if the card number length is 14 characters long.
            }
            else if (cardNumber.Length == 14)
            {//Also, test if the card number length is 14 long.
                cardNumberX += cardNumber.Substring(10);
            }//Also, test if the card number is 15 characters long.
            else if (cardNumber.Length == 15)
            {//Adds the last four indexes of the card number if the card number length is 15 characters long.
                cardNumberX += cardNumber.Substring(11);
            }//Finally, test if the card number length is 16 characters long.
            else if (cardNumber.Length == 16)
            {//Adds the last four indexes of th ecard number if the card number length is 16 characters long.
                cardNumberX += cardNumber.Substring(12);
            }
            //Return the new string that we created above the for loop.
            return cardNumberX;
        }

        //Next, I need to create a custom function called Searcher.
        //This is for MenuOption2 - "Problem #2: THE Search"
        public static int Searcher(string[] sentence)
        {
            //I need a counter variable to store the words in.
            int wordTheCounter = 0;

            //I also need to store the word "The" in a string varaible
            string theKeyWord = "The";

            //I want to use a foreach loop to loop through the string array.
            foreach (string word in sentence)
            {//I can use a conditional to increase the noumber of times the words "The" shows up in our sentence.
                if (word.ToLower() == theKeyWord.ToLower()) {

                    wordTheCounter++;

                }
            }

            return wordTheCounter;
        }
    }
}
