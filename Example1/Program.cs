/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.WriteLine("Введите элементы:");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetPositiveNumber (int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){

        if (arr[i] > 0)
        {
        count++;
        }

    }
    return count;
}

PrintArray(arr);
int sumPositiveNumbers = GetPositiveNumber(arr);
Console.WriteLine($"Количество чисел больше нуля: {sumPositiveNumbers}");
