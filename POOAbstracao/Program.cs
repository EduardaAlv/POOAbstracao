using POOAbstracao.Models;

Console.WriteLine("Testes no Android");

Android android = new Android();
android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Rusty Lake");

Console.WriteLine("Testes no Iphone");
Console.ReadLine();

Iphone iphone = new Iphone();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Notion");
Console.ReadLine();