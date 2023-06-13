// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, соответствующее одному из дней недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void WeekendOrNo(int dayNumber) {
    if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine("(Это выходной?) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
        Console.WriteLine("Число не соответствует ни одному из дней недели");
    }
    else Console.WriteLine("(Это выходной?) -> нет");
}

WeekendOrNo(dayNumber);