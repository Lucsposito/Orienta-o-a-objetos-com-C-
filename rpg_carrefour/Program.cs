// See https://aka.ms/new-console-template for more information
using system;
using rpg_carrefour.src.Entities;

class Program
{
    static void Main (string[]args)
    {
        knight hero = new knight('Aros',23,"Knight");
        wizard wizard = new wizard('Jenica',23,"white Wizard");

        Console.WriteLine(hero.Attack());
        Console.WriteLine(wizard.Attack());

    }

}