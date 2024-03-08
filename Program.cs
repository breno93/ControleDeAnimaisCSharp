using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação dos objetos para representar os animais
            Animal a;
            int tl = 0;
            Animal[] animais = new Animal[10]; 

            //CONTADORES DOS ANIMAIS            
            int tlCachorro = 0;
            int tlGato = 0;
            int tlPeixe = 0;
            int tipoAnimal = 0; 

            Console.WriteLine("CONTROLE DE ANIMAIS");

            //Leitura da quantidade de animais
            try
            {
                while (true)
                {
                    Console.Write("Quantos animais deseja cadastrar? (máximo 10): ");
                    tl = Convert.ToInt32(Console.ReadLine());

                    if (tl > 10)
                    {
                        Console.WriteLine("\nSó é possível cadastrar no máximo 10 animais, tecle ENTER para prosseguir ou ESC para sair.");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            continue;
                        }
                    }
                    break;
                }
            }
            catch
            {
                tl = 0;
            }

            for (int i = 0; i < tl; i++)
            {
                //Leitura do animal
                a = new Animal();
                Console.Write("Informe o nome do "+(i+1)+ "° animal: ");
                a.Nome = Console.ReadLine();
                Console.Write("Informe o tipo do "+(i+1)+ "° (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
                try
                {
                    tipoAnimal = Convert.ToInt32(Console.ReadLine());
                    if (tipoAnimal < 0 || tipoAnimal > 2)
                    {
                        tipoAnimal = 2;
                    }
                }
                catch
                {
                    tipoAnimal = 2;

                }
                a.Tipo = (TipoAnimal)tipoAnimal;
                if (a.Tipo == TipoAnimal.Cachorro)
                {
                    tlCachorro++;
                }
                if (a.Tipo == TipoAnimal.Gato)
                {
                    tlGato++;
                }
                if (a.Tipo == TipoAnimal.Peixe)
                {
                    tlPeixe++;
                }

                //Armazenar o animal no Array
                animais[i] = a;
            }

            //RESULTADO
            Console.WriteLine("Total de animais:");
            Console.WriteLine("Cachorros: " + tlCachorro + " Gatos: " + tlGato + " Peixes: " + tlPeixe);

            //Exibir todos os animais cadastrados
            Console.WriteLine("\nAnimais Cadastrados:");
            for (int i = 0; i < tl; i++)
            {
                Console.WriteLine($"{i + 1}. Nome: {animais[i].Nome}, Tipo: {animais[i].Tipo}");
            }

            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
