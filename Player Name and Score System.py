#Importing RegEx package
import re
# Initialize an empty dictionary to store player information.
Player = {}
# Display the main menu with option using a function
def display():
    print("==================================================\n**Welcome to Champions Soccer Club **\nPlease choose an option from the followings.")
    print("1) Add player name and score\n2) Display all the player information and scores\n3) Quit.\n==================================================")
# Start the main loop for the soccer club program.
while True:
    # Using the function to display the main menu with options.
    display()
    try:
        # Get the user's choice from the main menu.
        choice = int(input("Enter your choice: "))
        # Option 1: Add player name and score
        if choice == 1:
            while True:
                # Get player name from the user.
                PlayerName = input("Enter the player name: ")
                #Using RegEx package for Input only to appect letters and not numbers or special characters
                if not re.match(r"^[A-Za-z]+$", PlayerName):
                        print("Please use only letters for the player name, try again")
                        continue
                else:
                    try:
                        # Get player score from the user.
                        Score = int(input("Enter the score between 0-100: "))
                        
                        # Validate the score and add player information.
                        if 0 <= Score <= 100:
                            Player[PlayerName] = Score
                            # Prompt the user to add another player or quit.
                            add_player = input("Do you want to add another player (Y/N)? ").upper()
                            while add_player not in ['Y', 'N']:
                                print("Please enter 'Y' or 'N'")
                                add_player = input("Do you want to add another player (Y/N)? ").upper()
                            # Continue or break based on user input.
                            if add_player == "Y": continue
                            elif add_player == "N": break
                        else: print("Score must be between 0 and 100, try again")
                    # Handle invalid input (if user input is less then 0 and more then 100)
                    except ValueError: print("Score must be a number between 0 and 100, try again")
            continue
        # Option 2: Display player information and scores
        elif choice == 2:
            print("Player & Score Details:\n-------------------------------\nPlayer\tScore")
            for PlayerName, Score in Player.items(): print(PlayerName + "\t" + str(Score))
        # Option 3: Quit the program
        elif choice == 3:
            print("**GoodBye.. See you again!**")
            break
        # Handle invalid menu choices
        else: print("You must enter a number between 1 and 3")
    # Handle invalid input (not a number)
    except ValueError:
        print("You must enter a number between 1 and 3")
        continue
