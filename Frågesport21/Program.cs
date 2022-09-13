using System;       
            
    int points = 0;
    string Svar;
    Console.WriteLine("Vilket år öppnades det allra första NTI-Gymnasiet?");
    Console.WriteLine("1. 1999");
    Console.WriteLine("2. 2002");
    Console.WriteLine("3. 2005");
    Svar = Console.ReadLine();

    
    if (Svar == "2" || Svar == "2.") { 
        Console.WriteLine(" ");
        Console.WriteLine("Rätt svar! Du får 1 poäng");
        points++;
    }

    else 
    {
        Console.WriteLine(" ");        
        Console.WriteLine("Det var tyvärr fel svar:( Inget poäng till dig!");
    }
    

    Console.WriteLine(" ");
    string Svar2;
    Console.WriteLine("Hur många NTI-Gymnasium finns det i Sverige?");
    Console.WriteLine("1. 18st");
    Console.WriteLine("2. 25st");
    Console.WriteLine("3. 29st");
    Console.WriteLine(" ");
    Svar2 = Console.ReadLine();

    if (Svar2 == "3" || Svar == "3.")
    {
        Console.WriteLine(" ");
        Console.WriteLine("Rätt svar! Du får 1 poäng");
        points++;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Det var tyvärr fel svar:( Inget poäng till dig!");
    }

    string Svar3;
    Console.WriteLine(" ");
    Console.WriteLine("Vad står 'NTI' för?");
    Console.WriteLine("1. NaturTekinska Institutet");
    Console.WriteLine("2. Nordens Teknikerinstitut");
    Console.WriteLine("3. Nicoles Teknikinstitut");
    Console.WriteLine(" ");
    Svar3 = Console.ReadLine();

    if (Svar3 == "2" || Svar3 == "2.")
    {
        Console.WriteLine(" ");
        Console.WriteLine("Rätt svar! Du får 1 poäng");
        points++;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Det var tyvärr fel svar:( Inget poäng till dig!");
    }

    string SistaFrågan;
    Console.WriteLine(" ");
    Console.WriteLine("4. Hur många olika linjer finns det på NTI-Stockholm?");
    Console.WriteLine("1. 3 olika linjer");
    Console.WriteLine("2. 4 olika linjer");
    Console.WriteLine("3. 5 olika linjer");
    Console.WriteLine(" ");
    SistaFrågan = Console.ReadLine();

    if (SistaFrågan == "1" || SistaFrågan == "1.")
    {
        Console.WriteLine(" ");
        Console.WriteLine("Rätt svar! Du får 1 poäng");
        Console.WriteLine(" ");
        points++;
        Console.WriteLine($"{points}/4 poäng!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Det var tyvärr fel svar:( Inget poäng till dig!");
        Console.WriteLine(" ");
        Console.WriteLine($"Du fick {points}/4 poäng!");
        Console.WriteLine(" ");
        Console.ReadLine();
    }
    
