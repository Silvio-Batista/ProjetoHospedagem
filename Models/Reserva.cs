using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProjetoHospedagem.Models;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva () {}
         public Reserva (int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            if (Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;
            } else{
                Console.WriteLine("O número de hóspede é maior que a capacidade da suite");
            }
        }
        public void CadastrarSuite (Suite suite){
            Suite = suite;
        }
        public int ObterQuantidadeHospedes(){
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria(){
            decimal valor = 0;
            if (DiasReservados >= 10){
                decimal desconto = DiasReservados * Suite.ValorDiaria * 0.1m;
                valor = (DiasReservados * Suite.ValorDiaria) - desconto;
            } else {
                valor = DiasReservados * Suite.ValorDiaria;
                }
            return valor;  
            } 
        }
    }
