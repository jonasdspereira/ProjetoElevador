using System;

namespace ProjetoElevador.Models
{
    public class Elevador
    {
        //Declarando as variáveis
        int andarAtual;
        int totalPessoas;
        int totalAndares;
        int Capacidade;

        //Construtor que inicia as variáveis do elevador 
        public Elevador(int capacidade, int andares)
        {
            totalAndares = andares;
            Capacidade = capacidade;
        }

        //Função para adicionar pessoas no elevador.
        public void Entrar()
        {
            if (totalPessoas < Capacidade)
            {
                totalPessoas++;
                string qtdPessoas = totalPessoas == 1 ? $"{totalPessoas} pessoa entrou." : $"{totalPessoas} pessoas entraram.";
                Console.WriteLine(qtdPessoas);
            }
            else
            {
                Console.WriteLine($"Elevador está cheio, aguarde.");
            }
        }

        //Função para remover pessoas no elevador.
        public void Sair()
        {
            if (totalPessoas > 0)
            {
                totalPessoas--;
                Console.WriteLine("Uma pessoa saiu do elevador.");
            }
            else
            {
                Console.WriteLine("O elevador está vazio.");
            }
        }

        //Função para subir o elevador.
        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
                string exibirAtual = andarAtual != 0 ? $"O elevador está no {andarAtual}º andar." : $"Descendo para o {andarAtual}º andar.";
                Console.WriteLine(exibirAtual);
            }
            else
            {
                Console.WriteLine($"O elevador já está no {andarAtual}º e último andar!");
            }
        }

        //Função para descer o elevador.
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                string exibirAndar = andarAtual == 0 ? $"O elevador chegou no térreo." : $"Descendo para o {andarAtual}º andar.";
                Console.WriteLine(exibirAndar);
            }
            else
            {
                Console.WriteLine("O elevador está no térreo!");
            }
        }

    }

}
