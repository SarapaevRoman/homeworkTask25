//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите первое числа: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: "); 
int secondNumber = Convert.ToInt32(Console.ReadLine());
int number = firstNumber;
for (int i = 1; i < secondNumber; i++){
    number = number * firstNumber;
}
Console.WriteLine(number);

