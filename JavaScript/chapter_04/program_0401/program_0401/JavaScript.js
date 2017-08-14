// This program gets three test scores and displays 
// their average. It congratulates the user if the 
// average is a high score.

// Global constant for a high score
HIGH_SCORE = 95;

function main() {
    // Get the three test scores.
    var test1 = parseInt(prompt("Enter the score for test 1: "));
    var test2 = parseInt(prompt("Enter the score for test 2: "));
    var test3 = parseInt(prompt("Enter the score for test 3: "));

    // Calculate the average test score.
    var average = (test1 + test2 + test3) / 3;

    // Print the average.
    console.log("The average score is ", average.toFixed(2));

    // If the average is a high score,
    // congratulate the user.
    if (average >= HIGH_SCORE) {
        console.log("Congratulations!");
        console.log("That is a great average!");
    }
}

// Call the main function
main();