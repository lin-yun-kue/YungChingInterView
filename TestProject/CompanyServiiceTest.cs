using YungChing.EFModel;
using YungChing.Service;

namespace TestProject
{
    public class CompanyServiiceTest
    {
        [Fact]
        public void TestCreateCompany()
        {
            var service = new CompanyService(null);

            var company = new Company()
            {
                Id = 1,
                Name = "Test",
                Phone = "1"
            };

           Assert.Throws<ArgumentException>(() => service.CreateCompany(company));
        }
    }
}