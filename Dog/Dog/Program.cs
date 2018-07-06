using System;

namespace Dog
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    class MainClass
    {

        public static void Main(string[] args)
        {
            Dog puppy = new Dog("Remi", "Ellen", 3, Gender.Female);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Ollie", "Mercy", 2, Gender.Male);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    }

    public class Dog
    {
        public Dog(String name, String owner, int age, Gender gender)
        {
            this.age = age;
            this.name = name;
            this.owner = owner;
            this.gender = gender;
        }
        String name;
        String owner;
        int age;
        Gender gender;

        public void bark(int numberOfBarks)
        {
            for (int i = 0; i < numberOfBarks; i++)
            {
                Console.Write("Woof! ");
            }
        }

        public String getTag()
        {
            String tag;
            if (gender == 0 && age < 2)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " year old.";
            }
            else if(gender == 0 && age > 1) {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old.";
            }
            else if(gender != 0 && age < 1) {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " year old.";
            }
            else {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.";
            }
            return tag;
        }
    }
}
