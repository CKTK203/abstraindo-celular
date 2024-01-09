using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("84219", "G60", "517543772443680", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("98324", "Iphone 15", "493311803390546", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
