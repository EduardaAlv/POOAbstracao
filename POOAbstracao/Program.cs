using POOAbstracao.Models;

Console.WriteLine("Testes no Android");

Android android = new Android("123456789", "ASUS", 8);
android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Rusty Lake");

Console.WriteLine("Testes no Iphone");
Console.ReadLine();

Iphone iphone = new Iphone("123456789", "10", 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Notion");
Console.ReadLine();