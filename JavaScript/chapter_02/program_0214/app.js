// Assign a value to the salary variable.
var salary = 2500.0;

// Assign a value to the bonus varialbe.
var bonus = 1200.0;

// Calculate the total pay by adding salary
// and bounus. Assign the result to pay.
var pay = salary + bonus;

// Display the pay.
console.log('Your pay is', pay);
// Alternate way to display pay (as a string)
console.log('Your pay is ' + pay);
// "Output" the pay value inside an HTML paragraph with id="payId"
document.getElementById("payID").innerHTML = pay;
