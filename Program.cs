Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog();
myDog._name = "Good Boy";

Dog neighboursDog = new Dog();
neighboursDog._name = "Good Girl";

Console.WriteLine($"My dogs name is {myDog._name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog._name}.");
Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappiness !=5)
{
myDog.Bark();
}

myDog.WagTail();

class Dog
{
    public string _name = "Koer";
    public int _levelOfHappiness = 0;  
    
    public Dog(string name)
    { 
        _name = name;
        _levelOfHappiness = 0;
    }
    public string Name
    { get
        { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    { 
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    { Console.WriteLine("Woof-woof!")
            _levelOfHappiness++;
    }

    public void WagTail()
    { 
        Console.WriteLine("Wiggle-wiggle!");
    }

}
