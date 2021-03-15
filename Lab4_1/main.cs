using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"text.txt")) //Чтение из файла
            {
                string text = File.ReadAllText("text.txt"); //Вытаскивание всего текста из файла
                var result = Regex.Replace(text, @"(\b[aoiuey]\w*)\b", //Регулярное выражение которое заменяет маленькую гласную в начале каждого слова на большую
                new MatchEvaluator(match => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(match.ToString())));
                Console.WriteLine(result);
                Console.WriteLine("\n Нажмите любую кнопку для продолжения");
                Console.ReadKey();
            }
        }
    }
}
