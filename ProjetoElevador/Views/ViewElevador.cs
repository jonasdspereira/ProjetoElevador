using ProjetoElevador.Models;
using System;

namespace ProjetoElevador.View
{
    internal class ViewElevador
    {
        //Menu de opções para o usuário
        public void Projeto(Elevador elevador)
        {
            Console.WriteLine("Olá, bem-vindo ao edifício Ocean!");
            var continuar = true;
            while(continuar)
            {
                //Inicialização do programa, exibindo as opções para o usuário.
                Console.WriteLine(@"Digite a opção desejada:
                                            1 - Entrar
                                            2- Sair
                                            3- Subir
                                            4 - Descer
                                            5 - Finalizar");

                string OpcaoEscolhida = Console.ReadLine();
                Console.Clear();


                switch (OpcaoEscolhida)
                {
                    case "1": elevador.Entrar(); break;
                    case "2": elevador.Sair(); break;
                    case "3": elevador.Subir(); break;
                    case "4": elevador.Descer(); break;
                    case "5": continuar = false; break;

                    default:
                        Console.WriteLine("Opção inválida"); break;
                }
            }
        }
    }
}

