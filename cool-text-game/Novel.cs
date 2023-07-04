using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Novel
    {
        private Vivod textPrinter;

        public Novel()
        {
            textPrinter = new Vivod();
        }

        public void Start()
        {
        //День 2
            textPrinter.PrintLine("СЛЕДУЮЩИЙ ДЕНЬ");
            textPrinter.Wait();
            textPrinter.PrintLine("- Доброе Утро! Я за ночь успел пофиксить 16 багов. - Сказал Муравьед.");
            textPrinter.Wait();

            textPrinter.PrintLine("- Привет! - с отвращением ответил Ноегис.");
            textPrinter.Wait();

            //Выбор 1
            if (textPrinter.ChooseOption("Пойти умыться", "Пойти кушать в столовую"))
            {
                textPrinter.PrintLine("Вы выбрали сходить умыться.");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис почистил зубки и приятно пахнет теперь");
                textPrinter.Wait();
                
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
