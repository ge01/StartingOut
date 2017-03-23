// Definition of the main function.
function main() {
    getName()
    print('Hello', name)    // This causes an error!
}


// Definition to the getName function.
function getName() {
    name = input('Enter your name: ')
}
 
// Call the main function.
main()