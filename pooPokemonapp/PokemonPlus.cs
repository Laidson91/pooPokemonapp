﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonapp
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus() : base()
        {
            this.Poder = 0;
        }

        public PokemonPlus(String nome, string descricao, int poder) : base(nome, descricao)
        {
            this.Poder = poder;
        }

        public int Poder { get; set; }


        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do Pokemón: " + this.Nome);
            Console.WriteLine("Descrição do Pokemón: " + this.Descricao);
            Console.WriteLine("Poder: " + this.Poder);
        }
    }
}
