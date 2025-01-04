# Lumi Application 🖥️

A simple console application with multiple features designed for learning and practicing C# fundamentals. 

### *NOTE* 
*My English is not advanced, so I used artificial intelligence for translations. I prepared each section of the project separately and later faced challenges while merging them. To overcome these difficulties, I studied the topic with my friends and also sought additional support from artificial intelligence.*

# About Lumi 🌟
The application is named "Lumi" because it is the name I love using the most. It adds a personal and unique touch to the project, making it special to me.

## Features 🏁

**1. Random Number Guessing Game**
- Guess a random number between 1 and 100 in 5 attempts.
- Receive hints if your guess is too high or too low.

**2. Simple Calculator** ➕➖✖️➗
- Perform basic mathematical operations: addition, subtraction, multiplication, and division.
- Handles division by zero with an appropriate error message.

**3. Letter Grade Average Calculator** 🎓
- Enter three grades to calculate the average.
Displays both the numeric average and the corresponding letter grade.
- Validates inputs to ensure they are between 0 and 100.

## Project Goals 🎯

-  Learn and practice basic C# concepts:
    - Conditional statements
    - Loops
    - Methods
    - Input validation
    - Create a user-friendly console application. 

## **Usage** 🎮
### *Main Menu*
- Choose an option from the menu by entering the corresponding number (1, 2, 3, or 4).

- Follow the on-screen instructions for each feature.

### *Error Handling*

- Invalid inputs are handled with error messages and prompts to re-enter values.

### *Navigation*

- After completing any feature, you can return to the main menu or exit the application.

## Example Output 

```bash 
Lumi Application
---------------------------

Choose a feature:
1. Random Number Guessing Game
2. Simple Calculator
3. Letter Grade Average Calculator
4. Exit
Enter your choice: 1

Lumi: I'm thinking of a number between 1 and 100. You have 5 attempts. Good luck!
Attempt 1: Enter your guess (1-100): 50
You should have guessed a larger number.
...
Congratulations! You guessed it on your 3rd attempt.

1. Return to Main Menu
2. Exit
Enter your choice: 1

Choose a feature:
1. Random Number Guessing Game
2. Simple Calculator
3. Letter Grade Average Calculator
4. Exit
Enter your choice: 2

Enter the first number: 23
Enter the second number: 23
Choose an operation (+, -, *, /): *
Result: 23 * 23 = 529

1. Return to Main Menu
2. Exit
Enter your choice: 1

Choose a feature:
1. Random Number Guessing Game
2. Simple Calculator
3. Letter Grade Average Calculator
4. Exit
Enter your choice: 3

Lumi: Letter Grade Average Calculator
-----------------------------------------
Enter 1st grade (0-100): 99
Enter 2nd grade (0-100): 89
Enter 3rd grade (0-100): 98
Average: 95.3 Letter Grade: AA

1. Return to Main Menu
2. Exit
Enter your choice: 2
Thank you for using Lumi Application. Goodbye!
```