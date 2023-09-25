int salarioBruto, valorHora, horasTrabalhadas, salarioLiquido, ir,  descontos;

Console.WriteLine("Digite o valor da hora trabalhada: ");
valorHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

salarioBruto = valorHora * horasTrabalhadas;

if (salarioBruto > 900 && < 1501)
{
    descontos = (int)(salarioBruto * 0.05);
    salarioLiquido = salarioBruto - descontos;
    ir = 5;
}
else
{
    if(salarioBruto <= 2500)
    {
        descontos = (int)(salarioBruto * 0.10);
        salarioLiquido = salarioBruto - descontos;
        ir = 10;
    }
   
    if(salarioBruto >2500)
    {
        descontos = (int)(salarioBruto * 0.20);
        salarioLiquido = salarioBruto - descontos;
        ir = 20;
    }
    
}

Console.WriteLine("Salário bruto (" + valorHora + "x" + horasTrabalhadas ")");
Console.WriteLine("IR")