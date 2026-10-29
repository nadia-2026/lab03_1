namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод первого числа
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            // Ввод второго числа
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            // Вывод результатов
            Console.WriteLine($"Сумма: {a + b}");
            Console.WriteLine($"Разность: {a - b}");
            Console.WriteLine($"Произведение: {a * b}");

            // Среднее арифметическое должно быть с дробной частью, поэтому используем double
            double avg = (double)(a + b) / 2;
            Console.WriteLine($"Среднее арифметическое: {avg}");
        }
    }
}