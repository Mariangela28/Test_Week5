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
    public class RepositoryEsame : IRepositoryEsame
    {
        const string connectionString = @"Server = .\SQLEXPRESS; Persist Security Info = False; 
                Integrated Security = true; Initial Catalog = Esami;";

        public bool Add(Esame item)
        {
            throw new NotImplementedException();
        }

        public IList<Esame> GetAll()
        {
            throw new NotImplementedException();
        }

        public Esame GetById(int value)
        {
            throw new NotImplementedException();
        }

        public IList<Esame> GetByID(int value)
        {
            throw new NotImplementedException();
        }

        //public IList<Esame> GetByID(int value)
        //{
        //    return GetAll().FirstOrDefault(esame => esame.ID == value).ToList();
        //}

        public IList<Esame> OrderedEsami()
        {
            return GetAll().OrderBy(e => e.Votazione).ThenBy(e => e.DataEsame).ToList();
            
        }
    }

       

       

        

        
    }

