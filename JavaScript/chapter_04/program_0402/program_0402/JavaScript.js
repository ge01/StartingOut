// Global constants
BASE_HOURS = 40;    // Base hours per week
OT_MULTIPLIER = 1.5 // Overtime multiplier

// The main function gets the number of hours worked and
// the hourly pay rate. It calls either the calc_pay_with_OT
// function on the calc_reqular_pay function to calculate 
// and display the gross pay.
function main() {
    // Get the hours worked and the hourly pay rate.
    var hours_worked = parseFloat(prompt("Enter the number of hours worked: "));
    var pay_rate = parseFloat(prompt("Enter the hourly pay rate: "));

    // Calculate and display the gross pay.
    if (hours_worked > BASE_HOURS)
        calc_pay_with_OT(hours_worked, pay_rate);
    else
        calc_regular_pay(hours_worked, pay_rate);
}

// The calc_pay_with_OT function calculates pay with
// overtime. It accepts the hours worked and the hourly 
// pay rate as arguments. The gross pay is displayed.
function calc_pay_with_OT(hours, rate) {
    // Calculate the number of overtime hours worked.
    var overtime_hours = hours - BASE_HOURS;

    // Calculate the amount of overtime pay.
    var overtime_pay = overtime_hours * rate * OT_MULTIPLIER;

    var gross_pay = BASE_HOURS * rate + overtime_pay;

    // Display the gross pay.
    console.log("The gross pay is $" +
        gross_pay.toLocaleString(
            'en-US', { minimumFractionDigits: 2 }
        )
    ); 
}

// The calc_regular_pay function calculates pay with 
// no overtime. It accepts the hours worked and the hourly 
// pay rate as arguments. The gross pay is displayed.
var calc_regular_pay = (hours, rate) => {
    // Calculate the gross pay.
    var gross_pay = hours * rate;

    console.log("The gross pay is $" +
        gross_pay.toLocaleString(
            'en-US', { minimumFractionDigits: 2 }
        )
    ); 
}

// Call the main function
main();