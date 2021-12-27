//  создали пустой массив 
Random random = new Random();
const int N = 10;
int[] vector = new int[N];
 
Console.WriteLine("Исходный массив");
 // заполнили массив 
for (int i = 0; i < N; i++)
    vector[i] = random.Next(1, 99);
 
Console.WriteLine(string.Join(" ", vector.Select(x =>x.ToString())));
 
int[] evenArr = vector.Where(x => x%2==0).ToArray();

Console.WriteLine("\n" + string.Join(" ", evenArr.Select(x => x.ToString())));
Console.ReadLine();