using System.Net.NetworkInformation;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia nokia2660 = new Nokia("11-5559-895", "Celular Nokia 2660", "1111111111", 34);

nokia2660.InstalarAplicativo("WhatsApp");
nokia2660.ReceberLigacao();
nokia2660.Ligar();


Iphone iphone12 = new Iphone("54-1459-895", "Iphone 12 PRO ", "656988421", 15);
iphone12.InstalarAplicativo("WhatsApp");
iphone12.Ligar();
iphone12.ReceberLigacao();