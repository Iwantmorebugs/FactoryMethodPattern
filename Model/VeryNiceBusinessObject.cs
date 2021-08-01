using System;

namespace FactoryMethodPattern.Model
{
    public class VeryNiceBusinessObject : IBusinessObject
    {
        private readonly KindOfBusiness _kindOfBusiness;

        public VeryNiceBusinessObject(KindOfBusiness kindOfBusiness)
        {
            _kindOfBusiness = kindOfBusiness;
        }


        public void DoBusinessStuff()
        {
            Console.WriteLine($"I do seeeeexy business within the field of  {_kindOfBusiness}");
        }
    }
}