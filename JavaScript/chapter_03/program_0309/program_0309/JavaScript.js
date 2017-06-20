// This program demonstrates passing two string
// arguments to a function.

function main() {
   first_name = prompt('Enter your first name: ');
   last_name = prompt('Enter you last name: ');
   console.log('Your name reversed is ');
   reverse_name(first_name, last_name);
}

reverse_name = (first, last) => {
    console.log(last, first)
}

// Call the main function
main();