int numero1, numero2, numero3, menorNumero = 0, maiorNumero = 0;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToInt32(Console.ReadLine());


if (numero1 > numero2)
{
    if (numero1 > numero3)
    {
        maiorNumero = numero1;
    }
    else
    {
        maiorNumero = numero3;
    }


}

if (numero2 > numero3)
{
    if (numero2 > numero1)
    {
        maiorNumero = numero2;
    }
    else
    {
        maiorNumero = numero1;
    }


}

if (numero3 > numero2)
{
    if (numero3 > numero1)
    {
        maiorNumero = numero3;

    }
    else
    {
        maiorNumero = numero1;
    }


}

//a

if (numero1 < numero2)
{
    if (numero1 < numero3)
    {
        menorNumero = numero1;
    }
    else
    {
        menorNumero = numero3;
    }


}


if (numero2 < numero3)
{
    if (numero2 < numero1)
    {
        menorNumero = numero2;
    }
    else
    {
        menorNumero = numero1;
    }
}

if (numero3 < numero2)
{
    if (numero3 < numero1)
    {
        menorNumero = numero3;
    }
    else
    {
        menorNumero = numero1;
    }
}

Console.WriteLine("O maior número é: " + maiorNumero);
Console.WriteLine("O menor número é: " + menorNumero);