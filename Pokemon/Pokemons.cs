using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemons
    {
        private string nome;
        private int dano;
        private int defesa;
        private int vida;
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int Defesa
        {
            get { return defesa; }
            set { defesa = value; }
        }
        public int Dano
        {
            get { return dano; }
            set { dano = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}
