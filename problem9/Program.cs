using System;

namespace MyApp
{
    class Book
    {
        int Id;
        string Name;
        string Type;
        string Createdon;
        string Price;
        bool IsDeleted;
        int Count;

        public Book(int id)
        {
            Id = id;
            Count = 0;
        }

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
            Count = 0;
        }

        public Book(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
            Count = 0;
        }

        public Book(int id, string name, string type, string createdon)
        {
            Id = id;
            Name = name;
            Type = type;
            Createdon = createdon;
            Count = 0;
        }

        public Book(int id, string name, string type, string createdon, string price)
        {
            Id = id;
            Name = name;
            Type = type;
            Createdon = createdon;
            Price = price;
            Count = 0;
        }

        public void PrintIdName()
        {
            Console.WriteLine($"{Id} - {Name}");
        }

        public void PrintIdNameType()
        {
            Console.WriteLine($"{Id} - {Name} - {Type}");
        }

        public void PrintIdNameTypeCreatedon()
        {
            Console.WriteLine($"{Id} - {Name} - {Type} - {Createdon}");
        }

        public void PrintIdNameTypeCreatedonPrice()
        {
            Console.WriteLine($"{Id} - {Name} - {Type} - {Createdon} - {Price}");
        }

        public bool isDeleted()
        {
            if(IsDeleted)
            {
                    return true;
            }
            else
            {
                return false;
            }
        }

        public void count()
        {
            Count++;
        }

        public void printcount()
        {
            Console.WriteLine($"{Count}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "1919");
            Book book2 = new Book(2, "blue elephant", "scaring");
            book1.PrintIdName();
            book2.PrintIdNameType();
            book1.count();
            book2.count();
            book1.printcount();
            book2.printcount();
            Console.WriteLine(book1.isDeleted());
            Console.WriteLine(book2.isDeleted());
            Console.ReadLine();
        }
    }
}