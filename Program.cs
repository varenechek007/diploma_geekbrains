//функция создания и заполнения массива значниями от пользователя
string [] create_array_string (int count)
{
    string[] A = new string [count];
    for (int i = 0; i < count; i++)
    {   
        Console.WriteLine("Напишите значения для индекса: " + i);
        A[i] = Convert.ToString(Console.ReadLine());
    }
    return A;
}

//функция вывода массива строк
void print_array_string (int count, string []A)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(A[i] + " ");
    }
    Console.WriteLine("");
}
//поиск количества элементов длинной менее либо равно 3
int search_count_elem_less_then_3 (int count, string []A)
{
    int count3 = 0;
    for (int i =0; i<count;i++)
    {
        if (A[i].Length <= 3)
        {
            count3++;
        }
    }

    return count3;
}
//создание и наполнение результирующего массива, состоящего из элементов длинной менее либо равно 3
string [] full_result_array (int count, string []A, int count3)
{
    string[] A3 = new string [count3];
    int j = 0;
    for (int i =0; i<count;i++)
    {
        if (A[i].Length <= 3)
        {
            A3[j] = A[i];
            j++;
        }
    }
    return A3;
}

int count;
Console.WriteLine("Размер массива");
count = Convert.ToInt32(Console.ReadLine());
string [] A = create_array_string(count);
Console.WriteLine("Исходный массив:");
print_array_string (count,A);

int count3=0;
count3 = search_count_elem_less_then_3(count,A);
Console.WriteLine("Количество элементов с размеров менее 3: " +count3);
if(count3 > 0)
{
    string [] A3 = full_result_array(count,A,count3);
    Console.WriteLine("Массив результатов:");
    print_array_string (count3,A3);
}
else Console.WriteLine("Массив результатов пустой");