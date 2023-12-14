using System;

namespace Otus.Generics.Demo
{
    public class GenericType<T>
    {
        private T val;

        public GenericType(T v)
        => val = v;

        public void PrintMe()
        => Console.WriteLine($"I'm '{val}' and my type is '{typeof(T)}'");

        public void PrintMeType<K>(K v)
        => Console.WriteLine($"2. I'm '{v}' and my type is '{v.GetType()}'");
    }

    public class GenericDemo : IBaseDemo
    {
        public void Show()
        {

            // При создании объекта - указываем тип в '<>'
            var intGeneric = new GenericType<int>(2);
            intGeneric.PrintMe();

            var stringGeneric = new GenericType<string>("hello");
            stringGeneric.PrintMe();

            Console.WriteLine();

            stringGeneric.PrintMeType(2.0);

            // Можем явно указывать тип
            stringGeneric.PrintMeType(false);

            // Если тип выводится - может тип <bool> не указывать
            stringGeneric.PrintMeType(false);


            Console.WriteLine();

            // Перечисления тоже разделяются по типам
            stringGeneric.PrintMeType(E1.A);
            stringGeneric.PrintMeType(E2.A);
        }
    }
}