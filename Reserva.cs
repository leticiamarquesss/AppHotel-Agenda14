
using System;

namespace AppHotel
{
    public class Reserva
    {
        public string Nome { get; private set; }

        public string Quarto { get; private set; }

        public DateTime DataEntrada { get; private set; }

        public DateTime DataSaida { get; private set; }

        public int Hospedes { get; private set; }

        public int QuantidadeDiarias
        {
            get
            {
                return (DataSaida - DataEntrada).Days;
            }
        }

        public string Periodo
        {
            get
            {
                return $"{DataEntrada:dd/MM/yyyy} até {DataSaida:dd/MM/yyyy}";
            }
        }

        public string ResumoDiarias
        {
            get
            {
                return QuantidadeDiarias == 1
                    ? "1 diária"
                    : $"{QuantidadeDiarias} diárias";
            }
        }

        public Reserva(
            string nome,
            string quarto,
            DateTime dataEntrada,
            DateTime dataSaida,
            int hospedes)
        {
            Nome = nome;
            Quarto = quarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Hospedes = hospedes;
        }
    }
}
