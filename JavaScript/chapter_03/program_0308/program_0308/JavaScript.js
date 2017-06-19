// This program demonstrates a function that accepts
// two arguments.

var main = () => {
    console.log('The sum of 12 and 45 is')
    show_sum(12, 45)
}

// The show_sum function accepts two arguments
// and displays their sum.
var show_sum = (num1, num2) => {
    result = num1 + num2;
    console.log(result);
}

// Call the main function
main();


/*  Guide for using arrow functions
let addOne = function (value) {
    return value + 1;
}

let addOne = (value) => {
    return value + 1;
}
*/