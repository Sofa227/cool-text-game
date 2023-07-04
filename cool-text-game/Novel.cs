using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Novel
    {
        private NovelTextPrinter textPrinter;

        public Novel()
        {
            textPrinter = new NovelTextPrinter();
        }

        public void Start()
        {

            textPrinter.PrintLine("В недалеком городке Компорово жил веселый парень - Ноегис. Ему было всего 17 лет и он решил отправится в лагерь \"Верхневолжский\".");
            textPrinter.Wait();

            textPrinter.PrintLine("Ноегис - больной парень, страдающий Альцгеймером и Амнезией.");
            textPrinter.Wait();

            textPrinter.PrintLine("Дабы почувствовать себя лучше, герой решает отправится в лагерь, чтобы найти друзей(а мб и девушку).");
            textPrinter.Wait();

            textPrinter.PrintLine("Наш герой сел не на тот автобус, где абсолютно не было людей, но подумал что так и надо, ведь он едет один из самых первых.");
            textPrinter.Wait();

            //Выбор 1
            if (textPrinter.ChooseOption("Поехать домой", "На мужика пойти в лагерь"))
            {
                textPrinter.PrintLine("Вы выбрали поехать домой.");
                textPrinter.Wait();

                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                textPrinter.PrintLine("Вы выбрали на мужика пойти в лагерь.");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис идет на кпп, но там никого нет. Он удивляется, где охрана или кто то вообще.");
                textPrinter.Wait();

                textPrinter.PrintLine("Но на смелости заходит уже в сам лагерь.");
                textPrinter.Wait();

                textPrinter.PrintLine("Паренек сразу видит прекрасный лес , который окутал почти 50га земли, спортплощадки, огромный дом культуры и самое интересное жилые корпуса.");
                textPrinter.Wait();
            }

            
            // Завершаем новеллу
            textPrinter.PrintLine("Выходите из леса...");
            textPrinter.Wait();
        }
    }
