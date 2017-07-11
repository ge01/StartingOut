var CONSTANT = 0.6214;

function main() {
    // Display the intro screen.
    intro();

    // Get the distance in kilometers.
    var kilometers;
    kilometers = parseFloat(prompt("Enter the distance in kilometers: "));

    // Convert the kilometers to miles.
    kilometers_to_miles(kilometers);
}

// The intro function displays an introductory screen.
function intro() {
    console.log('This program converts distance to miles.');
    console.log('');
}

// The kilometers_to_miles function accepts a number in 
// kilometers and displays the equivalent number in miles.
let kilometers_to_miles = (kilos) => {
    miles = kilos * CONSTANT;
    console.log('That converts to '
                 + miles.toFixed(2));
}

// Call the main function
main();