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

            textPrinter.PrintLine("Дабы почувствовать себя лучше, герой решает отправится в лагерь, чтобы найти друзей.");
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

                        textPrinter.PrintLine("Ноегис пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                        textPrinter.PrintLine("Ноегис пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
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

                            textPrinter.PrintLine("- Привет, Василий!Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                        textPrinter.PrintLine("Ноегис пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                        textPrinter.PrintLine("Ноегис пошел по коридору с вещами, считая комнаты. Увидел свою, открыл, порадовался, прилег, уснул.");
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
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

                            textPrinter.PrintLine("- Привет, Василий!(Ноегис сразу смутился потому что он был похож на ботана)");
                            textPrinter.Wait();

                            if (textPrinter.ChooseOption("Лечь спать", "Пойти помыться"))
                            {
                                textPrinter.PrintLine("Вы выбрали лечь спать.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                            else
                            {
                                textPrinter.PrintLine("Вы выбрали пойти помыться.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- По дороге в душ ноегис встречает Саню.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, я новенький, можешь подсказать где 228 комната. - говорит Саня.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис показывает комнату и они прощаются.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Парень помылся пришел и лег на кровать.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- А вообще я очень люблю прогграмировать. - сказал Вася Муравьедов.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Понятно. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис уснул.");
                                textPrinter.Wait();

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

                                    Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                    Console.ReadKey();
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    textPrinter.PrintLine("Давай, но только на полчасика - ответил Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис взял компик и открыл Visual Studio.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что за проект у вас? - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Мы делаем игру-квест. - Василий");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- О, ну сейчас напишем. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис не заметил, как прошло уже 2 часа и совсем забыл, что его друзья уже разошлись, а также забыл покушать.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Что же я наделал? Все, пока парни. - Ноегис");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Пока, дружище. - Вася Муравьед.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис вламывается в двери к Ваньку, но никого нет.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он сел на пол и упал в отчаяние.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Он никогда не был в таком мраке, с тех пор как умерла его мама.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис встал и пошел на улицу. Обрести покой в этот момент могла принести ему только природа.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис решил закурить сигарету.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Наш герой окончательно бросил веру в себя и достал свой винстон с кнопкой и раскумарился.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис во время кумара задумался, как же хорошо быть программистом и зарабатывать 300 тысяч в секунду.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Сдавшись в этот момент парень говорит");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("- Я буду изучать Python и все возможные библиотеки к нему. Я стану новым Джобсом и открою свой Эпл.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Ноегис ушел в библиотеку на 3 этаж со своим ноутбуком, проигнорировав предложение Егора для продолжения проекта.");
                                    textPrinter.Wait();

                                    textPrinter.PrintLine("Работая в библиотеки, он заметил красивую девушку");
                                    textPrinter.Wait();

                                    if (textPrinter.ChooseOption("Проигнорировать и делать свой крутой проект.", "Подойти, поздороваться."))
                                    {
                                        textPrinter.PrintLine("Ноегис сидел всю ночь и сделал крутой код. ");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Под утро он понимает, что у него никого нет кроме тупого ящика из 0 и 1.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Взгрустнув, он решил пойти прогуляться.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Выйдя из комнаты он вышел на улицу и встречает Ванька.");
                                        textPrinter.Wait();

                                        if (textPrinter.ChooseOption("Заговорить с ним.", "Проигнорировать."))
                                        {
                                            textPrinter.PrintLine("Ноегис решил поговорить с Ваньком");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Привет, прости что я вчера не пришел к ва.... -  Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Бро, не общайся со мной!");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Я знаю что ты вчера программировал вместо того чтобы провести время с пользой, то есть нами.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("На программирование у тебя есть другое время, например во время учебы или когда лежишь в больнице. - злобно перебил его Ванек.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Но я же... - грустно говорит Ноегис");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис упал на пол.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он был обречен.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Его жизнь могла измениться, но он продолжит жить в виртуальном пространстве");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и бесконечно падать.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Будто он дропер.");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            textPrinter.PrintLine("Вы выбрали проигнорировать Ванька.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ванек прошел мимо и даже не бросил взгляд на парня.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис понимает, что он изменился.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Осознавая всю ситуацию");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("он смирился с этой проблемой и продолжал сидеть в комнате с Егором И Василием, занимаясь кодддингом до конца смены лагеря");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("После лагеря Ноегис поехал к себе домой продолжая изучать прогграмирование не выходя из дома месяцами...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Изменившись в облике, он понял, что больше не хочет так жить и старался избавится от этого. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но при любых изменениях в своем графике у героя вылезали Error и 0.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Но...");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Герой очнулся.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он понял, что все это был его шизофренический бред и вымесел, который пришел к нему из-за его болезней.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис изменился, герой понял, что лучше заниматься тем чем нравится.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он сидел ночами и играл в LoL после работы официантом.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("И когда-то его заметила про-команда. ");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Он стал больше тренирроваться");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Выигрывать турниры");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("и в конце концов он смог выиграть главный турнир по LoL.");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("Ноегис в послематчевом интервью сказал:");
                                            textPrinter.Wait();

                                            textPrinter.PrintLine("- Cпасибо богу, что я не стал программистом...");
                                            textPrinter.Wait();

                                            Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        textPrinter.PrintLine("Ноегис решил подойти к девушке");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Привет, как тебя зовут? - Ноегис");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Аня, ты кто? - с удивлением узнала Анна");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Я Ноегис, приехал недавно сюда. - сказал он");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Это круто, я тут совсем никого не знаю, поэтому спасибо что подошел познакомиться. - Сказала Аня мило смотря на него.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("- Тогда пойдем погуляем? - ласково заявил Ноя");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Разговаривая о жизни, они нашли общие увлечения");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После первой встречи наш Ноегис постоянно думал о ней.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("После лагеря они переехали в новую квартиру, завели собаку");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Ной, именно так называла его Аня, стал работать строителем и зарабатывать деньги");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Аня была известным дизайнером.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Вместе они накопили на свадьбу и отпраздновали ее в Евпатории.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Жили они долго и счастливо, пока не умерли в один день...");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("К сожалению, наш герой и скончался в той коме, где была эта великолепная история.");
                                        textPrinter.Wait();

                                        textPrinter.PrintLine("Он прожил шикарную жизнь, жаль, что во сне...");
                                        textPrinter.Wait();

                                        Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                textPrinter.PrintLine("- Зачем мне чистить зубы сейчас, если я буду кушать? - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Придя в столовую, Ноя увидел шведский стол.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Вау, щас покушаю мюсли и яички. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, дружище, тут очень вкусно набирай побольше. - Саня Короткий.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Спасибо бро, давай вместе сядем. - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Мы сидим за тем столиком, подходи.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ноегис набрал еды и пошел к ним.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет всем! - Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("С ним поздоровались знакомые Саши: Женя, Гоша, Артем.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Покушали и разошлись по комнатам.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Зашел, Ванек в комнату. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Привет, через 30 минут идем убираться - сказал Ваня");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Хорошо бро. - сказал Ноегис");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Все 30 минут ноегис играл в лол");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Проиграв все игры, Ноя вышел в хол и стал ждать друзей.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После уборки они пошли в дк на фильм \"Барби\".");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Какой классный фильм! - Сказал Глеб");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Это факты! - ответил Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Когда фильм закончился, ребята шли на ужин и обсуждали его. ");
                                textPrinter.Wait();

                                textPrinter.PrintLine("После ужина они купили мороженое в холе и пошли к речке.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Все-таки хорошие вы ребята. - добро сказал Ноя.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("- Обращайся, броу. - Ответил Ванек.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Они проводили много времени вместе, веселились, придумывали различные занятия.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Но всему приходит конец, они разъехались по городам, но не теряли связь.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("Ребята работали на заводах и копили на перелет в Испанию.");
                                textPrinter.Wait();

                                textPrinter.PrintLine("В 60 лет они купили дом на берегу Валенсии и прожили там оставшуюся жизнь.");
                                textPrinter.Wait();


                                Console.WriteLine("Конец истории. Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                        }


                    }

                }
            }
        }
    }
