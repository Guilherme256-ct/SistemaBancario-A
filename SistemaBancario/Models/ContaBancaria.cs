namespace SistemaBancario.Models
{
    //classe abstrata aplicando o pilar da abstração
    //uma classe abstrada não pode ser instanciada
    public abstract class ContaBancaria
    {
        //atributos encapsulados e protegidos por propriedades públicas
        private string _numeroConta;
        private decimal _saldo;
        public string NumeroConta{
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        public decimal Saldo { 
            get => _saldo;
            protected set => _saldo = value <0 ? 0:value;
        }
        //propriedade publica NomeTitular
        public string NomeTitular { get; set; }
        //propriedade publica historico para gerar extrato de transações
        public List <string> ExtratoTransacoes { get; set; } = new List<string>();

        //método Construtor
        protected ContaBancaria(string numeroConta,decimal saldoInicial,string nomeTitular)
        {
            NumeroConta=numeroConta;
            NomeTitular=nomeTitular;
            Saldo=saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo de R${saldoInicial:F2}");
        }
        //metodo virtual (polimorfismo): pode ser feito de diversas formas por cada classe filha
        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                ExtratoTransacoes.Add($"Depósito: +R$ {valor:F2} | Saldo Atual: {Saldo:F2}");
            }
        }
        //metodo abstrato: obriga as classes filhas a implementarem suas próprias regras de saque
        public abstract bool Sacar(decimal valor);

    }
}
