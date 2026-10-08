
//          FUNCTION 1



//task 1
//Create a function which returns "Hello, World!"
//Функсияе нависед , ки  return "Hello World!"  мекунад.

// void PrinHelo(string a)
// {
//     System.Console.WriteLine(a);
// }
// PrinHelo("hello world");

//task 2
//Add two numbers
//Фуксияе нависед , ки ду ракамро чамь мекунад

// void Sum(int a, int b)
// {
//     System.Console.WriteLine(a+b);
// }

// Sum(12,12);

//task 3
//Subtract two numbers
//Фуксияе нависед , ки ду ракамро тарх мекунад

// void Tarh(int a, int b)
// {
//     System.Console.WriteLine(a-b);
// }

// Tarh(12,12);


//task 4
//Multiply two numbers
//Фуксияе нависед , ки ду ракамро зарб мекунад


// void Zarb(int a, int b)
// {
//     System.Console.WriteLine(a*b);
// }

// Zarb(12,12);

//task 5
//Divide two numbers
//Фуксияе нависед , ки ду ракамро таксим мекунад


// void Taqsim(int a, int b)
// {
//     System.Console.WriteLine(a/b);
// }

// Taqsim(12,12);

//task 6
//Фуксияе нависед , ки як ракамро кабул  мекунад ва квадрати онро return мекунад


// void kvadrat(int a)
// {
//     System.Console.WriteLine(a*a);
// }

// kvadrat(12);

//task 7
//Create a function which returns the square Root of a given number
//Фуксияе нависед , ки як ракамро кабул мекунад ва решаи онро return мекунад


// void Sqrt(double a)
// {
//     System.Console.WriteLine(Math.Sqrt(a));
// }

// Sqrt(14);

//task 8
//Create a function which returns the factorial of a given number
//Фуксияе нависед , ки як ракамро кабул  мекунад ва фактариали онро return  мекунад

// int Mt(int a)
// {
//     int z=1;
//     for(int i=1; i<=a; i++)
//     {
//         z*=i;
//     }
//     return z;
// }

// Console.Write(Mt(3));

//task 9
//Create a function which returns the smallest number between a given range
//Фуксияе нависед , ки ду ракамро кабул  мекунад ва аз байни хамин ракамхо хурдтаринашро return   мекунад

// int Min(int a,int b)
// {
//     if (a > b)
//     {
//         return b+1;
//     }
//     else
//     {
//         return a+1;
//     }
// }
// System.Console.WriteLine(Min(11,160));

//task 10
//Фуксияе нависед , ки як ракамро кабул  мекунад ва арзиши мусбат онро return мекунад

// void Abs(double a)
// {
//     Console.WriteLine(Math.Abs(a)); 
// }
// Abs(-128);

//TASK 11
//returns " Even" if the number is even
//returns " Odd" if the number is odd 

// string EvOd(int a)
// {
//     if (a % 2 == 0)
//     {
//         return "even";
//     }
//     else
//     {
//        return "Odd";
//     }
// }
// System.Console.WriteLine(EvOd(3));

//task 12
//returns " Prime" if the number is prime
//returns " Not prime" if the number is not prime 


// void Prime(int a)
// {
//     int s=0;
//     for(int i=1; i<=a; i++)
//     {
//         if (i % a == 0)
//         {
//             s++;
//         }
//     }
//     if (s == 2)
//     {
//         System.Console.WriteLine("prime");
//     }
//     else
//     {
//         System.Console.WriteLine("not prime");
//     }
// }
// Prime(4);

//task 13
//Create a function which Concatenates two given strings and returns it

// void str(string a, string b)
// {
//     System.Console.WriteLine(a+b);
// }
// str("alijoni ", "zabiri");

//task 14
//Create a function which returns the length of the given strings

// void ls(string a)
// {
//     System.Console.WriteLine(a.Length);
// }
// ls("adbh");


//task 15
// Create a function which Checks if two strings are equal or Not
// returns "YES" if the given strings are equal
// returns "NO" if the given strings are Not equal 

// void Equal(string a, string b)
// {
//     if (a == b)
//     {
//         System.Console.WriteLine("yes");
//     }
//     else
//     {
//         System.Console.WriteLine("No");
//     }
// }
// Equal("alo","alo");




//                HOME TASK


//               FUNCTION 2


//task 1


//Create a function that checks if a number is greater than 10
//returns "True" if the given number is greater than 10 
//returns "False" if the given number is Not greater than 10

// int a=Convert.ToInt32(Console.ReadLine());

// string Gr10(int a)
// {
//     if (a > 10)
//     {
//         return "True";

//     }
//     else
//     {
//         return "false";
//     }
// }

// System.Console.WriteLine(Gr10(a));


//task 2


//Create a function that checks if a given number is a palindrome or not

// int a=Convert.ToInt32(Console.ReadLine());

// void palindrome(int a)
// {
//     int r=0;
//     for(int i=a; i>0; i /= 10)
//     {
//      r=r*10+i%10;
//     }
//     if(r==a){
//          System.Console.WriteLine("palindrome");
//     }
//     else
//     {
        
