// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = new Random().Next(1, 10000);
int t = num;
int rev = 0;
int d;

System.Console.WriteLine(num);

while(num > 0)
    {
         d = num % 10;
         rev = rev * 10 + d;
         num = num / 10;
    }
    if(t == rev)
    {
        Console.WriteLine("It's a palindrome number");
    }
    else
    {
        Console.WriteLine("It's a not palindrome number");
    }

		 
