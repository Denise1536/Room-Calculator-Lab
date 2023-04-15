//room calculator lab

Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
//enter length of room
Console.WriteLine("Enter the length of the room:");
string length;
length = Console.ReadLine();
double parselength = double.Parse(length);

//enter width of room

Console.WriteLine("Enter the width of the room:");
string width = Console.ReadLine();
double parsewidth = double.Parse(width);

//display area & perimeter 
double area = parselength * parsewidth;
//perimiter is calculated this way for rectangles:
double perimiter = (parselength * 2) + (parsewidth * 2);

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimiter: {perimiter}");

//classify the room as small/medium/large  
if (area <= 250)
{
    Console.WriteLine("This is a small room.");
}

else if (area <= 650)
{
    Console.WriteLine("This is a medium room.");
}

else
{
    Console.WriteLine("This is a large room.");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");

Console.ReadKey();

/*Extra challenge: calculate the volume

Console.WriteLine("Enter the height of the room:");
string height = Console.ReadLine();
double parseheight = double.Parse(height);
double volume = parsewidth * parselength * parseheight;
Console.WriteLine($"Volume: {volume}");
*/

/*extra challenge: surface area (I wrote this so it could function without the code in the volume code above. 
  If that code was present, then I would not need the first three lines of this.)
Console.WriteLine("Enter the height of the room:");
string height = Console.ReadLine();
double parseheight = double.Parse(height);
double surfaceArea = (parsewidth*parselength)*2 + (parsewidth*parseheight)*2 + (parseheight*parselength)*2;
Console.WriteLine($"Surface Area: {surfaceArea}");
*/

