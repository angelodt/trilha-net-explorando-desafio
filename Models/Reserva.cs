namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (this.Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade da suíte é menor do que o número de hóspedes nesta reserva.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = Decimal.Multiply(DiasReservados, Suite.ValorDiaria);

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados>=10)
            {
                valor = Decimal.Multiply(valor,new decimal(0.9));
                Console.WriteLine($"Reserva maior ou igual a 10 dias possui 10% de desconto.");
                Console.WriteLine($"Valor sem desconto: {Decimal.Multiply(DiasReservados, Suite.ValorDiaria)}");
                Console.WriteLine($"Novo valor com desconto: {valor}");
            }

            return valor;
        }
    }
}