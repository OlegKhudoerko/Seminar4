// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] GetDigArray(int size) //Метод "GetDigArray"

{
int[] result = new int[size]; //Задаем массив длиной "size", в нашем случае "8"
for (int i = 0; i < result.Length; i++) result[i] = new Random().Next(100); //См строку 18
return result;
}

int [] array = GetDigArray(8);//Задаем массив длиной "8" c помощью метода "GetDigArray"
Console.WriteLine($"\n{String.Join(", ", array)} -> [ {String.Join(", ", array)} ]\n");//Выводим красивый результат с помощью "String.Join"

//Строка 11 -> Пока счетчик "i" меньше "8", ячейке "i" массива "result" присваеваем псевдослучайное число от "0 до 100"