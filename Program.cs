using System;

namespace inheritanceandpolymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whisker=new Animal()
            {
                Name="Wisker",
                Sound="Maoy"
            };
            Dog grover=new Dog()
            {
                Name="Grover",
                Sound="Woof",
                Sound2="Grrrr"
            };
            grover.Sound="Wooof";
            whisker.MakeSound();
            grover.MakeSound();
            whisker.SetAnimalIDInfo(1234,"Ernasi");
            grover.SetAnimalIDInfo(12345,"Greta");
            whisker.GetAnimalIdInfo();
            grover.GetAnimalIdInfo();
            Console.ReadKey();

        }
    }
}
