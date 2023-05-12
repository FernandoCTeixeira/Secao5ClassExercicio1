using System.Globalization;

namespace Exercicio1 {
    class ContaBancaria {

        private string _titular; // Pode usar auto properties
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            _titular = titular;
        }

        public string Nome {
            get { return _titular; } 
            set {
                if (value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }

       public void Deposito(double valorDeposito) {
            Saldo += valorDeposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.00;
        }

        public override string ToString() {
            return "Conta: "
                + Conta
                + ", Titular: "
                + _titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
