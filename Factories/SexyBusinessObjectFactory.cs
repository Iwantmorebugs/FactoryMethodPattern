using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Factories
{
    public class SexyBusinessObjectFactory : IBusinessObjectFactory
    {
        public IBusinessObject CreateBusinessObject(KindOfBusiness name)
        {
            return new VeryNiceBusinessObject(name);
        }
    }
}