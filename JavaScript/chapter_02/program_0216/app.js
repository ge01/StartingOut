// Get three test scores and assign them to the
// test1, test2, test3 varialbes.
var test1 = parseFloat(prompt("Enter the first test score: "));
var test2 = parseFloat(prompt("Enter the second test score: "));
var test3 = parseFloat(prompt("Enter the third test score: "));

// Calculate the average of the three scores
// and assign the result to the average variable.
var average = (test1 + test2 + test3) / 3.0;

// Display the average.
console.log('The average score is', average.toLocaleString('en-US', {minimumFractionDigits: 2}));
