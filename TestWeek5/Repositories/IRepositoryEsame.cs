using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek5.Entities;

namespace TestWeek5.Repositories
{
    public interface IRepositoryEsame : IRepository<Esame>
    {
        public IList<Esame> OrderedEsami();
        public IList<Esame> GetByID(int value);
    }
}
