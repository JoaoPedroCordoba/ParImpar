int  n;

Console.WriteLine("Digite um numero:");
n = Convert.ToInt32(Console.ReadLine());

bool par = (n % 2 ) == 0;

if  (par)
{ 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{n} é um numero par");
} 

else{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{n} é um numero impar");
}
Console.ResetColor();