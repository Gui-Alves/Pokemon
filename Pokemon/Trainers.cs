using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainers
    {
        private string nome;

        private List<Pokemons> pokemons;

        internal List<Pokemons>  Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}
