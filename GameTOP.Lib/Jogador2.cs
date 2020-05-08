using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {

        //Chuta
        public string Chuta()
        {
            return $"Teste está Chutando \n";
        }

        //Corre
        public string Corre()
        {
            return $"Teste está Correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"Teste está Passando \n";
        }

        
    }
}