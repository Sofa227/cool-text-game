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
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@%(((((#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@((((((((((((&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@((((((((((((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@((((((((((((%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@(((((((@(((((((((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@(((((((@@@@@@(((((((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@((((((#@@@@@@@@@((((((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@((((((@@@@@@@@@@@@#((((((&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@%((((((@@@@@@@@@@@@@@((((((@@@@@@@@@@@@@@@@@@@@@@@&((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@%(((((@@@@@@@@@@@@@@@&(((((@@@@@#@@@@@@@@@@@@@@@@@%(((%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@#(((((@@@@@@@@@@@@@@@@(((((@@@(((((@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@(((((@@@@@@@@@@@@@@@@(((((@@@%((((((#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#@@@@@@((((((%@@@@\r\n@@@@@@@(((((@@@@@@@@@@@@@@&((((%@@@%((((((((((@@@@@@@@@@@(((@@@@@@@@@@(((#@@@@@@((#@@@#((((#(((@@@@@\r\n@@@@@@@(((((@@@@@@@@@@@@@(((((@@@&(((&@@@@((((((@@@@@@(((((((@@@@@@@@((((&@@@@@(((@@@(((#%(((@@@@@@@\r\n@@@@@@@((((@@@@@@@@@@@@(((((@@@((((%@@@@@@((((&@@@@((((((((((&@@@@@((((((&@@@@(((@@@(((((#@@@@@@@@@@\r\n@@@@@@@(((#@@@@@@@@#((((((@&(((((#@@@@@@@((((%@@(((((@@@@(((((%@(((((((((@@@%((#@@@@((((@@@@@@&((&@@\r\n@@@@@@@((@@@@((((((((((@@@@@(((#@@@@@@@@%((((((((#@@@@@@@@((((((((@@@((((@@(((@@@@@@&((((((((((@@@@@\r\n@@@@@@@@@(((((((((((@@@@@@@@@@@@@@@@@@@@(((((@@@@@@@@@@@@@@@@@@@@@@@@%((((((@@@@@@@@@@@@#@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#(((@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n");
            textPrinter.Wait();

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

                Console.WriteLine("Конец истории. Спасибо вам за игру!!! Нажмите любую клавишу для выхода.");
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

                //Выбор2
                if (textPrinter.ChooseOption("Пойти на спортплощадку", "Пройти в жилой корпус номер 3"))
                {
                    textPrinter.PrintLine("Вы выбрали пойти на спортплощадку.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Пройдя туда ноегис увидел тренажеры и турнички, после этого он пойшел дальше.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Ноегис решил направиться в в жилой корпус номер 3");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Пройдя, наш герой наконец то увидел людей, человек 20 собрались в холе и о чем то разговаривали.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Подойдя к людям Ноегис смог увидеть потенциальных одногрупников(ребята были практически одного возраста, поэтому он так и подумал), а также главных управленцев и охранников лагеря.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здравствуйте! - говорит ноегис.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здравствуйте, Ноегис Иванович! - отвечает директор лагеря и продолжает: - Ну коллеги, вопрос мы решили, до скорого!");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Директор и управленцы ушли и ребята остались одни с чуваком на ресепшене.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Привет, Ноегис, я Ваня, с тобой в отряде буду. Сговоримся, пообщаемся, как расселят. - Ответил Иван Денисович.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Йоу, я Серега. Приятно познакомится.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Прив, я Тема, самый первый сюда приехал.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здарова, broski, я Глеб, можешь жеско вайбовать с нами, мы нормальные поцы. ");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Спасибо ребят, очень приятно с вами познакомится. Но вас здесь только 4? - спросил Ноегис.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Нет, конечно броу, другие челики пошли расселяться, мы просто ждем своей очереди. Будешь за нами ес чо. - сказал Глеб. ");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Понял, спасибо. - ответил Ноегис.");
                    textPrinter.Wait();
                    
                    if (textPrinter.ChooseOption("Пойти на 2 этаж посмотреть что там", "Посмотреть телефон, мб там что то новое"))
                    {

                        textPrinter.PrintLine("Вы выбрали пойти на второй этаж.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("На втором этаже хол, практически такой же как на 1 этаже, достаточно солидно выглядит, а еще сидят две цыпочки.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис вернулся на первй этаж и взял ключи от комнаты у коменданта.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Гг пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Заходит Ваня и говорит: - эй, соня, ты так весь день проспишь, пошли на речку.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис быстро пришел в себя и сказал: - Буквально пару минут и я подойду в хол.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Окей - сказал Иван и вышел из комнаты.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Парень вышел из комнаты и пошел в хол. Встретил 4 ребят и они вместе вышли из корпуса.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ребята сказали, что они знают куда идти и Ноегису нужно проследовать за ними. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Придя на речку они увидели еще несколько человек, подошли поздороваться.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Здарова, парни, я Андрей!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Ку, я Мишус!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Меня зовут Артур, а это Леша!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Привет , Привет! - сказал Леша.");
                        textPrinter.Wait();

                        if (textPrinter.ChooseOption("Остаться поболтать с новыми челиками", "Пойти покупаться в тепленькой речке"))
                        {

                            textPrinter.PrintLine("Вы выбрали поболтать с новыми челиками.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Как ты? откуда ты будешь? - спросил Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Я с Компорово, рядом с Тверью. - ответил Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Круто, я из Ивантеевки! - Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }


                        }
                        else
                        {
                            textPrinter.PrintLine("Вы выбрали пойти покупаться в тепленькой речке.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Йоу, какая вода хорошая, тут очень классно. - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- А ведь мы тебе говорили. - Ванек");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }
                        }
                    }
                    else 
                    {

                        textPrinter.PrintLine("Вы выбрали проверить телефон");
                        textPrinter.Wait();

                        textPrinter.PrintLine(">Уведомление от мамы: Привет, сынуля. Как твои дела? Молодец что поехал в санаторий, надеюсь там тебе будет получше. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine(">Ответить маме: спасибо, мамуль. Думаю, что все будет хорошо. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис взял ключи от комнаты у коменданта.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Гг пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Заходит Ваня и говорит: - эй, соня, ты так весь день проспишь, пошли на речку.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис быстро пришел в себя и сказал: - Буквально пару минут и я подойду в хол.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Окей - сказал Иван и вышел из комнаты.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Парень вышел из комнаты и пошел в хол. Встретил 4 ребят и они вместе вышли из корпуса.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ребята сказали, что они знают куда идти и Ноегису нужно проследовать за ними. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Придя на речку они увидели еще несколько человек, подошли поздороваться.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Здарова, парни, я Андрей!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Ку, я Мишус!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Меня зовут Артур, а это Леша!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Привет , Привет! - сказал Леша.");
                        textPrinter.Wait();

                        if (textPrinter.ChooseOption("Остаться поболтать с новыми челиками", "Пойти покупаться в тепленькой речке"))
                        {

                            textPrinter.PrintLine("Вы выбрали поболтать с новыми челиками.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Как ты? откуда ты будешь? - спросил Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Я с Компорово, рядом с Тверью. - ответил Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Круто, я из Ивантеевки! - Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }


                        }
                        else
                        {
                            textPrinter.PrintLine("Вы выбрали пойти покупаться в тепленькой речке.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Йоу, какая вода хорошая, тут очень классно. - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- А ведь мы тебе говорили. - Ванек");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }
                        }


                    }
                }
                else
                {
                    textPrinter.PrintLine("Вы выбрали пройти в жилой корпус номер 3");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Пройдя, наш герой наконец то увидел людей, человек 20 собрались в холе и о чем то разговаривали.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Подойдя к людям Ноегис смог увидеть потенциальных одногрупников(ребята были практически одного возраста, поэтому он так и подумал), а также главных управленцев и охранников лагеря.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здравствуйте! - говорит ноегис.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здравствуйте, Ноегис Иванович! - отвечает директор лагеря и продолжает: - Ну коллеги, вопрос мы решили, до скорого!");
                    textPrinter.Wait();

                    textPrinter.PrintLine("Директор и управленцы ушли и ребята остались одни с чуваком на ресепшене.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Привет, Ноегис, я Ваня, с тобой в отряде буду. Сговоримся, пообщаемся, как расселят. - Ответил Иван Денисович.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Йоу, я Серега. Приятно познакомится.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Прив, я Тема, самый первый сюда приехал.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Здарова, broski, я Глеб, можешь жеско вайбовать с нами, мы нормальные поцы. ");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Спасибо ребят, очень приятно с вами познакомится. Но вас здесь только 4? - спросил Ноегис.");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Нет, конечно броу, другие челики пошли расселяться, мы просто ждем своей очереди. Будешь за нами ес чо. - сказал Глеб. ");
                    textPrinter.Wait();

                    textPrinter.PrintLine("- Понял, спасибо. - ответил Ноегис.");
                    textPrinter.Wait();

                    if (textPrinter.ChooseOption("Пойти на 2 этаж посмотреть что там", "Посмотреть телефон, мб там что то новое"))
                    {

                        textPrinter.PrintLine("Вы выбрали пойти на второй этаж.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("На втором этаже хол, практически такой же как на 1 этаже, достаточно солидно выглядит, а еще сидят две цыпочки.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис вернулся на первй этаж и взял ключи от комнаты у коменданта.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Гг пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Заходит Ваня и говорит: - эй, соня, ты так весь день проспишь, пошли на речку.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис быстро пришел в себя и сказал: - Буквально пару минут и я подойду в хол.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Окей - сказал Иван и вышел из комнаты.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Парень вышел из комнаты и пошел в хол. Встретил 4 ребят и они вместе вышли из корпуса.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ребята сказали, что они знают куда идти и Ноегису нужно проследовать за ними. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Придя на речку они увидели еще несколько человек, подошли поздороваться.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Здарова, парни, я Андрей!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Ку, я Мишус!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Меня зовут Артур, а это Леша!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Привет , Привет! - сказал Леша.");
                        textPrinter.Wait();

                        if (textPrinter.ChooseOption("Остаться поболтать с новыми челиками", "Пойти покупаться в тепленькой речке"))
                        {

                            textPrinter.PrintLine("Вы выбрали поболтать с новыми челиками.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Как ты? откуда ты будешь? - спросил Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Я с Компорово, рядом с Тверью. - ответил Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Круто, я из Ивантеевки! - Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }


                        }
                        else
                        {
                            textPrinter.PrintLine("Вы выбрали пойти покупаться в тепленькой речке.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Йоу, какая вода хорошая, тут очень классно. - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- А ведь мы тебе говорили. - Ванек");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }
                        }
                    }
                    else 
                    {

                        textPrinter.PrintLine("Вы выбрали проверить телефон");
                        textPrinter.Wait();

                        textPrinter.PrintLine(">Уведомление от мамы: Привет, сынуля. Как твои дела? Молодец что поехал в санаторий, надеюсь там тебе будет получше. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine(">Ответить маме: спасибо, мамуль. Думаю, что все будет хорошо. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис взял ключи от комнаты у коменданта.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Гг пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Заходит Ваня и говорит: - эй, соня, ты так весь день проспишь, пошли на речку.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ноегис быстро пришел в себя и сказал: - Буквально пару минут и я подойду в хол.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Окей - сказал Иван и вышел из комнаты.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Парень вышел из комнаты и пошел в хол. Встретил 4 ребят и они вместе вышли из корпуса.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Ребята сказали, что они знают куда идти и Ноегису нужно проследовать за ними. ");
                        textPrinter.Wait();

                        textPrinter.PrintLine("Придя на речку они увидели еще несколько человек, подошли поздороваться.");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Здарова, парни, я Андрей!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Ку, я Мишус!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Меня зовут Артур, а это Леша!");
                        textPrinter.Wait();

                        textPrinter.PrintLine("- Привет , Привет! - сказал Леша.");
                        textPrinter.Wait();

                        if (textPrinter.ChooseOption("Остаться поболтать с новыми челиками", "Пойти покупаться в тепленькой речке"))
                        {

                            textPrinter.PrintLine("Вы выбрали поболтать с новыми челиками.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Как ты? откуда ты будешь? - спросил Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Я с Компорово, рядом с Тверью. - ответил Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Круто, я из Ивантеевки! - Артур.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }


                        }
                        else
                        {
                            textPrinter.PrintLine("Вы выбрали пойти покупаться в тепленькой речке.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Йоу, какая вода хорошая, тут очень классно. - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- А ведь мы тебе говорили. - Ванек");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Потом ребята пошли домой и отлично побеседовали.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Ладно, Иваныч, до завтра, завтра нам нужно идти заниматься уборкой нашей части. - Ванек.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Нашей? Части? - Ноегис.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Да, нам выдают зону для уборки.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Оке, завтра увидимся.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("Ноегис зашел в комнату и увидел своего соседа, который недавно приехал: - Здрррравствуй, я Василий Муравьедов! - произнес тот сидя на кровати.");
                            textPrinter.Wait();

                            textPrinter.PrintLine("- Привет, Василий!(Гг сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();
                                
                                //Второй день
                            }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("ГГ показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. (нах мне инфа эта).");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

                                //Второй день
                            }
                        }


                    }

                }
            }
        }
    }
