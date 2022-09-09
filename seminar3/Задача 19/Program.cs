//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Читается число как справа так и слева одинаково


Console.Write("Проверяем число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - Не палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Жду правильное число");