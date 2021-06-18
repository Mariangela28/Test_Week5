using System;
using TestWeek5.Repositories;

namespace TestWeek5
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepositoryStudente repoStudenti = new RepositoryStudente();


            foreach (var studente in repoStudenti.GetAll())
            {
                Console.WriteLine("Nome: {0} Cognome: {1} Anno di nascita: {2}",
                    studente.Nome, studente.Cognome, studente.AnnoNascita);
            }

            IRepositoryEsame repoEsami = new RepositoryEsame();
            foreach (var esame in repoEsami.GetAll())
            {
                Console.WriteLine("Nome: {0} CFU: {1} DataEsame: {2} Votazione: {3} Passato: {4} StudenteID: {5}",
                    esame.Nome, esame.CFU, esame.DataEsame, esame.Votazione, esame.Passato, esame.StudenteID);
            }

        }
    }
}
