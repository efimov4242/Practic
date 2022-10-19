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



// Задача №3
// Удалите лишние пробелы и приведите к нижнему регистру.
var email = " SupporT@hexlet.io\n";

Console.WriteLine(email.Trim().ToLower());



// Задача №4
// Напишите код, который берет данные из переменной name и выполняет капитализацию, в программировании так называют операцию, которая делает заглавной первую букву в слове, а все остальные переводит в нижний регистр. Например: heXlet => Hexlet.
var name = "hexlet";
// BEGIN (write your solution here)
var capitalized = name.Substring(0, 1).ToUpper()
    + name.Substring(1).ToLower();
Console.WriteLine(capitalized);
// END


// Задача №5
// найти в документации к языку нужный метод, которым можно вставить одну строку в другую. Результат должен получится таким: War of the Five Kings

var war = "War of the Kings";
var missingWord = "Five ";

var kingWordIndex = war.IndexOf('K');
Console.WriteLine(war.Insert(kingWordIndex, missingWord));


var emoji = "-(";

// BEGIN (write your solution here)
emoji = emoji.Replace("(",")");
var eyes = ":";
System.Console.WriteLine(eyes + emoji);
// END
