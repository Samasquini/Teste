try
{
    Console.WriteLine("Digite um numero:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro numero:");
    int num2 = int.Parse(Console.ReadLine());
    int result = num1 / num2;
    Console.WriteLine("O resultado é:"+result);
}
catch(Exception ex)
{
    Console.WriteLine("Algo de errado não está certo!");
}