using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia");
Nokia celularNokia = new Nokia(numero:"1234", modelo:"Z-Flip90", imei:"123456789", memoria:"128");
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("Twitter");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Iphone celularIphone = new Iphone(numero: "9876", modelo:"14ProMax", imei:"4326578984", memoria:"64");
celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Whatsapp");