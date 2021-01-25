using System;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           /*int[] array = new int[3];
           array[0] = 1;
           array[1] = 2;
           array[2] = 3;

           string[] arrayString = new string[] {"First","Second"};*/
           // задачка на вычисление суммы между числами работает с багами, к примеру если ввести 6 и 9 
           // то во втором задачке выводит четное число, а если вводить оба четные или оба нечётные числа то прога работает нормально
           // 
           Console.WriteLine("Задание 3.1:");
          /* int A = Convert.ToInt32(Console.ReadLine());
           int B = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("A = {0}", A);
           Console.WriteLine("B = {0}", B);
           Console.WriteLine("Первая задача: {0}", (A + B) * (B - A - 1) / 2);
           Console.Write("Вторая задача: ");
          // for (int i = A + 1 % 2 == 1 ? A + 1 : A + 2; i < B; i = i + 2)
         //   Console.WriteLine("{0} ",i);
            if ((A & 1) == 0)
                 A++;
            for(int i=A; i<B; i+=2)
            Console.Write(i);*/
                {
                    Console.Write("A = :");
                    int a = int.Parse(Console.ReadLine()); 
                    Console.Write("B = :");
                    int b = int.Parse(Console.ReadLine()); 
                    int sum2 = 0; 
                    while ( a < b - 1 ){
                        a++; 
                        sum2+=a; 
                    }
                    Console.WriteLine($"Sum = {sum2}"); 
                    
                }
                {
                    Console.WriteLine("Задание 3.2:");
                    Console.Write("A:");
                    int a = int.Parse(Console.ReadLine()); 
                    Console.Write("B:");
                    int b = int.Parse(Console.ReadLine()); 
                    string ans = ""; 
                    if ( a + 1 != b ){
                         System.Console.WriteLine($"Нечетные числа между {a} и {b}:");
                        for ( int i = a+1; i <= b-1; i++ ){
                            if ( i % 2 == 1 ){
                                 ans+= i + ","; 
                            }
                        }
                        ans = ans.Remove(ans.Length-1,1);
                        System.Console.WriteLine(ans); 
                    }
                    else{
                        System.Console.WriteLine($"Нечетные между {a} и {b} нет чисел");   
                    }
                Console.ReadKey();   
                }
                {
                    Console.WriteLine("Задача 3.3: ");
                    Console.WriteLine("Прямоугольник:");
                    for ( int i = 1; i <= 7; i++ ){
                        if ( i == 1 || i == 7){
                            for ( int j = 1; j <= 20; j++ ){
                                System.Console.Write("*");
                            }
                            Console.WriteLine(""); 
                        }
                        else{
                            Console.Write("*"); 
                            for ( int j = 2; j <= 19; j++ ){
                                System.Console.Write(" ");
                            }
                            Console.Write("*\n"); 
                        }

                    }

                    System.Console.WriteLine("Прямоугольный треугольник:");

                    for ( int i = 1; i <= 7; i++ ){
                        if ( i == 1 || i == 7 ){
                            if ( i == 1 ){
                                Console.Write("*"); 
                            }
                            else{
                                for ( int j = 1; j <= 13; j++ ){
                                    Console.Write("*"); 
                                }
                            }
                            Console.Write("\n"); 
                        }
                        else{
                            Console.Write("*"); 
                            for ( int j = 1; j <= i-1; j++ ){
                                Console.Write("  "); 
                            }
                            Console.Write("*\n"); 
                        }
                    }
                    {
                            
                        Console.WriteLine("Треугольник:"); 

                        for ( int i = 1; i <= 5; i++ ){
                            if ( i == 1){
                                for ( int j = 1; j <= 9; j++ ){
                                    if ( j == 6 ){
                                        Console.Write('*'); 
                                    }
                                    else{
                                        Console.Write(" "); 
                                    }
                                }
                                Console.Write("\n"); 
                            }
                            else if ( i == 5 ){
                                for ( int j = 1; j <= 11; j++ ){
                                    Console.Write("*"); 
                                }
                                Console.Write("\n"); 
                            }
                            else{
                                int r = 6 - i; 
                                int l = 6 + i; 
                                for ( int j = 1; j <= 10; j++ ){
                                    if ( j == r || j == l ){
                                        Console.Write("*"); 
                                    }else{
                                        Console.Write(" "); 
                                    }
                                }
                                Console.Write("\n"); 
                            }
                        }
                    }

                    {
                        Console.WriteLine("Ромб:");
                        int l = 8, r = 8; 
                        for ( int i = 1; i <= 3; i++ ){
                            for ( int j = 1; j <= 16; j++ ){
                                if ( l == j || r == j ){
                                System.Console.Write("*");
                                }
                                else{
                                System.Console.Write(" ");
                                }
                            }
                            Console.Write("\n"); 
                            l-=2; r+=2; 
                        } 
                        l = 8+(3*-2); r = (8+3*2); 
                        for ( int i = 4; i >= 1; i-- ){
                            for ( int j = 1; j <= 14; j++ ){
                                if ( l == j || r == j ){
                                System.Console.Write("*");
                                }
                                else{
                                System.Console.Write(" ");
                                }
                            }
                            Console.Write("\n"); 
                            l+=2; r-=2; 
                        } 
                    }
                    Console.WriteLine("Задание 3.4:");
                    {
                    // Zadanie #4 
                    Console.WriteLine("Вклады в банке :");
                    double sum = 1000f;
                    Console.Write(" Проценты: "); 
                    double P = double.Parse(Console.ReadLine());  
                    int m = 0; 
                    while ( sum < 1100f ){
                        sum = sum + sum*(P/100);
                        m++; 
                    }
                    System.Console.WriteLine($"Результат через {m} месяц(ев) и вклад = {Math.Round(sum,2)}");
                }
                
                {
                Console.WriteLine("Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер массива задает пользователь).");
                Console.Write(" Размер массива : ");           
                int N = int.Parse(Console.ReadLine());
                int[] a = new int[N];
                long mx= -999999999, mn=9999999999, sum = 0; 
                String odds = ""; 
                Console.WriteLine("Вводите элементы массива через Enter :");  
                for ( int i = 0; i < N; i++ ){
                    Console.Write(" "); 
                    a[i] = int.Parse(Console.ReadLine());
                    mx = Math.Max(mx, a[i]); 
                    mn = Math.Min(mn, a[i]); 
                    sum += a[i]; 
                    if ( a[i] % 2 == 1 )
                        odds += a[i] + " ";  
                }
                System.Console.WriteLine($" Максимум {mx}" + $"\n Минимум {mn} \n Сумма  {sum} \n Среднее арифметическое {(double)sum/N} \n Нечётные числа :" + odds);
                Console.WriteLine("Нажмите любую клавишу..."); 
                Console.ReadKey(); 
            }
            {
             Console.WriteLine("Создайте проект, который принимает в качестве аргумента массив целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном порядке).");
                Console.Write(" N = ");
                int N = int.Parse(Console.ReadLine());
                int[] a = new int[N];           
                Console.WriteLine("Ввод массива через Enter:"); 
                for ( int i = 0; i < N; i++ ){
                    Console.Write(" "); 
                    a[i] = int.Parse(Console.ReadLine()); 
                }
                for ( int i = N-1; i >= 0; i-- ){
                    Console.Write(" "+ a[i]); 
                }
                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить"); 
                Console.ReadKey();   
            }
            {
                Console.WriteLine("Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер массива задает пользователь).");
                Console.Write(" N = ");
                int N = int.Parse(Console.ReadLine());
                int[] a = new int[N]; 
                int count, index; 
                Console.Write("Count : "); 
                count = int.Parse(Console.ReadLine());
                Console.Write("Index : "); 
                index = int.Parse(Console.ReadLine()); 
                if ( index + count > N ){
                     a = new int[index+count+1]; 
                     for ( int i = N; i <= index + count; i++ ){
                        a[i] = 1; 
                    }
                }
               // Console.WriteLine("Вводите элементы массива через Enter:");
                for ( int i = 0; i < N; i++ ){
                   // Console.Write(" "); 
                    a[i] = /*int.Parse(Console.ReadLine()); */ new Random().Next(2,100);
                    Console.WriteLine(" " + a[i]);
                }
                for ( int i = index; i < index + count; i++ ){
                    System.Console.Write(" "+ a[i]);
                }
                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить..."); 
                Console.ReadKey(); 
            }
            }

         /*  for (var i = 0; i < array.Length;i++) {
              // Console.WriteLine(array[i]);
              if (i == 1) {
                  break;
              }
               Console.WriteLine($"Значения в индексе[{i}] = {array[i]}");
           }*/

         /*  for(int i = 0; i < 10; i++) {
               Console.WriteLine($"i={i}");
               for (int z = 0; z < 5; z++) {
                   Console.WriteLine($"z={z}");
               }
           }*/

         /*  int arrLength = Convert.ToInt32(Console.ReadLine());

           var arrClient = new double[arrLength];

           for(int i = 0; i < arrClient.Length; i++) {
               Console.WriteLine($"Сумма клиента №{i}:");
               arrClient[i] = Convert.ToDouble(Console.ReadLine());
            }*/

          /*  foreach (double item in arrClient)
            {
                double bonus = 0;
                if(item > 0 && item < 200) {
                    bonus = (item * 5) / 100;
                }
                Console.WriteLine($"Сумма клиента = {item}, бонус = {bonus}");
            }*/
         //   var str = " ";
           /* var isRunning = false;
            while(isRunning) {
               var str = Console.ReadLine();
               isRunning = !str.Equals("q");
               Console..WriteLine("Still Running");
            }*/
         //  array[3] = 3;
         /*  foreach (var item in array)
           {
               Console.WriteLine(array);
           }*/
         /*  Console.WriteLine(array[0]);
           Console.WriteLine(array[1]);
           Console.WriteLine(array[2]);
           Console.WriteLine($"Длина массива {arrayString.Length}");
           Console.WriteLine("Длина массива {0}",array.Length);*/
         //  Console.ReadKey();
        }
    }
}
