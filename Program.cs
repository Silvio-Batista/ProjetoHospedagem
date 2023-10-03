using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Silvio", sobrenome: "Batista");
Pessoa p2 = new Pessoa(nome: "Luis", sobrenome: "Miguel");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30M);

Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}");