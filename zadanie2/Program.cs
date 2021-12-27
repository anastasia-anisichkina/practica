// sozdali pustoi massiv 
Random random = new Random();
const int N = 15;
int[] vector = new int[N];
// zapolnili massiv
Console.WriteLine("Исходный массив");
 
for (int i = 0; i < N; i++)
    vector[i] = random.Next(1, 15);
    