//      System.Console.WriteLine("not palindrome");
//     }
// }
// palindrome(a);


//task 3
//Task1: Create a function  int SumOfTwoNums(int a, int  b)  that takes two numbers as arguments and returns their sum. Don’t forget to return the result.


// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());

// string  Sum(int a, int b)
// {
//     return $"Sum = {a+b}";
// }
// System.Console.WriteLine(Sum(a,b));


//task 4

//Task3: Create a function that takes a number as an argument, increments the number by +1 and returns the result. Don’t forget to return the result.


// int a=Convert.ToInt32(Console.ReadLine());

// string Argument(int a)
// {
//     return $"Result = {a+1}";
// }
// System.Console.WriteLine(Argument(a));


//task 5

//Write a function that takes the base and height of a triangle and return its area. The area of triangle is: (base*height)/2.  Don’t forget to return the result.


// System.Console.Write("Enter base: ");
// int Base=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter width: ");
// int width=Convert.ToInt32(Console.ReadLine());

// int Triengle(int b, int w)
// {
//     return (b*w)/2;
// }

// System.Console.WriteLine($"Area: {Triengle(Base,width)}");



//task 6


// Create a function that takes the age in years and returns the age in days. Use 365 days of a year for this challenge.  Don’t forget to return the result.

// int Year=Convert.ToInt32(Console.ReadLine());

// int Days(int y)
// {
//     return y*365;
// }

// System.Console.WriteLine(Days(Year));


//task 7

//Write a function int Age(int a) that calculates a person's age. If the person is over 18 and under 100, the console should say "Welcome, you are "..." years old and you can work'." Otherwise, the console will display the message "Hello, you are "..." years old, and you can't work." (Напишите функцию int Age(int a), которая вычисляет возраст человека. Если человеку больше 18 и меньше 100, консоль должна сказать: «Добро пожаловать, вам «…» лет, и вы можете работать». В противном случае консоль выдаст сообщение «Здравствуйте, вам «…» лет, и вы не можете работать».)


// int Year=Convert.ToInt32(Console.ReadLine());

// void Y(int y)
// {
//     int a=2026-y;
//     if(a>18 && a < 60)
//     {
//         System.Console.WriteLine($"welcome, you are {a} years old you can work");
//     }
//     else
//     {
//         System.Console.WriteLine($"welcome, you are {a} years old you can't work");
//     }
// }
// Y(Year);

//task 8
// Create a function int SumOfNumbers(int a) that takes a number as an argument. Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.( Создайте функцию int SumOfNumbers (int a), которая принимает число в качестве аргумента. Сложите все числа от 1 до числа, которое вы передали функции. Например, если на входе 4, ваша функция должна вернуть 10, потому что 1 + 2 + 3 + 4 = 10.)

// int a=Convert.ToInt32(Console.ReadLine());
// void Sum(int a)
// {
//     int s=0;
//     for(int i=1; i<=a; i++)
//     {
//         s+=i;
//     }
//     System.Console.WriteLine($"Sum of all number from 1 until {a} is: {s}");
// }
// Sum(a);



//task 9
//. Given a natural number N. Write a function int MinDigit (int n) and int MaxDigit (int n) that specifies the smallest and largest digits of the given number.( Дано натуральное число N. Напишите функцию int MinDigit (int n) и int MaxDigit (int n), определяющую наименьшую и наибольшую цифры заданного числа.)

// int a=Convert.ToInt32(Console.ReadLine());
// void MaxMin(int a)
// {
//     int m=int.MinValue;
//     int mn=int.MaxValue;
//     int b=0;
//     for(int i=a; i>0; i /= 10)
//     {
//         b=i%10;
//         if (b > m)
//         {
//             m=b;
//         }
//         if (b < mn)
//         {
//             mn=b;
//         }
//     }
//         System.Console.WriteLine($"maximum = {m}");
//         System.Console.WriteLine($"minimum = {mn}");
// }
// MaxMin(a);


//task 10
//
// int a=Convert.ToInt32(Console.ReadLine());
// void digits(int a)
// {
//     int b=0;
//     int s=0;
//     for(int i=a; i>0; i /= 10)
//     {
//         b=i%10;
//         s++;
//     }
//         System.Console.WriteLine($"digits = {s}");
// }
// digits(a);



//                 FUNCTION 3



//task 1
//Функсияеро нависед (int FindMinimum(int a, int b, int c, int d)), ки чаҳор адади бутунро қабул мекунад ва адади хурдтарини онҳоро бармегардонад.

// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// int c=Convert.ToInt32(Console.ReadLine());
// int d=Convert.ToInt32(Console.ReadLine());

// string Min(int a,int b, int c, int d)
// {
//     if(a<b && a<c && a < d)
//     {
//         return $"min: {a}";
//     }
//     else if(b<a && b<c && b < d)
//     {
//         return $"min: {b}";
//     }
//     else if(c<a && c<b && c < d)
//     {
//         return $"min: {c}";
//     }
//     else
//     {
//         return $"min: {d}";
//     }
// }
// System.Console.WriteLine(Min(a,b,c,d));

