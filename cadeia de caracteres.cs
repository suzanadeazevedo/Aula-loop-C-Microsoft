int a = 3;
int b = 6;

if (a + b > 10)
{
    Console.WriteLine("A resposta é maior que 10.");
}

else
{
    Console.WriteLine("O resultado é menor que 10.");
}

// simbolo || significa OU//
int a = 5;
int b = 5;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("A resposta é maior que 10.");
    Console.WriteLine("E o primeiro numero é igual ao segundo");
}


int contar = 0;
while (contar <= 10)
{
    Console.WriteLine($"Olá mundo! a conta é {contar}");
    contar++;
}

else
{
    Console.WriteLine("O resultado é menor que 10.");
    Console.WriteLine(" Ou o primeiro numero não é igual ao segundo");
}
