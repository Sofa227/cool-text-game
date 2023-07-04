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

                textPrinter.PrintLine("- Пойду-ка я на улицу прогуляюсь, не особо хочу кушать.");
                textPrinter.Wait();

                textPrinter.PrintLine("Гуляя по территории лагеря, Ноегис встречает Егора.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Привет, с тобой же Муравьед живет, верно? - Спросил Егор.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Да! - Ответил Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("- Круто, я зайду к вам попрогать вместе с ним, мы крутой проект замутили просто. - Сказал Егор");
                textPrinter.Wait();

                textPrinter.PrintLine("- Окей. - Ответил Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("- Спасибо, пока! - Произнёс Егор");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис подошёл к Ивану и они впятером пошли убирать свою территорию - спортплощадку.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Да, тильт. - Глеб");
                textPrinter.Wait();

                textPrinter.PrintLine("- Щас бы на речечку - Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("- Хватит ныть хлюпики, нас кайфово накормят потом, говорят будут пельмени на обед. - Ванек");
                textPrinter.Wait();

                textPrinter.PrintLine("- Работаем, братцы - Гриша");
                textPrinter.Wait();

                textPrinter.PrintLine("Отработав пару часов ребята отправились на обед");
                textPrinter.Wait();

                textPrinter.PrintLine("- Гайс, мне надо домой зайти, я забыл кое-что. - Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("- Давай, только поторопись. - Ванек");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис заходит в комнату, а там Василий и Егор программируют на двух стульях.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Присоединяйся! - Говорят они");
                textPrinter.Wait();

            if (textPrinter.ChooseOption("Спасибо откажусь.", "На полчасика только."))
            {
                textPrinter.PrintLine("- Спасибо, но я откажусь - ответил Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как жаль - Егор");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис взял таблетки и пластырь и ушел...");
                textPrinter.Wait();

                textPrinter.PrintLine("За обедом Ноя выпил таблетки, и, внезапно, проснулся....");
                textPrinter.Wait();

                textPrinter.PrintLine("- Что это было? - спросил герой, только выйдя из сна.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Вы пробыли в коме 3 года. - Ответила медсестра.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Какой ужас, я ведь прожил новую жизнь. - с агрессией заявляет парень.");
                textPrinter.Wait();
                textPrinter.PrintLine("- Нам жаль это слышать, но вы сами впали в кому из-за обильного количества токсинов вызванных таблетками от Амнезии, которые вы ели одну за другой. - Ответила медсестра.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Скорее всего вы умрете через пару часов, так как эффект от таблеток в таком количестве убьет вас. - ответил Старший Врач.");
                textPrinter.Wait();

                textPrinter.PrintLine("Врачи покинули палату и оставили Ноегиса наедине.");
                textPrinter.Wait();

                textPrinter.PrintLine("После ужина он закрыл глаза и ждал своей участи.");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис умер, даже не успев ничего сделать для себя.");
                textPrinter.Wait();

            }
            else
            {
                textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                textPrinter.Wait();

                textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();
            }

            textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
                textPrinter.Wait();

                textPrinter.PrintLine("- Как же тяжело в этот яркий солнечный день все это делать... - Тема");
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
        }
    }
