using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Derlis ";
            jogador1.idade = 17;
            jogador1.armadura = "FaceShield";
            jogador1.IA = "Pure Skill";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Light";
            jogador2.idade = 18;
            jogador2.armadura = "MK3";

            Console.Clear();
            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura: {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.IA} || Jogador 2 IA: {jogador2.IA}");

            //COMECE A LUTA

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O Jogador esta ferido");
            }else{
                Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida} de vida");
            }
        }
    }
}