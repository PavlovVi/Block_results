//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритмаю При решении не рекмендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

string[] firstArray = new string[] { "apple", "vana", "-32", "dat", "Kazan" };
     
int count = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        count++;
    }
}

string[] secondArray = new string[count];
int index = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[index] = firstArray[i];
        index++;
    }
}