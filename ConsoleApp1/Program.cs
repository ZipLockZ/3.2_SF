class MainClass
{
    public static void Main(string[] args)
    {
     (string Name, string Type, double Age, int NameCount) Pet;

     Console.Write("Напишите имя питомца: ");
     Pet.Name = Console.ReadLine();
     Pet.NameCount = Pet.Name.Length;
     Console.Write("Напишите возраст питомца (Цифрами): ");
     Pet.Age = double.Parse(Console.ReadLine());
     Console.Write("Напишите вид вашего питомца: ");
     Pet.Type = Console.ReadLine();

     Console.WriteLine("Имя питомца {0}", Pet.Name);
     Console.WriteLine("Возраст питомца {0} ", Pet.Age);
     Console.WriteLine("Вид питомца {0}", Pet.Type);
     Console.WriteLine("Сколько символов в имени питомца {0}", Pet.NameCount);

     Console.ReadKey();
    }
}   