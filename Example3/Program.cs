/*Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.WriteLine("Введите элементы:");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] copy = new int[arr.Length];
for (int i = 0; i < arr.Length; i++){
    copy[i] = arr[i];
}

 Console.WriteLine(String.Join(", ", copy));