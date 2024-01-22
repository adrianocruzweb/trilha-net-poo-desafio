using DesafioPOO.Models;
Console.WriteLine("\n");
Console.WriteLine("Nokia rodando");
Nokia nokia = new Nokia("67981894046", "3320", "352391980375742", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Minecraft");

Console.WriteLine("\n");

Console.WriteLine("Iphone Rodando");
Iphone iphone = new Iphone("67992158616", "Iphone XR", "356423109411037", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LastPass");