var one = "Naharis";
var two = "Mormont";
var three = "Sand";
// BEGIN (write your solution here)
Console.WriteLine($"{one[2]} {two[1]} {three[3]} {two[4]} {two[2]}");
// END



// Задача №2
// Выведите на экран первую и последнюю буквы предложения, записанного в переменную text.
var text = "Never forget what you are, for surely the world will not";
// BEGIN (write your solution here)
var lastIndex = text.Length - 1;
Console.WriteLine($"First: {text[0]}");
Console.WriteLine($"Last: {text[lastIndex]}");
// END


var email = " SupporT@hexlet.io\n";

// BEGIN (write your solution here)
var newEmail = email.Trim().ToLower();
Console.WriteLine(newEmail);