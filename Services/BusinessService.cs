using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly IBusinessObjectFactory _businessObjectFactory;
        private readonly KindOfBusiness _kindOfBusiness;

        public BusinessService(IBusinessObjectFactory businessObjectFactory, KindOfBusiness kindOfBusiness)
        {
            _businessObjectFactory = businessObjectFactory;
            _kindOfBusiness = kindOfBusiness;
        }

        public void DoBusiness()
        {
            var myBusinessObject = _businessObjectFactory.CreateBusinessObject(_kindOfBusiness);
            myBusinessObject.DoBusinessStuff();
        }
    }
}