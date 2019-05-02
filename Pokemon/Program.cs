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
            int[] battlePokemon = new int[2];
            bool battle= true;

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
           
            while (battle)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Pokemons de {t[0].Nome}:");
                    t[0].Pokemons.ForEach(p => Console.WriteLine($"{t[0].Pokemons.IndexOf(p) + 1} - {p.Nome,-13} | Dano: {p.Dano,-2} | Def: {p.Defesa,-2} | Vida: {p.Vida}"));
                    Console.WriteLine();
                    Console.WriteLine($"Pokemons de {t[1].Nome}:");
                    t[1].Pokemons.ForEach(p => Console.WriteLine($"{t[1].Pokemons.IndexOf(p) + 1} - {p.Nome,-13} | Dano: {p.Dano,-2} | Def: {p.Defesa,-2} | Vida: {p.Vida}"));
                    Console.WriteLine();
                    Console.WriteLine($"{t[i % 2].Nome}, escolha um pokemon para batalhar:");
                    battlePokemon[i % 2] = Convert.ToInt32(Console.ReadLine()) -1;
                }

                Console.WriteLine($"{t[0].Pokemons[battlePokemon[0]].Nome} \n   VS\n{t[1].Pokemons[battlePokemon[1]].Nome} \n\n");

                if (t[0].Pokemons[battlePokemon[0]].Dano > t[1].Pokemons[battlePokemon[1]].Defesa)
                {
                    t[1].Pokemons[battlePokemon[1]].Vida -= t[0].Pokemons[battlePokemon[0]].Dano - t[1].Pokemons[battlePokemon[1]].Defesa;
                    Console.WriteLine($"{t[0].Pokemons[battlePokemon[0]].Nome} acerta o ataque!");
                }
                if (t[1].Pokemons[battlePokemon[1]].Dano > t[0].Pokemons[battlePokemon[0]].Defesa)
                {
                    t[0].Pokemons[battlePokemon[0]].Vida -= t[1].Pokemons[battlePokemon[1]].Dano - t[0].Pokemons[battlePokemon[0]].Defesa;
                    Console.WriteLine($"{t[1].Pokemons[battlePokemon[1]].Nome} acerta o ataque!");
                }

                if (t[0].Pokemons[battlePokemon[0]].Vida <= 0)
                {
                    Console.WriteLine($"{t[0].Pokemons[battlePokemon[0]].Nome} está fora de combate!");
                    t[0].Pokemons.RemoveAt(battlePokemon[0]);
                }

                if (t[1].Pokemons[battlePokemon[1]].Vida <= 0)
                {
                    Console.WriteLine($"{t[1].Pokemons[battlePokemon[1]].Nome} está fora de combate!");
                    t[1].Pokemons.RemoveAt(battlePokemon[1]);
                }
                Console.ReadKey();
                Console.Clear();
                if (!t[0].Pokemons.Any())
                {
                    Console.WriteLine($"{t[1].Nome} venceu a partida!");
                    battle = false;
                }

                if (!t[1].Pokemons.Any())
                {
                    Console.WriteLine($"{t[0].Nome} venceu a partida!");
                    battle = false;
                }
                Console.ReadKey();
            }
            Console.ReadKey();


        }

        static void prepararPokemons()
        {
            pokemons = new List<Pokemons>();
            pokemons.Add(new Pokemons() { Nome = "Girastar", Dano = 40, Defesa = 20, Vida = 200 });
            pokemons.Add(new Pokemons() { Nome = "Salazel", Dano = 35, Defesa = 25, Vida = 150 });
            pokemons.Add(new Pokemons() { Nome = "Weaseon", Dano = 50, Defesa = 10, Vida = 200 });
            pokemons.Add(new Pokemons() { Nome = "Vulteon", Dano = 40, Defesa = 15, Vida = 450 });
            pokemons.Add(new Pokemons() { Nome = "Flamevark", Dano = 70, Defesa = 18, Vida = 200 });
            pokemons.Add(new Pokemons() { Nome = "Chimetile", Dano = 55, Defesa = 35, Vida = 150 });
            pokemons.Add(new Pokemons() { Nome = "Terramander", Dano = 70, Defesa = 10, Vida = 210 });
            pokemons.Add(new Pokemons() { Nome = "Ironeon", Dano = 90, Defesa = 5, Vida = 500 });
            pokemons.Add(new Pokemons() { Nome = "Alpaking", Dano = 30, Defesa = 20, Vida = 1000 });
            pokemons.Add(new Pokemons() { Nome = "Leopanther", Dano = 30, Defesa = 30, Vida = 300 });
        }
    }
}
