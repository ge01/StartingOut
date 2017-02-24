// Event listener that fires when a user clicks a button.
document.getElementById("myBtn").addEventListener("click", function(){
  computeName();
});
// Variables
var firstName;        // Holds the user entered first name
var lastName;         // Holds the user entered last name

function computeName() {
  // Get the first name
  firstName = document.getElementById('firstName').value;
  // Get the last name
  lastName = document.getElementById('lastName').value;

  // Print a greeting to the user.
  document.getElementById('outFirstName').innerHTML = firstName;
  document.getElementById('outLastName').innerHTML = lastName;
}
