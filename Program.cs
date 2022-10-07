// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// viod - eto metod kotoriu nichego ne vozvraschaet

void FillArray(int[] collection) // collection - это название аргумента
 {
    int length = collection.Length; // здесь мы получаем длину массива
    int index = 0; // просто взяли позицию index и по умолчанию присвоили ей 0 
    while(index < length) // что-то делаем
    {
        collection[index] = new Random().Next(1,100);   //обращаемся к агрументу коллекшн на позицию индекс и ложем туда новое случайное число 
        index++; // просто увеличиваем индех на 1
    }
 }

void PrintArray(int[] col) // metod void kotorui pe4ataet massiv, v ka4estve argumenta zdecb bydet prixodit' massiv "col"
{
    int count = col.Length; // obozna4ili kol-vo elementov
    int posotion = 0; // obozna4ili tekyschyu pozociu 
    while(posotion<count)
    {
        Console.WriteLine(col[posotion]); // vivodim pozociu tekyschego elementa
        posotion++; // yvelichivaem poziciu tekyschego elementa
    }
}

int[] array = new int[8]; // создай новый массив в котором будет 8 элементов, по умолч. он наполнен нулями [0]

FillArray(array); // vizivaev massiv
PrintArray(array); // vivodim massiv
