namespace SistemaBancario.Models
{
    //herança
    //ContaCorrente herda de ContaBancaria
    public class ContaCorrente : ContaBancaria
    {
        //construtor repasando os parametros para a classe base
        public ContaCorrente(string numeroConta, string nomeTitular, decimal saldoInicial) :
            base(numeroConta, saldoInicial, nomeTitular)
        { }
        public override bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                ExtratoTransacoes.Add($"Saque: -R$ {valor:F2} | Saldo Atual: R$ {Saldo:F2}");
                return true;
            }
            return false;
        }
        //Funcionalidade exclusiva de investimento para clientes
        public void Investir(decimal valor) 
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                decimal rendimento = valor * 1.05m; // Simula investimento com 5% de retorno imediato
                Saldo += rendimento;
                ExtratoTransacoes.Add($"Investimento Aplicado: R$ {valor:F2} (Rendeu para R$ {rendimento:F2}) | Saldo Atual: R$ {Saldo:F2}");
            }
        }
    }
}
