using System;
using System.Linq;

namespace inheritanceandpolymorphysm
{
    public class Animal
    {
        private string name;
        protected string sound;
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        public Animal()
        :this("No name","No sound"){}
        public Animal(String name)
        :this(name,"No sound"){}
        public Animal(string name,string sound)
        {
            Name=name;
            Sound=sound;
        }

        public string Name
        {
             get {return name;}
            set
            {
                if(!value.Any(char.IsDigit))
                {
                    name="No name";
                }
                else
                {
                    name=value;
                }
            }
        }
        public string Sound
        {
             get {return sound;}
            set
            {
                if(value.Length>10)
                {
                    sound="No Sound";
                }
                else
                {
                    sound=value;
                }
            }
        }

    }
}