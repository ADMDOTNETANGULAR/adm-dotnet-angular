//Javscript conditional statements
// if statement
let age = 2;
if (age >= 18) {
    console.log("You are an adult.");
} else {
    console.log("You are a minor.");
}
// if-else statement
let score = 85;
if (score >= 90) {
    console.log("Grade: A");
} else if (score >= 80) {
    console.log("Grade: B");
} else if (score >= 70) {
    console.log("Grade: C");
} else {
    console.log("Grade: D");
}
// switch statement
let day = 13;
switch (day) {
    case 1:
        console.log("Monday");
        break;
    case 2:
        console.log("Tuesday");
        break;
    case 3:
        console.log("Wednesday");
        break;
    case 4:
        console.log("Thursday");
        break;
    case 5:
        console.log("Friday");
        break;
    case 6:
        console.log("Saturday");
        break;
    case 7:
        console.log("Sunday");
        break;
    default:
        console.log("Invalid day");
}
let ch = 'k';
switch (ch) {
    case 'a':
    case 'A':
    case 'e':
    case 'E':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'u':
        console.log("Vowel");
        break;
    default:
        console.log("Consonant");
        break;
}
// ternary operator
let isAdult = (age >= 18) ? "Adult" : "Minor"; // ternary operator
console.log(isAdult); // Output: Minor
// nested if statement
let temperature = 30;
if (temperature > 25) {
    console.log("It's warm outside.");
    if (temperature > 30) {
        console.log("It's hot outside.");
    } else {
        console.log("It's a pleasant day.");
    }
}
