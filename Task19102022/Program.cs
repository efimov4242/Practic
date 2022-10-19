// Задача №1
var one = "Naharis";
var two = "Mormont";
var three = "Sand";
Console.WriteLine($"{one[2]} {two[1]} {three[3]} {two[4]} {two[2]}");




// Задача №2
// Выведите на экран первую и последнюю буквы предложения, записанного в переменную text.
var text = "Never forget what you are, for surely the world will not";
var lastIndex = text.Length - 1;
Console.WriteLine($"First: {text[0]}");
Console.WriteLine($"Last: {text[lastIndex]}");




// Задача №3
// Удалите лишние пробелы и приведите к нижнему регистру.
var email = " SupporT@hexlet.io\n";
Console.WriteLine(email.Trim().ToLower());



// Задача №4
// Напишите код, который берет данные из переменной name и выполняет капитализацию, в программировании так называют операцию, которая делает заглавной первую букву в слове, а все остальные переводит в нижний регистр. Например: heXlet => Hexlet.
var name = "hexlet";
var capitalized = name.Substring(0, 1).ToUpper()
    + name.Substring(1).ToLower();
Console.WriteLine(capitalized);


// Задача №5
// найти в документации к языку нужный метод, которым можно вставить одну строку в другую. Результат должен получится таким: War of the Five Kings
var war = "War of the Kings";
var missingWord = "Five ";
var kingWordIndex = war.IndexOf('K');
Console.WriteLine(war.Insert(kingWordIndex, missingWord));



// Задача №6
// В переменной emoji находится текстовый грустный смайлик -(. Ваша задача сделать этот смайлик веселый с помощью двух преобразований:
// Добавить слева глаза :
// Заменить ( на )
// Должно получиться: :-). Выведите его на экран.
var emoji = "-(";
var happyEmoji = ":" + emoji.Replace('(', ')');
Console.WriteLine(happyEmoji);
