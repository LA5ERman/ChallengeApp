﻿var name = "Ewa";
char sex = 'm';
var age = 30;

if (age < 30 && sex == 'k')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}

else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}