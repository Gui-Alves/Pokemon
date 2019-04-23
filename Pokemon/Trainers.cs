using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainers
    {
        private int nome;

        private List<Pokemons> pokemons;

        internal List<Pokemons>  Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public int Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}
