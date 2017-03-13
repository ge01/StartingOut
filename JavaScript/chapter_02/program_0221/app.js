// This program demonstrates how a floating-point
// number can be displayed as currency.
var monthlyPay = 5000.0;
var annualPay = monthlyPay * 12;
console.log("Your annual pay is $" +
              annualPay.toLocaleString(
                'en-US', {minimumFractionDigits: 2}
              )
            );

// Displays Your annual pay is $60,000.00
