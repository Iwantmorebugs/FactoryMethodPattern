using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Factories
{
    public class NiceBusinessObjectFactory : IBusinessObjectFactory
    {
        public IBusinessObject CreateBusinessObject(KindOfBusiness name)
        {
            return new NiceBusinessObject(name);
        }
    }
}