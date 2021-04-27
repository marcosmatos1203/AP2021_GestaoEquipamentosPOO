using System;

namespace GestaoEquipamentos.ConsoleApp
{
    class Program
    {
        /** Requisito 1.1 [OK] [12,5 % Concluído]
         * Como funcionário, Junior quer ter a possibilidade 
         * de registrar equipamentos
    
            Critérios:
        
             •  Deve ter um nome com no mínimo 6 caracteres;  
             •  Deve ter um preço de aquisição;  
             •  Deve ter um número de série;  
             •  Deve ter uma data de fabricação;  
             •  Deve ter uma fabricante; 
         */

        /** Requisito 1.2 [OK] [25% Concluído]
         * Como funcionário, Junior quer ter a possibilidade 
         * de visualizar todos os equipamentos registrados em seu inventário
    
            Critérios:
        
             •  Deve mostrar o nome;  
             •  Deve mostrar o preço de aquisição;  
             •  Deve mostrar o número de série;  
             •  Deve mostrar a data de fabricação;  
             •  Deve mostrar o fabricante; 
         */

        /** Requisito 1.3 [OK] [37,5% Concluído]
         * Como funcionário, Junior quer ter a possibilidade 
         * de editar um equipamento, sendo que ele possa editar todos os campos
    
            Critérios:
        
             •  Deve ter os mesmos critérios que o Requisito 1.1
         */

        /** Requisito 1.4 [OK] [50% Concluído]
         * 
         * Como funcionário, Junior quer ter a possibilidade 
         * de excluir um equipamento que esteja registrado.    
         * 
         *    •   A lista de equipamentos deve ser atualizada
         */

        /** Requisito 2.1 [OK] [62,5% Concluído]
         * 
         * Como funcionário, Junior quer ter a possibilidade 
         * de registrar os chamados de manutenções que são efetuadas nos equipamentos registrados    
         * 
                 •  Deve ter a título do chamado;  
                 •  Deve ter a descrição do chamado;  
                 •  Deve ter um equipamento;  
                 •  Deve ter uma data de abertura;   
         */

        /** Requisito 2.2 [OK] [75% Concluído]
        * 
        * Como funcionário, Junior quer ter a possibilidade de
        * visualizar todos os chamados registrados para controle.   
        * 
                •  Deve ter o id do chamado;  
                •  Deve ter a título do chamado;  
                •  Deve ter a descrição do chamado;  
                •  Deve ter um equipamento;  
                •  Deve ter uma data de abertura;   
        */

        /** Requisito 2.3 [OK] [87,5% Concluído]
        * 
        * Como funcionário, Junior quer ter a possibilidade de
        * editar um chamado que esteja registrado, sendo que ele possa editar todos os campos   
        * 
                •  Deve ter os mesmos critérios que o Requisito 2.1  
        */

        /** Requisito 2.4 [OK] [100% Concluído]
        * 
        * Como funcionário, Junior quer ter a possibilidade
        * de excluir um chamado
        * 
                •  A lista de chamados deve ser atualizada 
        */



        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Equipamento equipamento = new Equipamento();
            Chamado chamado = new Chamado();

            while (true)
            {
                string opcao = menu.ObterMenuPrincipal();


                if (menu.EhOpcaoSair(opcao))
                    break;
                if (menu.EhOpcaoInvalidaMenuPrincipal(opcao))
                {
                    menu.mensagemErro("Opção Inválida, tente novamente"); continue;
                }
                if (opcao == "1")
                {
                    string opcaoCadastroEquipamentos = menu.ObterOpcaoCadastroEquipamentos();

                    if (menu.EhOpcaoSair(opcaoCadastroEquipamentos))
                        break;
                    if (menu.EhOpcaoInvalidaSubMenu(opcaoCadastroEquipamentos))
                        break;

                    if (opcaoCadastroEquipamentos == "1")
                        equipamento.RegistrarEquipamento();

                    else if (opcaoCadastroEquipamentos == "2")
                        equipamento.VisualizarEquipamentos();

                    else if (opcaoCadastroEquipamentos == "3")
                        equipamento.EditarEquipamento();

                    else if (opcaoCadastroEquipamentos == "4")
                        equipamento.ExcluirEquipamento();
                }
                else if (opcao == "2")
                {
                    string opcaoControleChamados = menu.ObterOpcaoControleChamados();

                    if (menu.EhOpcaoSair(opcaoControleChamados))
                        break;
                    if (menu.EhOpcaoInvalidaSubMenu(opcaoControleChamados))
                        break;

                    if (opcaoControleChamados == "1")
                        chamado.RegistrarChamado();

                    else if (opcaoControleChamados == "2")
                        chamado.VisualizarChamados();

                    else if (opcaoControleChamados == "3")
                        chamado.EditarChamado();

                    else if (opcaoControleChamados == "4")
                        chamado.ExcluirChamado();

                }

                Console.Clear();
            }
        }

    }
}
