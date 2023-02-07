using System;
namespace Atividade_senai
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Infome seu nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe seu endereço");
            string var_endereço = Console.ReadLine();
            Console.WriteLine("Pessoa fisica(f) ou Jurídica(j)");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f") //Pessoa Física
            {
                //(INSTANCIAMENTO) copia estrutura classe Pessoa_Fisica para objeto pf
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereço;
                Console.WriteLine("informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_imposto(val_pag);
                Console.WriteLine("############## Pessoa Física ##############");
                Console.WriteLine("Nome .............: " + pf.nome);
                Console.WriteLine("CPF ..............: " + pf.cpf);
                Console.WriteLine("RG ...............: " + pf.rg);
                Console.WriteLine("Valor da Compra...: " + pf.valor.ToString("C")); //Converter para string e apresentar em formato de moeda
                Console.WriteLine("Imposto...........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.....: " + pf.total.ToString("C"));
            
            }
            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereço;
                Console.WriteLine("informe seu cnpj: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("infome seu IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_imposto(val_pag);
                Console.WriteLine("############## Pessoa Jurídica ##############");
                Console.WriteLine("Nome .............: " + pj.nome);
                Console.WriteLine("CNPJ .............: " + pj.cnpj);
                Console.WriteLine("IE ...............: " + pj.ie);
                Console.WriteLine("Valor da Compra...: " + pj.valor.ToString("C")); //Converter para string e apresentar em formato de moeda
                Console.WriteLine("Imposto...........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.....: " + pj.total.ToString("C"));

            }

        }
    }
}