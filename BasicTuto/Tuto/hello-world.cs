/*
Run your first program
Declare and use variables
Work with strings


*/

Console.WriteLine("Hello, World!");
String aFriend = "Bill";
Console.WriteLine(aFriend );
aFriend = "Maira";
Console.WriteLine(aFriend );
Console.WriteLine("Hello, " + aFriend + "!");

Console.WriteLine($"Hello, {aFriend}!"); /*String interpolation*/

String firstFriend = "John";
String secondFriend = "Janette";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


String greeting = "         Hello World!          ";
Console.WriteLine($"[{greeting}]");

String trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

String sayHello = "Hello World!";

Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");

Console.WriteLine(sayHello);
