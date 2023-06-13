//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string val = Convert.ToString(num);

if (val.Length > 2)
{
    Console.WriteLine(" -> " + val[2]);
}
else{
    Console.WriteLine("Нет третьей цифры");
}