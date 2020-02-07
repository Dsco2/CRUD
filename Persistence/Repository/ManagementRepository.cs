using System.Linq;
using Business.Data;
using Business.Interfaces;

namespace Persistence.Repository
{
    public class ManagementRepository : IManagementRepository
    {
        private readonly PrincipalContext _context;

        public ManagementRepository(PrincipalContext context)
        {
            _context = context;
        }


        public Data GetTable(int idData)
        {
            var temp = _context.Data.FirstOrDefault(x => x.IdData == idData);

            return temp;
        }

        public bool AddData(Data data)
        {
            _context.Data.Add(data);
            return _context.SaveChanges()>0;
        }
    }
}
