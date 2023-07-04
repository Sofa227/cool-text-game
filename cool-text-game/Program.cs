using System;
using System.Threading;

class NovelWriter
{
    static void Main()
    {
        // Создаем экземпляр класса Novel
        Novel novel = new Novel();

        // Начинаем новеллу
        novel.Start();

        Console.WriteLine("Конец истории. Спасибо вам за игру!!! Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}

