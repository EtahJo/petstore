using System;
using System.Collections.Generic;

namespace PetStore
{
    abstract class Pet
    {
        public string Name { get; private set; }

        public Pet(string name)
        {
            Name = name;
        }

        public abstract void Display();
        public abstract void DisplayMore();
        public abstract int CalculateAge(int humanYears);
        public abstract void Speaking(bool makingSound);
    }

    class Dog : Pet
    {
       

        public Dog(string name):base(name)
        {
           
        }
        public override int CalculateAge(int humanYears)
        {
            return (2*humanYears)/9;
        }

        public override void DisplayMore()
        {
            Console.Write("How many human years? ");
            int age = CalculateAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("This is a dog called {0} and it is {1} years old",Name,age);
        }
        public override void Display()
        {
            Console.WriteLine("A dog called {0}", Name);
        }

        public override void Speaking(bool makingSound)
        {
            if (makingSound)
                Console.WriteLine("The dog is barking");
            else Console.WriteLine("The dog is silent");
        }
    }

    class Cat : Pet
    {
      

        public Cat(string name):base(name)
        {
            
        }
        public override int CalculateAge(int humanYears)
        {
            return 15 * humanYears;
        }
        public override void Display()
        {
            Console.WriteLine("A cat called {0}", Name);
        }
        public override void DisplayMore()
        {
            Console.Write("How many human years? ");
            int age = CalculateAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("This is a cat called {0} and it is {1} years old", Name, age);
        }

        public override void Speaking(bool makingSound)
        {
            if (makingSound)
                Console.WriteLine("The cat says meow");
            else Console.WriteLine("The cat is silent");
        }
    }

    class Parrot : Pet
    {
       

        public Parrot(string name):base(name)
        {
           
        }
        public override int CalculateAge(int humanYears)
        {
            return 2 * humanYears;
        }
        public override void Display()
        {
            Console.WriteLine("A parrot called {0}", Name);
        }
        public override void DisplayMore()
        {
            Console.Write("How many human years? ");
            int age = CalculateAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("This is a parrot called {0} and it is {1} years old", Name, age);
        }

        public override void Speaking(bool makingSound)
        {
            if (makingSound)
                Console.WriteLine("The parrot is talking");
            else Console.WriteLine("The parrot is silent");
        }
    }

    class Lion : Pet
    {public string Name { get; private set; }

        public Lion(string name):base(name)
        {
       
        }
        public override int CalculateAge(int humanYears)
        {
            return (19 * humanYears) / 75;
        }
        public override void Display()
        {
            Console.WriteLine("A lion called {0}", Name);
        }

        public override void DisplayMore()
        {
            Console.Write("How many human years? ");
            int age = CalculateAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("This is a lion called {0} and it is {1} years old", Name, age);
        }

        public override void Speaking(bool makingSound)
        {
            if (makingSound)
                Console.WriteLine("The lion is roaring");
            else Console.WriteLine("The lion is silent");
        }
    }

    class Program
    {
        static void Main() { 

            List<Pet> pets = new List<Pet>();
            bool addingPet = true;
            while (addingPet)
            {

                Console.WriteLine("[1]- Dog");
                Console.WriteLine("[2]- Cat");
                Console.WriteLine("[3]- Parrot");
                Console.WriteLine("[4]- Lion");
                Console.WriteLine("Add a pet to the list");
                string petChoice = Console.ReadLine();
                if(petChoice != "")
                {
                    if (petChoice == "1")
                    {
                        Console.WriteLine("Name your dog");
                        string petName = Console.ReadLine();
                        pets.Add(new Dog(petName));
                    }
                    else if (petChoice == "2")
                    {
                        Console.WriteLine("Name your cat");
                        string petName = Console.ReadLine();
                        pets.Add(new Cat(petName));
                    }
                    else if (petChoice == "3")
                    {
                        Console.WriteLine("Name your parrot");
                        string petName = Console.ReadLine();
                        pets.Add(new Parrot(petName));
                    }
                    else 
                    {
                       
                            Console.WriteLine("Name your Lion");
                            string petName = Console.ReadLine();
                            pets.Add(new Dog(petName));
                        
                    }
                }
                else
                {
                    addingPet = false;
                }
            }
            Console.WriteLine("Your list of pets ");

            for (int i = 0; i < pets.Count; i++)
            {
                Console.Write("[{0}] -", i);
                pets[i].Display();
            }

            Console.WriteLine("Select a pet to take on a walk ");

            int petSelected;

            if (int.TryParse(Console.ReadLine(), out petSelected))
            {
               if(petSelected<pets.Count && petSelected >= 0)
                {
                    pets[petSelected].Display();
                    pets[petSelected].Speaking(true);
                }
            }

            Console.ReadKey();
           

        }
    }
}