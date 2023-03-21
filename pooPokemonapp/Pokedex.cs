using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonapp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasauro", "pokemon tipo planta", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "lendario psiquico", 94);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "lendario psiquico", 88);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "lendario fantasma", 80);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "pokemon dragão", 74);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "pokemon de metal", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "pokemon de metal", 83);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "pokemon toxico", 68);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "pokemon toxico", 64);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lucario", "lutador lendario wannabe", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mudkip", "pokemon de agua", 40);
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokémon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
                // Pokemon p = this.Pokemons[i];
                // p.ExibirDadosPokemon();               
            }
        }

    }
}
