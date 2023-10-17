using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");