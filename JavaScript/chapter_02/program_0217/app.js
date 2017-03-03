// Get a number of seconds from the user.
var totalSeconds = parseFloat(prompt("Enter a number of seconds: "));

// Get the number of hours.
var hours = parseInt(totalSeconds / 3600);

// Get the number of remaining minutes.
var minutes = parseInt(totalSeconds / 60) % 60;

// Get the number of remaining seconds.
var seconds = totalSeconds % 60;

// Display the average.
console.log('Here is the time in hours, minutes, and seconds:');
console.log('Hours:',hours);
console.log('Minutes:',minutes);
console.log('Seconds:',seconds);
