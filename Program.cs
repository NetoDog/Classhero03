// See https://aka.ms/new-console-template for more information

int?[] numeros = new int? [8];
int par = 0, impar = 0;

Console.WriteLine("Escreva os numero:");

for(int i = 0;i<8;i++)
numeros[i] = int.Parse(Console.ReadLine());

for (int i = 0; i < 8; i++)
{
    if (numeros[i] % 2 == 0)
        par++;
    else
        impar++;
}
Console.WriteLine($"\nQuantidade de pares: {par} \nQuantidade de impares: {impar}");
