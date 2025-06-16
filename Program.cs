using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using static System.Console;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

//Задание 1
//int[] A = new int[5];
//double max_elem = A[0], min_elem = A[0];
//double sum = 0, mult = 1, spec_A_sum = 0, spec_B_sum = 0;
//double[,] B = new double[3, 4];
//Random rnd = new Random();

//for (int i = 0; i < 5; i++)
//{
//    WriteLine("Введите элемент массива A: ");
//    A[i] = Convert.ToInt32(ReadLine());
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        B[i, j] = rnd.Next(10);
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    if (min_elem > A[i])
//    {
//        min_elem = A[i];
//    }
//    if (max_elem < A[i])
//    {
//        max_elem = A[i];
//    }
//    if ((i+1) % 2 == 0)
//    {
//        spec_A_sum += A[i];
//    }
//    mult *= A[i];
//    sum += A[i];
//    Write(A[i]);
//}

//WriteLine('\n');

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if (min_elem > B[i, j])
//        {
//            min_elem = B[i, j];
//        }
//        if (max_elem < B[i, j])
//        {
//            max_elem = B[i, j];
//        }
//        if ((j+1) % 2 != 0)
//        {
//            spec_B_sum += B[i, j];
//        }
//        mult *= B[i, j];
//        sum += B[i, j];
//        Write($"{B[i, j]} ");
//    }
//    WriteLine('\n');
//}

//WriteLine($"Сумма всех чисел обоих массивов: {sum}\nПроизведение всех чисел обоих массивов: {mult}\nМаксимальное число среди всех элементов обоих массивов: {max_elem}" +
//    $"\nМинимальное число среди всех элементов обоих массивов: {min_elem}\n\nСумма чётных элементов массива A: {spec_A_sum}\nСумма нечётных столбцов массива B: {spec_B_sum}");



//Задание 2
//int[,] matrix = new int[5, 5];
//int min_elem = matrix[0, 0], max_elem = matrix[0, 0], flag_i1 = 0, flag_i2 = 0, flag_j1 = 0, flag_j2 = 0;
//int sum = 0;
//Random rnd = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        matrix[i,j] = rnd.Next(-100, 100);
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if(min_elem > matrix[i, j])
//        {
//            min_elem = matrix[i, j];
//            flag_i1 = i;
//            flag_j1 = j;
//        }
//        if (max_elem < matrix[i, j])
//        {
//            max_elem = matrix[i, j];
//            flag_i2 = i;
//            flag_j2 = j;
//        }
//        Write($"{matrix[i, j]}\t");
//    }
//    WriteLine();
//}

//int[] arr = new int[25];
//int index = 0;
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        arr[index++] = matrix[i, j];
//    }
//}

//int min = flag_i1 * 5 + flag_j1;
//int max = flag_i2 * 5 + flag_j2;
//int start = Math.Min(min, max) + 1;
//int end = Math.Max(min, max);

//for (int i = 0; i < 25; i++)
//{
//    Write($"{arr[i]} ");
//}

//for (int i = start; i < end; i++)
//{
//    sum += arr[i];
//}

//WriteLine($"\nМаксимальный элемент матрицы: {max_elem}\nМинимальный элемент матрицы: {min_elem}\n\nСумма элементов матрицы между минимальным и максимальным числами: {sum}");



//Задание 3
//WriteLine("Введите текст, который хотите зашифровать: ");
//string text = ReadLine();
//WriteLine("Введите отступ для шифрования: ");
//int indent = Convert.ToInt32(ReadLine());

//char[] result = new char[text.Length];

//for (int i = 0; i < text.Length; i++)
//{
//    char c = text[i];
//    char step = char.IsUpper(c) ? 'A' : 'a';
//    c = (char)(((c + indent - step) % 26) + step);
//    result[i] = c;
//}

//string conclusion = String.Concat(result);
//WriteLine($"Зашифрованный текст: {conclusion}");

//indent = (26 - indent);
//char[] decrypt_result = new char[text.Length];
//for (int i = 0; i < text.Length; i++)
//{
//    char c = conclusion[i];
//    char step = char.IsUpper(c) ? 'A' : 'a';
//    c = (char)(((c + indent - step) % 26) + step);
//    decrypt_result[i] = c;
//}

//string second_conclusion = String.Concat(decrypt_result);
//WriteLine($"Результат работы дешифратора: {second_conclusion}");



