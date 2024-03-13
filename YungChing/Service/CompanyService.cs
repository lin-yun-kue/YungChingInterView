using YungChing.EFModel;
using YungChing.Service.Interface;

namespace YungChing.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly CompanyContext _context;

        public CompanyService(CompanyContext context)
        {
            _context = context;
        }

        public bool CreateCompany(Company company)
        {
            if (company.Phone.Length != 10)
            {
                throw new ArgumentException("input err");
            }
            try
            {
                _context.Company.Add(company);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public Company GetCompany(int id)
        {
            return _context.Company.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Company> GetAllCompany()
        {
            return _context.Company.ToList();
        }

        public bool UpdateCompany(int id, Company company)
        {
            try
            {
                var target = _context.Company.FirstOrDefault(_ => _.Id == id);
                if (target == null) {
                    return false;
                }
                _context.Entry(target).CurrentValues.SetValues(company);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCompany(int id)
        {
            try
            {
                var target = _context.Company.FirstOrDefault(x => x.Id==id);
                _context.Company.Remove(target);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
