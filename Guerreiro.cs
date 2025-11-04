using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpg
{
    public class Guerreiro
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public Guerreiro(string Nome) 
        {
            Nome = "Guerreiro";
            Vida = 160;
            Ataque = 20;
            Defesa = 20;        
        }
        public void ExibirPersonagem()
        {
            Console.Write("Esolhido Classe Guerreiro.");
        }

    }
}
