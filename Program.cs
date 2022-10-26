using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "101010", modelo: "Iphone teste", imei: "12345", memoria: 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("------------------------------------------------");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "101010", modelo: "Nokia teste", imei: "7410", memoria: 64);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
