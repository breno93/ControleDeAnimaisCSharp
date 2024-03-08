using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public enum TipoAnimal { Cachorro, Gato, Peixe };
    public class Animal
    {
        public Animal()
        {
			this.Nome = "";
			this.Tipo = TipoAnimal.Peixe;
        }

        public Animal(string nome, TipoAnimal tipo)
        {
			this.Nome = nome;
			this.Tipo = tipo;
        }

        private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private TipoAnimal tipo;

		public TipoAnimal Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


	}
}
