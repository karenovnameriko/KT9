//2.Напишите обобщенный класс Pair<T, U>, который хранит пару значений типов T и U.
//Затем напишите ограничение для этого класса, чтобы он мог работать только с типами,
//которые являются ссылочными типами (class). Затем напишите метод void Swap(), который
//меняет местами значения пары.
namespace KT9_2;

class Program
{
   public class Pair<T, U> where T: class where U: class
   {
        private T _first;
        private U _second;

        public Pair(T first, U second)
        {
            _first = first;
            _second = second;
        }

        public void Swap()
        {
            object tempfirst = _first;
            object tempsecond = _second;
            _first = (T)tempsecond;
            _second = (U)tempfirst;
        }

        public T First => _first;
        public U Second => _second;
    }


    static void Main(string[] args)
    {
        var pair1 = new Pair<string, string>("Hello", "World");
        Console.WriteLine($"До Swap: First = {pair1.First}, Second = {pair1.Second}");
        pair1.Swap();
        Console.WriteLine($"После Swap: First = {pair1.First}, Second = {pair1.Second}");
    }
}

