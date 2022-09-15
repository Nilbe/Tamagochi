Tamagotchi tama = new Tamagotchi();

Console.WriteLine("Name your Tamagotchi");
tama.name = Console.ReadLine();

Console.WriteLine("Hello " + tama.name);

while(tama.revive() == true)
{
    Console.Clear();
    tama.printStats();

    Console.WriteLine("What do you what to do with " + tama.name + "?");
    Console.WriteLine("1. Feed " + tama.name);
    Console.WriteLine("2. Talk to " + tama.name);
    Console.WriteLine("3. Teach " + tama.name + " a new trick");
    Console.WriteLine("4. Do nothig with  " + tama.name);

    string action = Console.ReadLine();

    if(action == "1")
    {   
        tama.feed();
    }
    if(action == "2")
    {
        tama.hello();
    }
    if(action == "3")
    {
        tama.teach();
    }
    if(action == "4")
    {
        Console.WriteLine("You did nothing");
    }
    Console.WriteLine("Press ENTER to continue");

    Console.ReadLine();
    
    tama.tick();
}

Console.WriteLine(tama.name + " died");

Console.ReadLine();