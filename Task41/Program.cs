// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// -------------------МЕТОДЫ----------------------------------------------------------------------------
int InputNumber(string qwerStr)//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
    {int num;
    string? text;
    while(true)
        {
            Console.WriteLine(qwerStr);
            text=Console.ReadLine();
           if(int.TryParse(text,out num)) break;
           Console.WriteLine("Введено некорректное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
//------------------------------------------------------------------------------------------------------
int InputNumberWithFilter(string qwerStr, bool zeroEnable, bool negativEnable)//Пропускает положительные. 0 и отрицательные пропускает в соответствии со булевыми значениями zeroEnable,negativEnable
    {int num;
    while(true)
        {
            num=InputNumber(qwerStr);//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
           if(num>=0 || num==0 && zeroEnable || num<0 && negativEnable) break;
           Console.WriteLine("Введено не разрешенное значение.Попробуйте еще раз"); 
        }
    return num;  
        }
//------------------------------------------------------------------------------------------------------
int[] InputIntArrayWithSheck(int size)//ВВОД ЧЕРЕЗ ТЕРМИНАЛ INT-массива из size элементов. Метод возвращает заполненный массив
{
int[] array=new int[size];  
for (int i=0; i<size;i++)
{
    Console.Write("Число "+(i+1));
    array[i]=InputNumber("");
}
return array;
}
//------------------------------------------------------------------------------------------------------
int CountPositiveValueInIntArray(int[] array) //Подсчет количества положительных элементов массива array
{   int countPositive=0;
    for (int i=0; i < array.Length; i++)
        {
           if (array[i]>0) {countPositive++;}
        }
return countPositive;
}
//------------------------------------------------------------------------------------------------------
void PrintArrayWithTitle(int[] array,string title,bool sizeView)//Вывод массива с заголовком, указанным в title и отображением длины при sizeView=true
    {
        System.Console.Write("Был введен массив");
        if(sizeView)
            {System.Console.WriteLine (" из " + array.Length + " элементов:");}
        else 
            {System.Console.WriteLine(":");}
        System.Console.WriteLine("[ "+String.Join(", ",array)+"]");
    }
// -------------------ОСНОВНАЯ ПРОГРАММА----------------------------------------------------------------------------

//ЗАДАЧУ МОЖНО РЕШИТЬ БЕЗ МАССИВА - ОБРАБАТЫВАЯ ЧИСЛА ПО МЕРЕ ВВОДА. МАССИВ ДОБАВЛЕН С ЦЕЛЬЮ РАСПЕЧАТКИ (ЧТО НЕОБЯЗАТЕЛЬНО) И ПРОЧИМИ МЕТОДИЧЕСКИМИ ЦЕЛЯМИ
int m=InputNumberWithFilter("Введите число М -количество чисел, которые надо ввести:", false, false);
int[] arr=new int[m] ;
arr=InputIntArrayWithSheck(m);//ВВОД ЧЕРЕЗ ТЕРМИНАЛ INT-массива из size элементов.
PrintArrayWithTitle(arr,"Был введен массив ",true);//Вывод массива с заголовком, указанным в title и отображением длины при sizeView=true
System.Console.WriteLine("Количество положительных чисел во введенном массиве: "+CountPositiveValueInIntArray(arr));//Вывод Подсчета количества положительных элементов массива array