// Get the desired future value.
var futureValue = parseFloat(prompt('Enter the desired future value: '));

// Get the annual interest rate
var rate = parseFloat(prompt('Enter the annual interest rate: '));

// Get the number of years that the money will appreciate.
var years = parseInt(prompt('Enter the number of years the money will grow'));

// Calculate the amount needed to deposit.
var presentValue = futureValue / Math.pow((1.0 + rate),years);

// Display the amount needed to deposit
console.log('You will need to deposit this amount:',presentValue);
