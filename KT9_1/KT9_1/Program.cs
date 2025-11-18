//1.Напишите обобщенный класс Stack<T>, который реализует структуру
//данных стек для хранения элементов типа T. Затем напишите ограничение
//для этого класса, чтобы он мог работать только с типами, которые
//реализуют интерфейс IComparable<T>. Затем напишите метод T Max(),
//который возвращает максимальный элемент стека с помощью интерфейса IComparable<T>.

namespace KT9_1;

class Program
{
    public class Stack<T> where T : IComparable<T>
    {
        private List<T> _items;

        public Stack()
        {
            _items = new List<T>();
        }

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Стек пуст");

            T item = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Стек пуст");

            return _items[_items.Count - 1];
        }

        public bool IsEmpty => _items.Count == 0;
        public int Count => _items.Count;

        public T Max()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Стек пуст");

            T max = _items[0];
            for (int i = 1; i < _items.Count; i++)
            {
                if (_items[i].CompareTo(max) > 0)
                {
                    max = _items[i]; 
                }
            }

            return max;
        }
    }
    static void Main(string[] args)
    {
        Stack<int> stackint = new Stack<int>();
        stackint.Push(10);
        stackint.Push(25);
        stackint.Push(5);
        stackint.Push(40);
        stackint.Push(15);
        Console.WriteLine($"Количество элементов в стеке: {stackint.Count}");
        Console.WriteLine($"Верхний элемент: {stackint.Peek()}");
        Console.WriteLine($"Максимальный элемент: {stackint.Max()}");

        Stack<string> stackstring = new Stack<string>();
        stackstring.Push("apple");
        stackstring.Push("zebra");
        stackstring.Push("banana");
        Console.WriteLine($"\nКоличество элементов в стеке: {stackstring.Count}");
        Console.WriteLine($"Верхний элемент: {stackstring.Peek()}");
        Console.WriteLine($"Максимальная строка: {stackstring.Max()}");

        Stack<double> stackdouble = new Stack<double>();
        stackdouble.Push(3.14);
        stackdouble.Push(2.71);
        stackdouble.Push(1.41);
        Console.WriteLine($"\nКоличество элементов в стеке: {stackdouble.Count}");
        Console.WriteLine($"Верхний элемент: {stackdouble.Peek()}");
        Console.WriteLine($"Максимальное число: {stackdouble.Max()}");
    }
}

