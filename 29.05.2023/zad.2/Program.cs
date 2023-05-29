//Masivi 
int[] arr = new int[5]; //inicializirane na masiv

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter element[{i}]=");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("------ foreach ------");

foreach (int number in arr)
{
    Console.WriteLine(number);
}

Console.WriteLine("------ for ------");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($" arr[{i}] = {arr[i]}");
}
