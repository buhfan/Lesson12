namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан массив из цифр. Дозаполнить массив так, чтобы переходы между цифрами были плавные, и вывести его (массив).
            //2 5 0
            //2* 3 4 5* 4 3 2 1 0*
            
            Random random = new Random();

            int N = random.Next(2, 5);

            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                int M = random.Next(10, 40);
                arr[i] = M;
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            int count = 0;
            for (int j = 0; j < N - 1; j++)
            {
                if (arr[j] != arr[j + 1])
                {
                    count += Math.Abs(arr[j] - arr[j + 1]) - 1;
                }
            }
            count += N;
            Console.WriteLine(count);
            Console.WriteLine();

            int[] newArr = new int[count];


            int c = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff2 = Math.Abs(arr[i] - arr[i + 1]) - 1;
                if (arr[i] == arr[i + 1])
                {
                    newArr[c] = arr[i];
                    c++;
                }
                else
                {
                    for (int j = 0; j <= diff2; j++)
                    {

                        if (arr[i] < arr[i + 1])
                        {
                            newArr[c] = arr[i] + j;
                        }
                        else if (arr[i] > arr[i + 1])
                        {
                            newArr[c] = arr[i] - j;
                        }
                        else
                        {
                            newArr[c] = arr[i];
                        }

                        c++;
                    }


                }
                newArr[c] = arr[arr.Length - 1];
            }

            c = 0;
            for (int j = 0; j < newArr.Length; j++)
            {                
                if (newArr[j] == arr[c])
                {
                    Console.Write($"{newArr[j]}* ");
                    c++;
                }
                else
                    Console.Write($"{newArr[j]} ");

            }

            //1. Дана строка. Исключить из нее все символы, кроме букв и пробелов.
                //Мама мыла раму. она была очень занята?! времени на нас не хватало. => Мама мыла раму она была очень занята времени на нас не хватало
            //2. Дана строка текстом с пробелами и точками. Сделать, чтобы после точек шла большая буква:
                //Мама мыла раму. она была очень занята. времени на нас не хватало. => Мама мыла раму. Она была очень занята. Времени на нас не хватало.

        }
    }
}