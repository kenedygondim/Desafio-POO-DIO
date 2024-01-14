using DesafioPOO.Models;


Nokia nokia01 = new("11 965803584", "Lumia Xperia 13", "21568641-45664", 64);
Console.WriteLine("Smarthphone Nokia registrado com sucesso.");
nokia01.Ligar();
nokia01.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------------------------------------------");

Iphone iphone01 = new("11 965804444", "Iphone 13", "41552658-48484", 128);
Console.WriteLine("Smarthphone Iphone registrado com sucesso.");
iphone01.ReceberLigacao();
iphone01.InstalarAplicativo("Siri");


 