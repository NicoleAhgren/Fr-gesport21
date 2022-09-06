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
F2 = Console.ReadLine();

if (F2 == "3") {
    Console.WriteLine("Amazing det var rätt svar:D");
}
else {
    Console.WriteLine("Det var fel:/ Rätt svar var 3");
}

Console.WriteLine(" ");
Console.WriteLine("Fråga 3: Vad står NTI för?");
Console.WriteLine("1. Nordens Teknikerinstitut, 2. Natur-tekniska institutet, 3. Natur och teknikinstitutet");
F3 = Console.ReadLine();

if (F3 == "1") {
    Console.WriteLine("Korrekt, bra jobbat!");
}
else {
    Console.WriteLine("Det var feeel:( Rätt svar var 1");
}

Console.WriteLine ("Tack för att du gjort min frågesport! Hoppas du lärde dig något nytt:)");