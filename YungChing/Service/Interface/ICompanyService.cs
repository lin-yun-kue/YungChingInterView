using YungChing.EFModel;

namespace YungChing.Service.Interface
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAllCompany();
        public Company GetCompany(int id);
        public bool CreateCompany(Company company);
        public bool UpdateCompany(int id, Company company);
        public bool DeleteCompany(int id);
    }
}
