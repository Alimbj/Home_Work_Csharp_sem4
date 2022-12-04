// Домашнее задание №25
/*
Console.Clear();
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
int c = 1;
for (int i = 1; i <= b; i++)
    c *= a;
Console.WriteLine(c);
*/

//Домашнее задание №27
/*
Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine());
int n = 0;
int stop;
while (x != 0){
    n = x % 10 + n;
    x /= 10;
}
Console.WriteLine(n);
*/

// Домашнее задание №29
/* var array = new List<int> {};
for (int i = 0; i < 8; i++){
    int s = int.Parse(Console.ReadLine());
    array.Add(s);
}
foreach (var element in array)
    Console.Write($"{element} ");
// или так Console.WriteLine($"[{string.Join(", ", array)}]");
*/


//Доп. решение доп задачки



Console.WriteLine("Введите первое число");
int Nu = int.Parse(Console.ReadLine());
int[] array_third = new int[Nu];
int[] array_fourth = new int[Nu];
for (int i = 0; i < Nu; i++){
    int qq = int.Parse(Console.ReadLine());
    array_third[i] = qq;
}
Console.WriteLine("Введите второе число");
int Ch = int.Parse(Console.ReadLine());
int temp1 = 0;
int temp2 = 0;
if (Ch > 0){
    if (Ch < Nu){
        for (int i = Nu - Ch; i < Nu; i++){
            array_fourth[temp1] = array_third[i];
            temp1++;
        }
        for (int j = Ch; j < Nu; j++){
            array_fourth[j] = array_third[temp2];
            temp2++;
        }
    }
    if (Ch > Nu){
        while (Ch > Nu)
            Ch = Ch - Nu;
        Console.WriteLine(Ch);
        for (int i = Nu - Ch; i < Nu; i++){
            array_fourth[temp1] = array_third[i];
            temp1++;
        }
        for (int j = Ch; j < Nu; j++){
            array_fourth[j] = array_third[temp2];
            temp2++;
        }
    }
}
if (Ch < 0){
    if (-Ch < Nu){
        for (int i = Nu + Ch; i < Nu; i++){
            array_fourth[i] = array_third[temp1];
            temp1++;
        }
        for (int j = -Ch; j < Nu; j++){
            array_fourth[temp2] = array_third[j];
            temp2++;
        }
    }
    if (-Ch > Nu){
        while (-Ch > Nu)
            Ch = Nu + Ch;
        Console.WriteLine(Ch);
        for (int i = Nu + Ch; i < Nu; i++){
            array_fourth[i] = array_third[temp1];
            temp1++;
        }
        for (int j = -Ch; j < Nu; j++){
            array_fourth[temp2] = array_third[j];
            temp2++;
        }
    }
}

Console.WriteLine($"[{string.Join(", ", array_third)}]");
Console.WriteLine($"[{string.Join(", ", array_fourth)}]");
