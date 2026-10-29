namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите первое число: ");
            int с = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {a + b}");
            Console.WriteLine($"Разность: {a - b}");
            Console.WriteLine($"Произведение: {a * b}");

            double avg = (double)(a + b+с) / 3;
            Console.WriteLine($"Среднее арифметическое: {avg:F2}");
        }
    }
}