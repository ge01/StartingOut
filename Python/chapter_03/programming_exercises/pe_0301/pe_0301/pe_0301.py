#########################################################
#                 Kilometer Converter                   #
# This program asks the user to enter a distance in     #
# kilometers, and then converts that distance to miles. #
# The conversion formula is as follows:                 #
# Miles = Kilometers * 0.6214                           #
#########################################################

CONSTANT = 0.6214

def main():
    # Display the intro screen.
    intro()

    # Get the distance in kilometers.
    kilometers = float(input('Enter the distance in kilometers: '))
    
    # Convert the kilometers to miles.
    kilometers_to_miles(kilometers)

# The intro function displays an introductory screen.
def intro():
    print('This program converts distance to miles.')
    print('')

# The kilometers_to_miles function accepts a number in 
# kilometers and displays the equivalent number in miles.
def kilometers_to_miles(kilos):
    miles = kilos * CONSTANT
    print('That converts to', \
           format(miles, '.2f'), \
          'miles. \n')
    
# Call the main function
main()