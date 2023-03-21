using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o Código do pokemon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    // pegar o pokemon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];

                    // definir o pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];

                    // batalhar
                    Console.WriteLine("Dados dos Pokémons que irão lutar.");
                    Console.WriteLine("Dados do seu Pokémon.");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados do Pokémon do PC.");
                    pPC.ExibirDadosPokemonPlus();
                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Parabens!!! Você ganhou.");
                    }
                    else
                    {
                        Console.WriteLine("Que pena!!!! Você perdeu.");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            //Pokemon p = pokedex.Pokemons[];
            //p.ExibirDadosPokemon();           
        }
        static int Menu()
        {
            Console.WriteLine("Pokémon -- Jogo de batalha");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
