// This program gets an item's original price and
// calculates its sale price, with a 20% discount

// Get the item's original price.
var originalPrice = parseFloat(prompt("Enter the item's original price: "));

// Calculate the amount of the discount
var discount = originalPrice * 0.2;

// Calculate the sale price
var salePrice = originalPrice - discount;

// Display the sale price.
console.log('The sale price is', salePrice);
