//Criar uma aplicação de console para simular de maneira simples operações bancárias
//**Entrada**: Receber Informação de Operação
//**Saída:** Baseado na operação mostrar o resultado
//Ter uma opção no menu para parar a aplicação senão, enquanto isso, após o resultado, mostra para selecionar a outra operação.
//Crie método para saque - adicionar e atualizar saldo
//Validação: quando não tiver saldo suficiente (mostrar em cor vermelha a mensagem da validação)

namespace Banco;

class Banco {
    public static void Main(string[] args)
    {

    Console.ForegroundColor = ConsoleColor.Yellow;

    string[] operacoes = new string[5];

    operacoes[0] = "1 - Consultar saldo";
    operacoes[1] = "2 - Fazer depósito";
    operacoes[2] = "3 - Fazer saque";
    operacoes[3] = "4 - Consultar histórico";
    operacoes[4] = "5 - SAIR";

    int[] numerosOperacoes = new int[5];

    numerosOperacoes[0] = 1;
    numerosOperacoes[1] = 2;
    numerosOperacoes[2] = 3;
    numerosOperacoes[3] = 4;
    numerosOperacoes[4] = 5;

    Console.WriteLine("Olá, seja bem-vindo");

    Console.WriteLine("Qual operacao voce gostaria de fazer?");

    Console.WriteLine("Digite o numero referente a opcao escolhida:");

    Console.WriteLine(operacoes[0]);
    Console.WriteLine(operacoes[1]);
    Console.WriteLine(operacoes[2]);
    Console.WriteLine(operacoes[3]);
    Console.WriteLine(operacoes[4]);

    string operacaoEscolhida = Console.ReadLine();
    int operacaoEscolhida1 = int.Parse(operacaoEscolhida);

        if (operacaoEscolhida1 == numerosOperacoes[0])
        {
            Console.WriteLine($"Seu saldo total é de {ConsultarSaldo}");
        }
        else if (operacaoEscolhida1 == numerosOperacoes[1])
        {
            Console.WriteLine("Qual é o valor que voce deseja depositar?");
            string valor = Console.ReadLine();
            int valorDoDeposito = int.Parse(valor);
            Console.WriteLine(Depositar);
        }
        else if (operacaoEscolhida1 == numerosOperacoes[2])
        {
            Console.WriteLine("Qual é o valor do saque que voce gostaria de fazer?");
            string valorDoSaque = Console.ReadLine();
            int valorDoSaque1 = int.Parse(valorDoSaque);
            Console.WriteLine(Sacar);
        }
        else if (operacaoEscolhida1 == numerosOperacoes[3]) 
        {
            Console.WriteLine("Digite seu nome completo para identificacao:");
            string identificacaoPorNome = Console.ReadLine();
            Console.WriteLine(ConsultarHistorico);
        }
        else
        {
            Console.WriteLine("Voce está saindo do sistema");
        }
    }
    
     public class ContaBancaria
    {
        string clienteCadastrado;
        int registroGeral;
        int saldoTotal;
        public ContaBancaria() {

        string clienteCadastrado = "Maria Alves";
        int registroGeral = 7896456;
        int saldoTotal = 12400;
        }

         public static int ConsultarSaldo(int saldoTotal){
         return saldoTotal;
    }
    public static int Depositar(int valorDoDeposito) {
        if (valorDoDeposito > 0) { 
        Console.WriteLine("Seu deposito foi efetuado com sucesso");
    } else (valorDoDeposito < 0) {
        Console.WriteLine("Seu deposito nao pode ser efetuado");
        Console.ForegroundColor = ConsoleColor.Red;
    }
}
    public static int Sacar(int valorDoSaque1) {
        if (valorDoSaque1 > 0) {
            Console.WriteLine("Seu saque foi efetuado com sucesso");
        } else (valorDoSaque1 < 0) {
            Console.WriteLine("Seu saque nao pode ser efetuado");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
    public static int ConsultarHistorico(string identificacaoPorNome){
        if (identificacaoPorNome == clienteCadastrado) {
            Console.WriteLine("Este é seu histórico de operacoes");
        } else {
            Console.WriteLine("Nao foi possivel exibir seu historico de operacoes");
        }
    }

    }
} 




