// See https://aka.ms/new-console-template for more information
float pg, pa, dif;

Console.WriteLine("Informe valor Gasolina: ");
pg = float.Parse(Console.ReadLine());
Console.WriteLine("Informe valor Álcool: ");
pa = float.Parse(Console.ReadLine());

dif = pa / pg;
if(dif >= 0.72){
    Console.WriteLine("Compensa gasolina!");
}
else
{
    Console.WriteLine("Compensa álcool!");
}
