//Bид 1
void Method1()
{
    Console.WriteLine( "Автор: Abdu");
}
//Method1();




//Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст в сообшения");



void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новий текст");

//Вид 3




int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

//Вид 4

string Method4(int conut, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < conut)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "ABDU");
//Console.WriteLine(res);

//Вид 
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//==== Работа с текстам
// Дан текст. В тексте нужно все заменить черточками,
// маленькие буквы "к" заменить большими "К",
// большими "С" заменить маленькими "с".

// Ясна ли задача?

string text = "Я думаю, - сказал князь, улыбаясь, - что"
            + "ежили бы вас послали вместе нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречнивы. вы дадите мне чаю?";

// string s = "qwerty"
//              012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    } 

    return result;
}

string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);


int [] arr = {3, 5, 8, 1, 7, 2, 9, 6, 4};

void PrintArray(int[] array)
{
    int count = array.Length;   
    
    for (int i = 0; i < count; i++)
    {
    Console.Write($"{array[i]}");

    }
    Console.WriteLine();
}

PrintArray(arr);


//Вид 
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}



 
