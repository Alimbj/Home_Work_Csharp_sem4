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

//Доплнительная задача

Console.Write("Введите число "); // Вводим числа и создаем список
int N = int.Parse(Console.ReadLine());
int[] array_first = new int[N];
for (int i = 0; i < N; i++){
    int q = int.Parse(Console.ReadLine());
    array_first[i] = q;
}
//Console.WriteLine($"[{string.Join(", ", array_first)}]");
Console.WriteLine("Введите второе чилсо ");
int K = int.Parse(Console.ReadLine());  
int[] array_second = new int[N]; //Создаем второй список
if (K > 1 && K < N){  // Заполняем второй список элементами первого для случая когда 0 < K < N
    int w = K - 1;
    for (int j = 0; j < K; j++){  // отрезок нового списка от 0 до K-1
        if (w == N)
            break;
        array_second[j] = array_first[w];
        w++;
    }
    int e = 0;
    for (int o = N - K; o < N; o++){ //Отрезок нового списка от K до N-1
        array_second[o] = array_first[e];
        e++;
    }
}
else if (K > N){  // Заполняем второй список элементами первого для случая когда  K > N
    int w = K;
    while (w > N)
        w = K - N;
    int r = w;
    int count1 = 0;
    w--;
    for (int p = 0; p < N; p++){
        array_second[p] = array_first[w];
        w++;
        count1++; 
        if (w >= N)
            break;
        Console.WriteLine(w);
    }
    int e = 0;
    for (int j = count1; j < N; j++){
        array_second[j] = array_first[e];
        e++;
    }

}
// Далее рассматриваем случаи когда K отрицательное
else if (K < -1){
    if (-K < N){ // Приводим K к положительному(-K) значению и сравниваем с N, заполняем новый список для случая когда -K < N
        int u = -K;
        for (int t = 0; t < N-K; t++){
            array_second[t] = array_first[u];
            u++;
        }
        int p = 0;
        for (int y = -K; y < N; y++){
            array_second[p] = array_first[N-u];
            p++;
        }
    }
    else if (-K > N){  // Делаем то же самое что выше и заполняем новый список, но для случая когда -K > N
        int s = -K;
        while (s >= N)
            s = -K - N;
        int r = s;
        for (int p = 0; p < r; p++){
            array_second[s] = array_first[p];
            s++;
        }
        int e = 0;
        for (int i = r; i < N; i++){
            array_second[i] = array_first[e];
            e++;
        }
    }
}
else
    array_second = array_first;
Console.WriteLine($"[{string.Join(", ", array_first)}]");
Console.WriteLine($"[{string.Join(", ", array_second)}]");


//Другое решение доп задачки
/*
Console.WriteLine("Введите первое число");
int Nu = int.Parse(Console.ReadLine());
int[] array_third = new int[Nu];
for (int i = 0; i < Nu; i++){
    int qq = int.Parse(Console.ReadLine());
    array_third[i] = qq;
}
Console.WriteLine("Введите второе число");
int Ch = int.Parse(Console.ReadLine());
int[] array_fourth = new int[Nu];
int temp = 0;
while (temp != Ch){
    array_fourth[temp] = array_third[Ch-1];
    temp++;
    Ch++;
    if (Ch > Nu)
        break;
}
Console.WriteLine($"[{string.Join(", ", array_third)}]");
Console.WriteLine($"[{string.Join(", ", array_fourth)}]");
*/