using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Factories
{
    public interface IBusinessObjectFactory
    {
        IBusinessObject CreateBusinessObject(KindOfBusiness name);
    }
}