class MainClass
{
    public static void Main(string[] args)
    {
        
     (string name, int age, string type) Pet; 

     Console.Write("Напишите имя питомца: ");
     Pet.name = Console.ReadLine();
     Console.Write("Напишите возраст питомца (Цифрами): ");
     Pet.age =Convert.ToInt32(Console.ReadLine());
     Console.Write("Напишите кто ваш питомец(собака,кошка и тд.): ");
     Pet.type = Console.ReadLine();

     Console.WriteLine("Имя питомца {0}", Pet.name);
     Console.WriteLine("Возраст питомца {0} ", Pet.age);
     Console.WriteLine("Тип питомца {0}", Pet.type);

     Console.ReadKey();
    }
}   