//Задание 4
//int[,] matrix1 = new int[5, 5];
//int[,] matrix2 = new int[5, 5];
//int[,] multiger_matrix = new int[5, 5];
//int[,] sum_matrix = new int[5, 5];
//int[,] mult_matrix = new int[5, 5];
//Random rnd = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        matrix1[i, j] = rnd.Next(10);
//        Write($"{matrix1[i, j]}\t");
//    }
//    WriteLine();
//}

//WriteLine("\n");

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        matrix2[i, j] = rnd.Next(10);
//        Write($"{matrix2[i, j]}\t");
//    }
//    WriteLine();
//}

//WriteLine("Введите число: ");
//int num = Convert.ToInt32(ReadLine());
//WriteLine("Первая матрица, умноженная на ваше число: ");

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        multiger_matrix[i, j] = (matrix1[i, j] * num);
//        Write($"{multiger_matrix[i, j]}\t");
//    }
//    WriteLine();
//}

//WriteLine("\nПервая матрица, сложенная со второй: ");

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        sum_matrix[i, j] = (matrix1[i, j] + matrix2[i, j]);
//        Write($"{sum_matrix[i, j]}\t");
//    }
//    WriteLine();
//}

//WriteLine("\nПервая матрица, перемноженная элементами со второй: ");

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        sum_matrix[i, j] = (matrix1[i, j] * matrix2[i, j]);
//        Write($"{sum_matrix[i, j]}\t");
//    }
//    WriteLine();
//}



//Задание 5
//bool flag = false;
//WriteLine("Введите простое выражение, содержащие только операторы + и -: ");
//string input = ReadLine();

//int length = input.Length;
//double result = Convert.ToDouble(new DataTable().Compute(input, null));
//char[] checker = input.ToCharArray();
//try
//{
//    for (int i = 0; i < length; i++)
//    {
//        if (checker[i] == '*' || checker[i] == '/' || checker[i] == '%' || checker[i] == '=')
//        {
//            throw new InvalidOperationException();
//        }
//    }
//}
//catch (Exception ex)
//{
//    WriteLine("Некорректное выржание: использованы недопустимые операторы!");
//    flag = true;
//}

//if(!flag)
//{
//    WriteLine(result);
//}



//Задание 6
//StringBuilder result = new StringBuilder();

//WriteLine("Введите любой текст без заглавных букв: ");
//string text = ReadLine();

//result.Append(char.ToUpper(text[0]));

//for (int i = 1; i < text.Length; i++)
//{
//    if ((text[i] == '.' || text[i] == '!' || text[i] == '?') && i + 1 < text.Length)
//    {
//        result.Append(text[i]);
//        i++;
//        result.Append(text[i]);
//        i++;
//        result.Append(char.ToUpper(text[i]));
//    }
//    else
//    {
//        result.Append(text[i]);
//    }
//}

//WriteLine($"Модифицированный массив: {result}");



//Задание 7
StringBuilder result = new StringBuilder();
StringBuilder cur_word = new StringBuilder();

WriteLine("Введите недопустимое слово: ");
string forb_word = ReadLine();
WriteLine("Введите текст: ");
string text = ReadLine();

result = Filter(text, forb_word);
//foreach (char c in text)
//{
//    if (char.IsLetter(c) || c == '\'')
//    {
//        cur_word.Append(c);
//    }
//    else
//    {
//        string word = cur_word.ToString();

//        if (forb_word == word)
//        {
//            result.Append(new string('*', cur_word.Length));
//        }
//        else
//        {
//            result.Append(word);
//        }
//        result.Append(c);
//    }
//}

StringBuilder Filter(string text, string forb_word_s)
{
    StringBuilder result = new StringBuilder();
    StringBuilder cur_word = new StringBuilder();

    foreach (char c in text)
    {
        if (char.IsLetter(c) || c == '\'')
        {
            cur_word.Append(c);
        }
        else
        {
            CheckWord(cur_word, forb_word_s, result);
            result.Append(c);
        }
    }
    CheckWord(cur_word, forb_word_s, result);

    return result;
}

static void CheckWord(StringBuilder word, string forb_word, StringBuilder result)
{
    if (word.Length == 0)
        return;

    string wordStr = word.ToString();

    if (forb_word == wordStr)
    {
        result.Append(new string('*', word.Length));
    }
    else
    {
        result.Append(wordStr);
    }
    word.Clear();
}
  WriteLine($"Модифицированный текст: {result}");