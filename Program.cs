using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero: "1234-5678", modelo: "Nokia 3310", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DioAppNokia");


Console.WriteLine("\n\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone (numero: "8765-4321", modelo: "Apple Iphone 13", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DioAppIphone");

