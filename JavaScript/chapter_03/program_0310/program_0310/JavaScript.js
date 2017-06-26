// This program demonstrates what happens when you 
// change the value of a parameter.

function main() {
    var value = 99;
    console.log('The value is ', value);
    change_me(value);
    console.log('Back in main the value is ', value);
}

change_me = (arg) => {
    console.log('I am changing the value.');
    arg = 0;
    console.log('Now the value is', arg)
}

// Call the main function.
main();