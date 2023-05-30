try
{
    Console.WriteLine("Digite um numero!");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro numero!");
    int b = int.Parse(Console.ReadLine());
    int result = a / b;
    Console.WriteLine("O resultado é:"+result);
}
catch(Exception ex)
{
    Console.WriteLine("Algo de errado não está certo!");
}