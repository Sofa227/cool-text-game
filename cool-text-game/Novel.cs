﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_text_game
{
    public class Novel
    {
        private NovelTextPrinter textPrinter;

        public Novel()
        {
            textPrinter = new NovelTextPrinter();
        }

        public void Start()
        {
            // Выводим первую строку новеллы
            textPrinter.PrintLine("Вы находитесь в темном лесу...");
            textPrinter.Wait();

            // Вариант выбора 1
            if (textPrinter.ChooseOption("Пойти налево", "Придержаться левой тропы"))
            {
                textPrinter.PrintLine("Вы выбрали пойти налево.");
                textPrinter.Wait();

                // Ветка повествования для первого выбора
                textPrinter.PrintLine("Вы продолжаете идти по лесной тропе...");
                textPrinter.Wait();
                textPrinter.PrintLine("Вдруг вы видите яркий свет впереди...");
                textPrinter.Wait();
            }
            else
            {
                textPrinter.PrintLine("Вы выбрали не идти налево.");
                textPrinter.Wait();

                // Ветка повествования для первого выбора
                textPrinter.PrintLine("Вы решаете идти прямо по главной тропе...");
                textPrinter.Wait();
                textPrinter.PrintLine("Через некоторое время вы видите развилку...");
                textPrinter.Wait();
            }

            // Вариант выбора 2
            if (textPrinter.ChooseOption("Пойти направо", "Свернуть вправо"))
            {
                textPrinter.PrintLine("Вы выбрали пойти направо.");
                textPrinter.Wait();

                // Ветка повествования для второго выбора
                textPrinter.PrintLine("Вы следуете по узкой тропинке...");
                textPrinter.Wait();
                textPrinter.PrintLine("Через некоторое время вы видите ручеек...");
                textPrinter.Wait();
            }
            else
            {
                textPrinter.PrintLine("Вы выбрали не идти направо.");
                textPrinter.Wait();

                // Ветка повествования для второго выбора
                textPrinter.PrintLine("Вы решаете идти прямо по главной тропе...");
                textPrinter.Wait();
                textPrinter.PrintLine("По пути вы встречаете заброшенную хижину...");
                textPrinter.Wait();
            }

            // Завершаем новеллу
            textPrinter.PrintLine("Выходите из леса...");
            textPrinter.Wait();
        }
    }
}