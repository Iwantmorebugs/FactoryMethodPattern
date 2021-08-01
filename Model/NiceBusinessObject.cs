using System;

namespace FactoryMethodPattern.Model
{
    public class NiceBusinessObject : IBusinessObject
    {
        private readonly KindOfBusiness _kindOfBusiness;

        public NiceBusinessObject(KindOfBusiness kindOfBusiness)
        {
            _kindOfBusiness = kindOfBusiness;
        }


        public void DoBusinessStuff()
        {
            Console.WriteLine($"I do niiiiice business within the field of  {_kindOfBusiness}");
        }
    }
}