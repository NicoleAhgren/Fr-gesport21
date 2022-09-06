using System;
string F1;
string F2;
string F3;

Console.WriteLine("Quiz om NTI");
Console.WriteLine(" ");
Console.WriteLine("Fråga 1: Vilket år öppnades det första NTI-Gymnasiet?");
Console.WriteLine("1. 1999, 2. 2002, 3. 2005");
Console.WriteLine("Svara gärna med 1, 2 eller 3");
F1 = Console.ReadLine();

if (F1 == "2") {
    Console.WriteLine("Bra jobbat det var rätt svar");
}
else {
    Console.WriteLine("Det var tyvärr fel:( Rätt svar är svar nummer 2");
}

Console.WriteLine(" ");
Console.WriteLine("Fråga 2: Hur många NTI-Skolor finns det i svergie?");
Console.WriteLine("1. 19st, 2. 24st, 3. 29st");
F2 = Console.ReadLine("");