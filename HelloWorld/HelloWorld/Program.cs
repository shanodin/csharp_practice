using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "Alice";
            //var isWorking = true;
            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //const float Pi = 3.14f;

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int a = 1;
            //byte c = (byte) a;
            //Console.WriteLine(c);

            //var number = "1234";
            //int z = Convert.ToInt32(number);
            //Console.WriteLine(z);

            //try
            //{
            //    var num = "1234";
            //    byte y = Convert.ToByte(num);
            //    Console.WriteLine(y);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("the number couldn't be converted to a byte");
            //}

            //try
            //{
            //    string str = "true";
            //    bool b = Convert.ToBoolean(str);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("couldn't convert!");
            //}

            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a + b);

            //var c = 10;
            //var d = 3;
            //Console.WriteLine((float)a / (float)b);

            var a = 1;
            var b = 2;
            var c = 3;
            //Console.WriteLine(a + b * c);
            //Console.WriteLine((a + b) * c);
            //Console.WriteLine(a > b);
            Console.WriteLine(!(a != b)); //false
            Console.WriteLine(a != b); //true
            Console.WriteLine(c > a && c > b); //true
            Console.WriteLine(c > a && c == b); //false
            Console.WriteLine(c > a || c == b); //true
        }
    }
}
