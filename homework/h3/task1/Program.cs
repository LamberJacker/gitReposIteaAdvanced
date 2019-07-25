using System;

namespace task1
{
    class Program
    {
        static void Main()
        {
            // Items in game:
            Item it0 = new Item("MantaStyle", 30, 25, 40);
            Item it1 = new Item("BootsOfSpeed", 0, 0, 10);
            Item it2 = new Item("B.F.Sword", 15, 5, 60);
            Item it3 = new Item("Sheen", 20, 4, 30);
            Item it4 = new Item("SandClock", 40, 35, 0);
            
            // Collection of items:
            ItemCollection<Item> bagItems = new ItemCollection<Item>();
            bagItems.Add(it0);
            bagItems.Add(it1);
            bagItems.Add(it2);
            bagItems.Add(it3);
            bagItems.Add(it4);

            // First Phantom:
            PhantomDancer phantomDancer = new PhantomDancer(bagItems);
            phantomDancer.ShowHeroStats();
            Console.WriteLine(phantomDancer.getUltimate());

            // First clone of Phantom:
            PhantomDancer clonePhantomDancer = (PhantomDancer)phantomDancer.Clone();
            clonePhantomDancer.ShowHeroStats();
            Console.WriteLine(clonePhantomDancer.getUltimate());

            // Second clone of Phantom:
            Hero secondPhantomDancer = (PhantomDancer)phantomDancer.Clone();
            secondPhantomDancer.ShowHeroStats();
            Console.WriteLine(secondPhantomDancer.getUltimate());

            // Second clone of Mage:
            Hero antiMage = new AntiMage(bagItems);
            antiMage.ShowHeroStats();
            Console.WriteLine(antiMage.getUltimate());

            PhantomDancer newTryHero = new PhantomDancer(phantomDancer);
            newTryHero.ShowHeroStats();
            Console.WriteLine(clonePhantomDancer.getUltimate());


            Console.ReadKey();
        }
    }
}
