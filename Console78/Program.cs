int[] array = new int[4];
Random rnd = new Random();

//создаем массив из случайных чисел от 16 до 30
array[0] = rnd.Next(16,30);
array[1] = rnd.Next(16,30);
array[2] = rnd.Next(16,30);
array[3] = rnd.Next(16,30);

foreach (int a in array)
    Console.WriteLine(a);

Console.ReadLine();