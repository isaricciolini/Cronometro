using System;

namespace Cronometro{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundos (10s = 10 segundos)");
            Console.WriteLine("M = Minutos (10m = 10 minutos)");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string? data = Console.ReadLine();
            string tipo;
            int tempo = 0;
            int multiplicador = 1;

            if(data != null){
                tipo = data.Substring(data.Length - 1, 1);
                tempo = Convert.ToInt32(data?.Substring(0, data.Length - 1));
                if(tipo == "m")
                multiplicador = 60;

                if(tempo == 0)
                System.Environment.Exit(0);
                
                PreStart(tempo * multiplicador);
            }

        }

        static void PreStart(int tempo){
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Começar...");
            Thread.Sleep(2500);

            Start(tempo);
        }

        static void Start(int time){
            int currentTime = 0;
            while(currentTime != time){
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
