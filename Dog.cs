using System;
namespace inheritanceandpolymorphysm
{
    public class Dog:Animal
    {
        public string Sound2{get;set;}="Grrr";

    // used new keyword to override inhereted method
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        public Dog(string name="No Name",
        string sound="No Sound",
         string sound2="No sound2"):base(name,sound)
         {
             Sound2=sound2;
         }
        
    }
}