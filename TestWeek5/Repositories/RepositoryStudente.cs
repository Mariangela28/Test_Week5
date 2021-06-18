using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek5.Entities;

namespace TestWeek5.Repositories
{
    public class RepositoryStudente : IRepositoryStudente
    {
        const string connectionString = @"Server = .\SQLEXPRESS; Persist Security Info = False; 
                Integrated Security = true; Initial Catalog = Esami;";

        public bool Add(Studente item)

        {
            bool esito;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //permette il collegamento tra memoria locale e db
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                //creo i comandi da asscoaire all'adapter

                SqlCommand selectCommand = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT * FROM Studente"
                };

                //creazione comando insert
                SqlCommand insertCommand = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "INSERT INTO Studente VALUES (@Nome, @Cognome, @AnnoNascita)" //non metto il codice perchè è chiave primaria auto incrementante
                };
                //specifico  le caratterisithce del parametro
                insertCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50, "Nome");
                insertCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50, "Cognome");
                insertCommand.Parameters.Add("@AnnoNascita", SqlDbType.DateTime, "AnnoNascita"); //devo sistemare


                //associamo comandi all'adapter
                dataAdapter.SelectCommand = selectCommand;
                dataAdapter.InsertCommand = insertCommand;

                //creo dataset
                DataSet dataSet = new DataSet();
                try
                {
                    //connessione verso db
                    connection.Open();
                    //recupero i dati (fill)
                    dataAdapter.Fill(dataSet, "Studente");


                    DataRow studente = dataSet.Tables["Studente"].NewRow();

                    studente["Nome"] = "Mariangela";
                    studente["Cognome"] = "Leone";
                    studente["AnnoNascita"] = '1996-03-28';
                    //aggiugo studente
                    dataSet.Tables["Studente"].Rows.Add(studente);
                    //riconciliazione con origine dei dati - caricamento delle modifiche
                    dataAdapter.Update(dataSet, "Studente");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    esito = false;
                }
            }

        return esito;
            
        }

        public IList<Studente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Studente GetById(int value)
        {
            throw new NotImplementedException();
        }
    }

        

        public IList<Studente> GetAll()
        {
            IList<Studente> studenti = new List<Studente>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                //Aprire la connessione
                connection.Open();


                //Creare un Command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Studente";

                //Esecuzione del Command (DataReader)
                SqlDataReader reader = command.ExecuteReader();

                //Lettura dei dati
                while (reader.Read())
                {
                    studenti.Add(new Entities.Studente()
                    {
                        ID = Int32.Parse(reader["ID"].ToString()),
                        Nome = reader["Nome"].ToString(),
                        Cognome = reader["Cognome"].ToString(),
                        AnnoNascita = Int32.Parse(reader["AnnoNascita"].ToString())
                    });

                }


                //Chiusura connessione
                reader.Close();
                connection.Close();

            }
            return studenti;
        }

        
    }
}

        
        

        
    

