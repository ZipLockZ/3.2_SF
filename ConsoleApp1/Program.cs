class MainClass
{
    public static void Main(string[] args)
    {
        
     var (name,age,dog) =("Иван", 17, "Тёма");

     Console.WriteLine("Моё имя {0}", name);
     Console.WriteLine("Мой возраст {0} ", age);
     Console.WriteLine("Моя собака {0}", dog);

     Console.Write("Напишите ваше имя: ");
     name = Console.ReadLine();
     Console.Write("Напишите ваш возраст (Цифрами): ");
     age =Convert.ToInt32(Console.ReadLine());
     Console.Write("Напишите имя вашей собаки: ");
     dog = Console.ReadLine();

     Console.WriteLine("Ваше имя {0}", name);
     Console.WriteLine("Ваш возраст {0} ", age);
     Console.WriteLine("Ваша собака {0}", dog);

     Console.ReadKey();
    }
}   