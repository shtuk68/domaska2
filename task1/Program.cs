
//Задача ноиер 10
Console.WriteLine("введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100 * 100;
int n2 = n % 10 ;
int n3 = n - n1 - n2 ;
Console.WriteLine($"вот второе число:   {n3 / 10}");






