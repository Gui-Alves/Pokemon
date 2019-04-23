using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        private static List<Pokemons> pokemons;
        private static List<Trainers> p1;
        private static List<Trainers> p2;
        static void Main(string[] args)
        {
            prepararPokemons();
            Console.WriteLine("mudança");
            pokemons.ForEach(p => Console.WriteLine($"{pokemons.IndexOf(p)+1} - {p.Nome} | Dano: {p.Dano} | Def: {p.Defesa} | Vida: {p.Vida}") );
            Console.ReadKey();
        }

        static void prepararPokemons()
        {
            pokemons = new List<Pokemons>();
            pokemons.Add(new Pokemons() { Nome = "Girastar", Dano = 20, Defesa = 20, Vida = 20 });
            pokemons.Add(new Pokemons() { Nome = "Salazel", Dano = 35, Defesa = 10, Vida = 15 });
            pokemons.Add(new Pokemons() { Nome = "Weaseon", Dano = 5, Defesa = 35, Vida = 20 });
            pokemons.Add(new Pokemons() { Nome = "Vulteon", Dano = 10, Defesa = 5, Vida = 45 });
            pokemons.Add(new Pokemons() { Nome = "Flamevark", Dano = 22, Defesa = 18, Vida = 20 });
            pokemons.Add(new Pokemons() { Nome = "Chimetile", Dano = 25, Defesa = 20, Vida = 15 });
            pokemons.Add(new Pokemons() { Nome = "Terramander", Dano = 19, Defesa = 20, Vida = 21 });
            pokemons.Add(new Pokemons() { Nome = "Ironeon", Dano = 1, Defesa = 9, Vida = 50 });
            pokemons.Add(new Pokemons() { Nome = "Alpaking", Dano = 40, Defesa = 20, Vida = 10 });
            pokemons.Add(new Pokemons() { Nome = "Leopanther", Dano = 29, Defesa = 1, Vida = 30 });
        }
    }
}
