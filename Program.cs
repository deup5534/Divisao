
//sistema de divisão quase funcionando
int divisao1, divisao2, divisaoResultado;

Console.Write("Você vai dividir?:");
divisao1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Com quantos?:");
divisao2 = Convert.ToInt32(Console.ReadLine());

divisaoResultado =  divisao1 / divisao2;

Console.Write($"Resultado:{divisaoResultado}\n");

if(divisao1 == 0)
{
    Console.WriteLine("com 0 não dá né gênio!");
}
if(divisao2 == 0)
{
    Console.WriteLine("com 0 não dá né gênio!");
}
