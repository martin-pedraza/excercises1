using System;
using Entidades;

namespace class03_exA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor conductorMaximoKmSemana;
            Conductor conductorMaximoKmDia3;
            Conductor conductorMaximoKmDia5;

            Conductor[] conductores = new Conductor[3];
            conductores[0] = new Conductor("Mario", 15, 15, 15, 15, 150, 0, 0);
            conductores[1] = new Conductor("Henrique", 20, 100, 0, 40, 50, 300, 0);
            conductores[2] = new Conductor("Cesar");

            for (int i = 1; i <= 7; i++)
            {
                conductores[2].AgregarHorasDia(30, i);
            }

            conductorMaximoKmSemana = conductores[0];
            foreach (Conductor conductor in conductores)
            {
                if (conductor.CantidadHorasSemana() > conductorMaximoKmSemana.CantidadHorasSemana())
                {
                    conductorMaximoKmSemana = conductor;
                }
            }
            Console.WriteLine($"Conductor MAX horas en semana: {conductorMaximoKmSemana.Nombre}");

            conductorMaximoKmDia3 = conductores[0];
            foreach (Conductor conductor in conductores)
            {
                if (conductor.VerificarHorasDia(3) > conductorMaximoKmSemana.VerificarHorasDia(3))
                {
                    conductorMaximoKmDia3 = conductor;
                }
            }
            Console.WriteLine($"Conductor MAX horas del dia 3: {conductorMaximoKmDia3.Nombre}");

            conductorMaximoKmDia5 = conductores[0];
            foreach (Conductor conductor in conductores)
            {
                if (conductor.VerificarHorasDia(5) > conductorMaximoKmDia5.VerificarHorasDia(5))
                {
                    conductorMaximoKmDia5 = conductor;
                }
            }
            Console.WriteLine($"Conductor MAX horas del dia 5: {conductorMaximoKmDia5.Nombre}");
        }
    }
}
