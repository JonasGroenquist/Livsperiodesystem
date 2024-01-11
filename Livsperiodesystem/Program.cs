// See https://aka.ms/new-console-template for more information
using Livsperiodesystem;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
Aktivitet a1 = new Aktivitet(1, 8, 13);
Console.WriteLine(a1.ToString());
Aktivitetskatalog c1 = new Aktivitetskatalog("Frisbee golf", "Skoven");
c1.AddAktivitet(a1);
Aktivitet a2 = new Aktivitet(2, 15, 13);
try
{
    c1.AddAktivitet(a2);
}
catch (ArgumentException aex)
{
    Console.WriteLine($"{aex.Message}");
}
HoldAktivitet ha1 = new HoldAktivitet("1", 3, 13, 18);
Console.WriteLine(ha1.ToString());
c1.AddAktivitet(ha1);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(c1.ToString());
//Aktivitet ad = c1.DeleteAktivitet(3);
//if  (ad == null)
//{
//    Console.WriteLine("intet er slettet");
//}
//else
//{
//    Console.WriteLine($"objektet {ad} \ner slettet");

//}
c1.DeleteAktivitet(3);
Console.WriteLine("new line");
AktivitetsKAtalogDic dic1 = new AktivitetsKAtalogDic("Fodbold", "I hallen");
dic1.AddAktivitet(a1);
dic1.AddAktivitet(ha1);
Console.WriteLine(dic1.ToString());