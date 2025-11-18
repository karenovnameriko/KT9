//3.Напишите обобщенный класс Calculator<T>, который имеет статический метод
//T Add(T x, T y), который возвращает сумму двух значений типа T. Затем напишите
//ограничение для этого класса, чтобы он мог работать только с типами, которые
//имеют parameterless конструктор (new()). Затем напишите метод T Zero(), который
//возвращает нулевое значение типа T с помощью parameterless конструктора.
namespace KT9_3;

class Program
{
    public class Calculator<T> where T: new()
    {
        public static T Add(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        public static T Zero()
        {
            return new T();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Сложение int: {Calculator<int>.Add(5, 3)}");
        Console.WriteLine($"Нулевое значение int: {Calculator<int>.Zero()}");
        Console.WriteLine($"Сложение double: {Calculator<double>.Add(2.5, 1.5)}");
        Console.WriteLine($"Нулевое значение double: {Calculator<double>.Zero()}"); 
        Console.WriteLine($"Сложение decimal: {Calculator<decimal>.Add(10.5m, 20.3m)}");
        Console.WriteLine($"Нулевое значение decimal: {Calculator<decimal>.Zero()}");

    }
}

