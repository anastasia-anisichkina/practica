// sozdali pustoi massiv 
Random random = new Random();
const int N = 15;
int[] vector = new int[N];
// zapolnili massiv
Console.WriteLine("Исходный массив");
 
for (int i = 0; i < N; i++)
    vector[i] = random.Next(1, 15);
// проверяем числа больше 8 

Console.WriteLine(string.Join(" ", vector.Select(x =>x.ToString())));
int[] evenArr = vector.Where(x => x > 8).ToArray();
// выводим полученый массив 
Console.WriteLine("\n" + string.Join(" ", evenArr.Select(x => x.ToString())));
Console.ReadLine();