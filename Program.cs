using System;

public class Program
{
    public static string CheckConfiguration(int players, int memory, bool isPublic, bool hasPassword)
    {
        if (players <= 0)
            return "Запуск невозможен: количество игроков должно быть больше нуля.";

        if (players >= 150 && memory <= 4)
            return "Запуск возможен с предупреждением: для такого количества игроков рекомендуется больше оперативной памяти.";

        if (memory < 8)
            return "Запуск невозможен: серверу недостаточно оперативной памяти.";

        if (isPublic && hasPassword)
            return "Запуск возможен с предупреждением: публичный сервер защищён паролем.";

        return "Сервер готов к запуску.";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CheckConfiguration(50, 8, true, false));
        Console.ReadKey();
    }
}