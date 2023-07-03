using System;
using System.Security.Cryptography;

namespace ClassExample;

internal class Program
{

    public static class MyInfo
    {
        static MyInfo()
        {

        }

        public static string Info { get; set; }

        public static void Display()
        {

        }
    }


    public class Counter
    {
        static Counter()
        {
            Console.WriteLine("Static counter");
        }

        public static string Value;

        private int _counter;

        public Counter()
        {
            _counter = 0;
        }

        public void Increment()
        {
            var s = Value;
            _counter++;
        }

        public static void ToDo()
        {
            Console.WriteLine(Value);
        }

        public void Decrement()
        {
            _counter--;
        }

        public int Count()
        {
            return _counter;
        }
    }

    static void Main(string[] args)
    {
        Counter.Value = "asdasd";

        var counter = new Counter();

        var counter2 = new Counter();

        Counter.Value = null;

        counter.Increment();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        Console.WriteLine(counter.Count());
        counter.Decrement();
        counter.Decrement();
        Console.WriteLine(counter.Count());


        object obj = new User();

        User admin1 = new Admin(); // upcast

        Admin custed = (Admin)admin1; // downcast

        bool isAdmin = admin1 is Admin;
        if (isAdmin)
        {
            Admin custed1 = (Admin)admin1;
        }

        var admin3 = admin1 as SpecificAdmin;

        if (admin3 != null)
        {

        }

        User s_admin1 = new SpecificAdmin();

        Admin admin2 = new Admin();

        DisplayUser(admin1);
        DisplayUser(s_admin1);
        DisplayUser(admin2);
        DisplayUser(s_admin1);
        DisplayUser(new SpecificAdmin());

        var box1 = new Box(10, "black")
        { 
            Name = "My Box",
            Items = new Item[]
            {
               new Item
               {
                   Name = "Toy"
               },
               new Item
               {
                   Name = "Pencil"
               }
            }
        };

        box1
            .AddSize(999)
            .AddWeight(333);

        box1.MethodDisplay();

        Box box2 = new(33, "red");
        var size = box2._size;
        box2.MethodDisplay();

        var box3 = new Box();
    }

    public static void DisplayUser(User user)
    {
        Console.WriteLine(user.Id);
    }
}
