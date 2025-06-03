using System;

namespace Otus.Generics.Demo
{
    // Два обобщенных типа TKey и TValue
    class MyKeyValue<TKey, TValue>
    {
        public MyKeyValue(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public override string ToString()
        => $"Key={Key}, Value={Value}";
    }


    public class MultipleGenericDemo : IBaseDemo
    {
        public void Show()
        {
            var kv1 = new MyKeyValue<int, string>(1, "Hello");
            var kv2 = new MyKeyValue<float, bool>(1f, false);
            var kv3 = new MyKeyValue<double, bool>(2, false);
            var kv4 = new MyKeyValue<object, object>(1f, false);

            Console.WriteLine(kv1);
            Console.WriteLine(kv2);
            Console.WriteLine(kv3);
            Console.WriteLine(kv4);

        }
    }
}