using desafio_abstraindo_celular.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "981979797", modelo: "Modelo 1", imei: "9080809808", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "08109830198", modelo: "Modelo 1", imei: "0984081098", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Office");