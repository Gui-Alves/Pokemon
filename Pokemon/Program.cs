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
        
        static void Main(string[] args)
        {
            List<Pokemons> escolha1 = new List<Pokemons>();
            List<Pokemons> escolha2 = new List<Pokemons>();
            List<Trainers> t = new List<Trainers>();
            Trainers p1 = new Trainers();
            Trainers p2 = new Trainers();
            t.Add(p1); t.Add(p2);
            int resp;

            prepararPokemons();
            Console.WriteLine("Digite o nome do jogador 1:");
            t[0].Nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador 2:");
            t[1].Nome = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 6; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine($"Pokemons de {t[0].Nome}:");
                    t[0].Pokemons.ForEach(p => Console.WriteLine($"{p.Nome}"));
                    Console.WriteLine();
                    if (i > 1)
                    {
                        Console.WriteLine($"Pokemons de {t[1].Nome}:");
                        t[1].Pokemons.ForEach(p => Console.WriteLine($"{p.Nome}"));
                        Console.WriteLine();
                    }
                }
                Console.WriteLine($"{t[i % 2].Nome}, escolha um pokemon: ");
                pokemons.ForEach(p => Console.WriteLine($"{pokemons.IndexOf(p) + 1,-2}- {p.Nome,-13} | Dano: {p.Dano,-2} | Def: {p.Defesa,-2} | Vida: {p.Vida}"));
                resp = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    escolha1.Add(pokemons[resp - 1]);
                    t[0].Pokemons = escolha1;
                }
                else
                {
                    escolha2.Add(pokemons[resp - 1]);
                    t[1].Pokemons = escolha2;
                }

                pokemons.Remove(pokemons[resp - 1]);
                
                Console.Clear();
            }
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
