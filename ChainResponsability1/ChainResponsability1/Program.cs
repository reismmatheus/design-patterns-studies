    using System;

namespace ChainResponsability1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenteProjeto gerenteProjeto = new GerenteProjeto();
            SupervisorEquipe supervisorEquipe = new SupervisorEquipe();
            SetorRH setorRH = new SetorRH();

            gerenteProjeto.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(setorRH);

            gerenteProjeto.AutorizarLicenca("Macoratti", 5);
            gerenteProjeto.AutorizarLicenca("Amanda", 14);
            gerenteProjeto.AutorizarLicenca("Benedito", 18);
            gerenteProjeto.AutorizarLicenca("Janice", 30);
            gerenteProjeto.AutorizarLicenca("Felipe", 50);

            Console.ReadKey();
        }
    }
}
