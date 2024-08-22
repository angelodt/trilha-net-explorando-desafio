using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

List<Reserva> reservas = new List<Reserva>();
// Cria uma nova reserva, passando a suíte e os hóspedes
try {
    Reserva reserva = new Reserva(diasReservados: 5);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);
    reservas.Add(reserva);

    Reserva reserva2 = new Reserva(diasReservados: 10);
    reserva2.CadastrarSuite(suite);
    reserva2.CadastrarHospedes(hospedes);
    reservas.Add(reserva2);

    Reserva reserva3 = new Reserva(diasReservados: 10);
    reserva3.CadastrarSuite(suite);
    hospedes.Add(p3);
    reserva3.CadastrarHospedes(hospedes);
    reservas.Add(reserva3);

}catch(Exception e)
{
    Console.WriteLine($"Reserva não efetuada: {e.Message}");
}

for(int i=0;i < reservas.Count; i++) {
    Console.WriteLine($"Informações da Reserva: {i+1}");
    Console.WriteLine($"Hóspedes: {reservas[i].ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor Reserva: {reservas[i].CalcularValorDiaria()}");
}

