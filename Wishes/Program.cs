namespace Wishes
{
    public class Wishes
    {
        static string[] wishes = new string[] { "Счастья и здоровья!", "Отличного настроения!", "Достатка!", "Семейного благополучия!",
                                              "Удачи!", "Уюта и тепла дома!", "Грандиозных успехов!", "Пусть желания сбываются!",
                                              "Лёгкости на сердце, тепла на душе!", "Светлых идей!", "Позитивного настроя!" };
        public static void GetWish()
        {
            Console.Clear();
            Random r = new Random();
            int index = r.Next(wishes.Length);
            Console.Write(wishes[index]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
        }
    }
}