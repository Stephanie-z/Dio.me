using DesafioPOO.Models;

Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia("12345", "Modelo 1", "123.123.123.9", 2);
nokia.Ligar();
nokia.InstalarAplicativo("Banana Kong");

Console.WriteLine("\n");

Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone("67890", "Modelo 2", "987.987.987.1", 4);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Banana Kong");
