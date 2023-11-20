
//Necessary imports and namespaces to run this application

using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;
/*This class encapsulates a user within the ATM system, containing the these attributes
a string for storing the username, a string for storing the password,
a string for storing the email address, a string for storing the phone number,
and an integer for storing the age. It possesses a constructor named ATM_User, 
which accepts arguments to set these properties with the provided values during initialization. */

public class ATM_User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public ATM_User(string username, string password, string email, string phone, int age)
    {
        Username = username;
        Password = password;
        Email = email;
        Phone = phone;
        Age = age;
    }

    class Prgram
    {
        /*The Main method serves as the starting point of the app, with a perpetual loop 
         (while (true)) responsible for presenting a menu and managing user interactions. 
         Within this loop, it showcases a welcoming message along with choices for Sign Up, Login, and Quit.
         Based on the user's selection, it invokes the corresponding function (SignUp(), Login(), or Quit()) */
        static List<ATM_User> users = new List<ATM_User>();   //List to save new users from signing in method
        static void Main()
        {
            while (true)
            {
                string user;
                Console.WriteLine("************************************************************");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("**                 Welcome to ABC Bank                    **");  // Welcome screen
                Console.WriteLine("**                                                        **");
                Console.WriteLine("**        If you would like to Sign Up, Enter: 1          **");
                Console.WriteLine("**         If you would like to Login, Enter: 2           **");
                Console.WriteLine("**         If you would like to Quit, Enter: 3            **");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("************************************************************");
                try
                {
                    user = Console.ReadLine();
                    int input = Int32.Parse(user);
                    switch (input)                            //To startup a method based on input in main console
                    {
                        case 1:
                            SignUp();                         // To call SignUp method
                            break;
                        case 2:
                            Login();                          //// To call Login method
                            break;
                        case 3:
                            Quit();                         // To call Quit method
                            return;                          // This will exit the program
                        default:
                            Console.WriteLine("************************************************************");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("**                 Welcome to ABC Bank                    **");  // Error handeling in case of invalid input 
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("**         Please enter a number between 1 to 3           **");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("************************************************************");
                            continue;

                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("**                 Welcome to ABC Bank                    **");  // Error handeling in case of invalid input using try ad catch method
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("**         Please enter a number between 1 to 3           **");
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("************************************************************");
                    continue;
                }


            }
        }
        /*  SignUp function manages the procedure for registering a new user.
         It initiates by requesting the user to input their username, email, age, mobile number, and password, and conducts validation checks on each entry.
         Utilizing loops, it addresses any invalid inputs, ensuring the user provides accurate information. 
         Upon confirming the validity of all inputs, a new ATM_User instance is generated and included in the list of users.
         Following a successful sign-up, the user is prompted to proceed with the login process.*/
        static void SignUp()
        {
            //Signing up for a new account
            string new_Username;
            string new_Email;     //new decleared variables 
            int new_Age;
            string new_Mobile;
            string new_Password;
            //Using a while loop for error for Username
            while (true)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("**                 Welcome to ABC Bank                    **");   //To get details of new user
                Console.WriteLine("**                                                        **");   //To get Username of the user
                Console.WriteLine("**                 Enter Your Username:                   **");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("************************************************************");
                new_Username = Console.ReadLine();
                //Using if and else statement with Regular Expression to vertify the user have enter their username
                if (Regex.IsMatch(new_Username, "^([a-zA-Z]).{2,}$"))
                {
                    //Using a while loop for error for Email
                    while (true)
                    {
                        Console.WriteLine("************************************************************");
                        Console.WriteLine("**                                                        **");
                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                        Console.WriteLine("**                                                        **");  //To get Email of the user
                        Console.WriteLine("**                  Enter Your Email:                     **");
                        Console.WriteLine("**                                                        **");
                        Console.WriteLine("************************************************************");
                        new_Email = Console.ReadLine();
                        //Using if and else statement with Regular Expression to vertify the user have enter their email
                        if (Regex.IsMatch(new_Email, "^([a-zA-Z]).{2,}$"))
                        {
                            //Using a while loop for error for Age
                            while (true)
                            {
                                //Using try and catch for ensure the user enter a integer/number
                                try
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                 Welcome to ABC Bank                    **");  //To get age of the user
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                   Enter Your Age:                      **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("************************************************************");
                                    new_Age = Int32.Parse(Console.ReadLine());
                                    //Using break to get exit out of the while loop
                                    break;
                                }
                                //Using catch for error: System.FormatException, if the user enter a spring, it will catch the error
                                catch (System.FormatException)
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                    Console.WriteLine("**                                                        **");  //Error handeling for invalid age
                                    Console.WriteLine("**                     Invaild Age                        **");
                                    Console.WriteLine("**       (PLease enter your age in numbers format)        **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("************************************************************");
                                    //Using continue for the user to put their correct age as it was invaild
                                    continue;
                                }
                            }
                            //Using a while loop for error for Mobile Number
                            while (true)
                            {
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("**                                                        **");
                                Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                Console.WriteLine("**                                                        **");  //To get Mobile Number of the user
                                Console.WriteLine("**              Enter Your Mobile Number:                 **");
                                Console.WriteLine("**                                                        **");
                                Console.WriteLine("************************************************************");
                                new_Mobile = Console.ReadLine();
                                //Using if and else statement with Regular Expression to vertify the user have enter a integer/number
                                if (Regex.IsMatch(new_Mobile, "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$"))
                                {
                                    //Using a while loop for error for Password
                                    while (true)
                                    {
                                        Console.WriteLine("************************************************************");
                                        Console.WriteLine("**                                                        **");
                                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                        Console.WriteLine("**                                                        **");
                                        Console.WriteLine("**                 Enter Your Password:                   **");
                                        Console.WriteLine("**       (Password can only contain alphanumeric,         **");
                                        Console.WriteLine("**         mix of numbers and special character)          **");
                                        Console.WriteLine("**                                                        **");
                                        Console.WriteLine("************************************************************");
                                        new_Password = Console.ReadLine();
                                        //Using if and else statement with Regular Expression to vertify the user have enter their password correctly and securely to invest their acccount getting hack 
                                        if (Regex.IsMatch(new_Password, "^([a-zA-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
                                        {
                                            //Puuting all of the user's detail into the class, using objects for username, passsword, email, mobile number and age 
                                            ATM_User user2 = new ATM_User(new_Username, new_Password, new_Email, new_Mobile, new_Age);
                                            Console.WriteLine("************************************************************");
                                            Console.WriteLine("**                                                        **");
                                            Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                            Console.WriteLine("**                                                        **"); //Printing the Successfully made a Account screen
                                            Console.WriteLine("**                You have Successfully                   **");
                                            Console.WriteLine("**             Made a Account with ABC Bank               **");
                                            Console.WriteLine("**                                                        **");
                                            Console.WriteLine("************************************************************");
                                            //Using a while loop for incorrect input of username
                                            while (true)
                                            {
                                                Console.WriteLine("************************************************************");
                                                Console.WriteLine("**                                                        **");
                                                Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                                Console.WriteLine("**                                                        **");   //Logining into a current account for username
                                                Console.WriteLine("**                 Enter Your Username:                   **");
                                                Console.WriteLine("**                                                        **");
                                                Console.WriteLine("************************************************************");
                                                //Using a foreach statement for incorrect input of username for 3 times
                                                foreach (int value in Enumerable.Range(1, 3))
                                                {
                                                    //Using a if statement for correct input of username, continue to enter password
                                                    if (Console.ReadLine() == user2.Username)
                                                    {
                                                        //Using a while loop for incorrect input of password
                                                        while (true)
                                                        {
                                                            Console.WriteLine("************************************************************");
                                                            Console.WriteLine("**                                                        **");
                                                            Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                                            Console.WriteLine("**                                                        **");     //Logining into a current account for password
                                                            Console.WriteLine("**                 Enter Your Password:                   **");
                                                            Console.WriteLine("**                                                        **");
                                                            Console.WriteLine("************************************************************");
                                                            //Using a foreach statement for incorrect input of password for 3 times
                                                            foreach (int value1 in Enumerable.Range(1, 3))
                                                            {
                                                                //Using a if statement for correct input of username, continue to the Welcome screen
                                                                if (Console.ReadLine() == user2.Password)
                                                                {
                                                                    string input3;
                                                                    Console.WriteLine("************************************************************");
                                                                    Console.WriteLine("**                                                        **");
                                                                    Console.WriteLine("**                    Welcome " + user2.Username + "                     **");
                                                                    Console.WriteLine("**              You have Successfully Login               **");
                                                                    Console.WriteLine("**                                                        **");
                                                                    Console.WriteLine("**   If you would like to check your Balance, Enter: 1    **");   //Welcome screen after the user have login sucessfully and 
                                                                    Console.WriteLine("**        If you would like to Deposit, Enter: 2          **");   //added options for the functions to be added in next assessment
                                                                    Console.WriteLine("**        If you would like to Transfer, Enter: 3         **");
                                                                    Console.WriteLine("**        If you would like to Log Out, Enter: 4          **");
                                                                    Console.WriteLine("**                                                        **");
                                                                    Console.WriteLine("************************************************************");
                                                                    // Creating a new user object with collected information
                                                                    ATM_User newUser = new ATM_User(new_Username, new_Password, new_Email, new_Mobile, new_Age);
                                                                    users.Add(newUser);  // Saving the data of new user in the list decleared at the start
                                                                    input3 = Console.ReadLine();
                                                                    if (input3 == "4")    //To exit this method and return to main screen after choosing to log out
                                                                    {
                                                                        //Using a return method to return the main screen/main static of the program
                                                                        return;
                                                                    }
                                                                    //Using a else statement to if want to access any other features
                                                                    else
                                                                    {
                                                                        Console.WriteLine("************************************************************");
                                                                        Console.WriteLine("**                                                        **");
                                                                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                                                        Console.WriteLine("**                                                        **");  //This screen inform the user that these features 
                                                                        Console.WriteLine("**          Sorry, but you will need to wait              **");  //aren't avaiable yet
                                                                        Console.WriteLine("**                to uses these features                  **");
                                                                        Console.WriteLine("**                                                        **");
                                                                        Console.WriteLine("************************************************************");
                                                                        //Using a return method to return the main screen/main static of the program
                                                                        return;
                                                                    }
                                                                }
                                                                //Using a else statement to tell the user that the password have be entered incorrectly
                                                                else
                                                                {
                                                                    Console.WriteLine("************************************************************");
                                                                    Console.WriteLine("**                                                        **");
                                                                    Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                                                    Console.WriteLine("**                                                        **");  //Invaild Password screen
                                                                    Console.WriteLine("**                  Invaild Password                      **");
                                                                    Console.WriteLine("**                                                        **");
                                                                    Console.WriteLine("************************************************************");
                                                                    //Using the break statement to exit the loop
                                                                    break;
                                                                }
                                                            }
                                                            //Using the continue statement for the user to try again to enter the password correctly (This only get use 3 times)
                                                            continue;
                                                        }
                                                    }
                                                    //Using else statement for invaild username
                                                    else
                                                    {
                                                        Console.WriteLine("************************************************************");
                                                        Console.WriteLine("**                                                        **");
                                                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                                        Console.WriteLine("**                                                        **"); //Invaild Email screen
                                                        Console.WriteLine("**         Username is't founded in the System            **");
                                                        Console.WriteLine("**                                                        **");
                                                        Console.WriteLine("************************************************************");
                                                        //Using the continue statement for the user to try again to enter the username correctly (This only get use 3 times)
                                                        continue;
                                                    }
                                                }
                                                //Using a return method to return the main screen/main static of the program (for more then 3 incorrect input of the username)
                                                return;
                                            }
                                        }
                                        //Using else statement for invaild password
                                        else
                                        {
                                            Console.WriteLine("************************************************************");
                                            Console.WriteLine("**                                                        **");
                                            Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                            Console.WriteLine("**                                                        **");
                                            Console.WriteLine("**                  Invaild Password                      **");  //Invaild Password screen and informing the user that the password can 
                                            Console.WriteLine("**       (password can only contain alphanumeric,         **");  //only contain alphanumeric, mix of numbers and special character
                                            Console.WriteLine("**         mix of numbers and special character)          **");
                                            Console.WriteLine("**                                                        **");
                                            Console.WriteLine("************************************************************");
                                            //Using the continue statement for the user to try again to enter their password correctly 
                                            continue;
                                        }
                                    }
                                }
                                //Using else statement for invaild mobile number
                                else
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                 Welcome to ABC Bank                    **");       //Displayed screen when entered mobile number is invalid
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                  Invaild Mobile Number                 **");
                                    Console.WriteLine("**   (Mobile Number can only contain an mix of numbers)   **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("************************************************************");
                                    //Using the continue statement for the user to try again to enter their Mobile Number correctly 
                                    continue;
                                }
                            }

                        }
                        //Using else statement for invaild email
                        else
                        {
                            Console.WriteLine("************************************************************");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("**                 Welcome to ABC Bank                    **");   //Displayed screen when entered email is invalid
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("**                    Invaild Email                       **");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("************************************************************");
                            //Using the continue statement for the user to try again to enter their email correctly 
                            continue;
                        }
                    }
                }
                //Using else statement for invaild username
                else
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("**                 Welcome to ABC Bank                    **");   //Displayed screen when entered username is invalid
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("**                  Invaild Username                      **");
                    Console.WriteLine("**                                                        **");
                    Console.WriteLine("************************************************************");
                    //Using the continue statement for the user to try again to enter their username correctly 
                    continue;
                }
            }
        }
        /*The login method is responsible for managing the user login process. Initially, it prompts the user to enter their username. 
         If the provided username is located within the list of users, the method proceeds to request the corresponding password.
         Upon entering the password, if it matches the stored password for that user, the system presents a welcoming message along with various
         options for subsequent actions such as checking balance, making a deposit, initiating a transfer, or logging out. 
         In the event that either the username or password is incorrect, the method offers appropriate feedback to the user. */
        static void Login()
        {
            //Using a while loop for incorrect input of username
            while (true)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("**                 Welcome to ABC Bank                    **");
                Console.WriteLine("**                                                        **");   //To get details for current user for username
                Console.WriteLine("**                 Enter Your Username:                   **");
                Console.WriteLine("**                                                        **");
                Console.WriteLine("************************************************************");
                //Using a foreach statement for incorrect input of username for 3 times
                foreach (int value in Enumerable.Range(1, 3))
                {
                    string inputUsername = Console.ReadLine();
                    //Vitrifying if the user have enter the correct username
                    ATM_User foundUser = users.FirstOrDefault(user => user.Username == inputUsername);
                    //Using a if statement for correct input of username
                    if (foundUser != null)
                    {
                        //Using a while loop for incorrect input of password
                        while (true)
                        {
                            Console.WriteLine("************************************************************");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("**                 Welcome to ABC Bank                    **");
                            Console.WriteLine("**                                                        **");  //To get details for current user for password
                            Console.WriteLine("**                 Enter Your Password:                   **");
                            Console.WriteLine("**                                                        **");
                            Console.WriteLine("************************************************************");
                            //Using a foreach statement for incorrect input of password for 3 times
                            foreach (int value1 in Enumerable.Range(1, 3))
                            {
                                string inputPassword = Console.ReadLine();
                                //Using a if statement for correct input of password
                                if (inputPassword == foundUser.Password)
                                {
                                    string input3;
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                    Welcome " + foundUser.Username + "                     **");
                                    Console.WriteLine("**              You have Successfully Login               **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**   If you would like to check your Balance, Enter: 1    **");  //Welcome screen after the user have login sucessfully and 
                                    Console.WriteLine("**        If you would like to Deposit, Enter: 2          **");  //added options for the functions to be added in next assessment
                                    Console.WriteLine("**        If you would like to Transfer, Enter: 3         **");
                                    Console.WriteLine("**        If you would like to Log Out, Enter: 4          **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("************************************************************");
                                    input3 = Console.ReadLine();
                                    if (input3 == "4")    //To exit this method and return to main screen after choosing to log out
                                    {
                                        //Using a return method to return the main screen/main static of the program
                                        return;
                                    }
                                    //Using a else statement to if want to access any other features
                                    else
                                    {
                                        Console.WriteLine("************************************************************");
                                        Console.WriteLine("**                                                        **");
                                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                        Console.WriteLine("**                                                        **");  //This screen inform the user that these features 
                                        Console.WriteLine("**          Sorry, but you will need to wait              **");  //aren't avaiable yet
                                        Console.WriteLine("**                to uses these features                  **");
                                        Console.WriteLine("**                                                        **");
                                        Console.WriteLine("************************************************************");
                                        //Using a return method to return the main screen/main static of the program
                                        return;
                                    }
                                }
                                //Using a else statement to tell the user that the password have be entered incorrectly 
                                else
                                {
                                    Console.WriteLine("************************************************************");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("**                 Welcome to ABC Bank                    **");
                                    Console.WriteLine("**                                                        **");  //Invaild Password screen
                                    Console.WriteLine("**                  Invalid Password                      **");
                                    Console.WriteLine("**                                                        **");
                                    Console.WriteLine("************************************************************");
                                    //Using the continue statement for the user to try again to enter the password correctly (This only get use 3 times)
                                    continue;
                                }
                            }
                            //Using a return method to return the main screen/main static of the program (for more then 3 incorrect input of the password)
                            return;
                        }
                    }
                    //Using a else statement to tell the user that the email have be entered incorrectly 
                    else
                    {
                        Console.WriteLine("************************************************************");
                        Console.WriteLine("**                                                        **");
                        Console.WriteLine("**                 Welcome to ABC Bank                    **");
                        Console.WriteLine("**                                                        **");  //Displayed screen when entered email is invalid
                        Console.WriteLine("**          Username isn't found in the System            **");
                        Console.WriteLine("**                                                        **");
                        Console.WriteLine("************************************************************");
                        //Using the continue statement for the user to try again to enter their username correctly (This only get use 3 times)
                        continue;
                    }
                }
                //Using a return method to return the main screen/main static of the program (for more then 3 incorrect input of the email)
                return;
            }
        }
        //This method simply displays a thank you message and ends the program.
        static void Quit()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("**                                                        **");
            Console.WriteLine("**                 Welcome to ABC Bank                    **");
            Console.WriteLine("**                                                        **");
            Console.WriteLine("**                 Thank you and Have a                   **"); //Displayed screen for went the user quit the program 
            Console.WriteLine("**                      Nice Day!                         **");
            Console.WriteLine("**                                                        **");
            Console.WriteLine("************************************************************");
            Console.ReadLine();//need to press enter to exit
            Environment.Exit(0);//command to exit the program 
        }
    }
}

