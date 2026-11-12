using TRPO_Prakt8.Models;

namespace TRPO_Prakt8.Services
{
    public class DbService
    {
        private MyDbContext _context;
        public MyDbContext Context => _context;

        private static DbService instance;
        public static DbService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbService();
                return instance;
            }
        }
        private DbService()
        {
            _context = new MyDbContext();
        }
    }
}
