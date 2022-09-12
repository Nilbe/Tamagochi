using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string name = "";
    private int hunger = 0;
    private int boredom = 0;
    private bool isAlive;
    private Random generator;
    private List<string> words = new List<string>() {"was guud"};

    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void printStats()
    {
        Console.WriteLine(name + " is feeling, Hungry: " + hunger + ". Bored: " + boredom);
    }

    public void feed()
    {
        Console.WriteLine("You feed " + name + " hunger has gone down by 3.");

        hunger -= 3;
        if(hunger < 0)
        {
            hunger = 0;
        }
    }

    public void hello()
    {
        int wordNumber = generator.Next(words.Count);

        Console.WriteLine($" {name} says: {words[wordNumber]}");

        boredom -= 1;
        if(boredom < 0)
        {
            boredom = 0;
        }
    }

    public void teach()
    {
        Console.WriteLine("You teached " + name + " a new trick.");

        boredom -= 3;
        if(boredom < 0)
        {
            boredom = 0;
        }
    }

    public void tick()
    {
        hunger ++;
        boredom ++;

        if(hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public bool revive()
    {
        return isAlive;
    }
}