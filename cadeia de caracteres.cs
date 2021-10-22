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


int contar = 0;
do
{
    Console.WriteLine($"Olá mundo! a conta é {contar}");
    contar++;
}
while (contar <= 10);



for (int counter = 0; counter <= 10; counter++)
{
    Console.WriteLine($"Ola mundo! A conta é {counter}");
}


//Gerar Linhas//
for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"A linha é {row}");
}

//Gerar colunas//
for (char column = '1'; column < '9'; column++)
{
    Console.WriteLine($"The column is {column}");
}

// Formar pares de loop//

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
//Aula//