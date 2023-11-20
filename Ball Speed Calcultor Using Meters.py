
# Initialize an empty dictionary to store User Input information.
ball_speed = {}
# Display the header using a function
def header():
    print("--------------------------------------\nHour\tDistance Travelled\n--------------------------------------")
try:
    # Start the main loop for the program.
    while True:
       # Prompt the user to input the speed of the ball (in meters per minute) and the total minutes it has traveled (between 1 and 20).
       speed = int(input("What is the speed of the ball (in meters per minute between 1 and 25)? "))
       # Prompt the user to only a number between 1 and 25, if the user enter a number more than 25.
       if speed>25:
           print("Enter a number betweeen 1 and 25")
           continue
       mins = int(input("How many minutes has it traveled (between 1 and 20)? "))
       # Prompt the user to only a number between 1 and 20, if the user enter a number more than 20.
       if mins>20:
           print("Enter a number betweeen 1 and 20")
           continue
       # Initialize a counter to keep track of the current hour.
       num = 0
       # Print a header for the table displaying our hourly progress using the function.
       header()
       # Iterate through each hour within the given time span.
       while num < mins:
          num = num + 1
          # Validate the speed and mins information into the dictionary.
          ball_speed[speed] = mins
          # Calculate the distance traveled for the current hour using a lambda function.
          distance = (lambda time, velocity: time * velocity)(num, speed)
          # Display the current hour and its corresponding distance traveled.
          print(str(num) + "\t" + "\t" + str(distance))
       # Print a line to separate the table from the rest of our output.
       print("--------------------------------------")
       # Prompt the user to input to run the program again or not
       program=input("Do you want to run the program again (Y/N)? ").upper()
       while program not in ['Y', 'N']:
           print("Please enter 'Y' or 'N'")
           program= input("Do you want to run the program again (Y/N)? ").upper()
       # Continue or break based on user input.
       if program == "Y": continue
       elif program == "N":
           print("Speed & Mins Details:\n-------------------------------\nSpeed\tMins\n-------------------------------")
           for speed, mins in ball_speed.items():
               print(str(speed) + "\t" + "\t" + str(mins))
           break
   # Handle the case where the user enters a non-integer value, and provide an appropriate error message.
except ValueError: print("You must enter a number")