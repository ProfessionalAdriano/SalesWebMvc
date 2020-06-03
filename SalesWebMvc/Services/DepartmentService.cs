using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; // readonly --> Previne q a dependencia nao seja alterada.

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        
        // Metodo q retorna todos os departamentos

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
