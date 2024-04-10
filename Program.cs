using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone;
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "C3", imei: "739205684123097", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "8 plus", imei: "862409157305824", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");