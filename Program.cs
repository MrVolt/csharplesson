namespace PracticalWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения в формате дд.мм.гггг:");

            bool isCorrectDate;

            do
            {
                string dateAsString = Console.ReadLine();

                try
                {
                    DateOnly dateOnly = DateOnly.Parse(dateAsString);
                    isCorrectDate = true;

                    Console.WriteLine("Месяц: " + dateOnly.Month);
                }
                catch
                {
                    isCorrectDate = false;

                    Console.WriteLine("Ошибка. Попробуйте снова.");
                }
            } while (!isCorrectDate);


            /*
             * while
             * do-while
             * 
             * while (условие) условие - ответ на вопрос да или нет
             * {
             *      код
             * }
             * 
             * 
             * do 
             * {
             *      код
             * }
             * while (условие)
             * 
             * 
             * Бесконечный цикл
             * while (true)
             * {
             *      код
             * }
             */

            /*
             * try-catch - блоки обработки исключений
             * 
             * try 
             * {
             *      //код
             * }         
             * catch (исключение)
             * {
             *      //код
             * }
             * 
             */
        }
    }
}
