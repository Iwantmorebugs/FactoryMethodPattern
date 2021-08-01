using System;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Model;
using FactoryMethodPattern.Services;

namespace FactoryMethodPattern
{
    internal class Program
    {
        private static void Main()
        {
            //Create specific factories
            IBusinessObjectFactory niceObjectFactory = new NiceBusinessObjectFactory();
            IBusinessObjectFactory veryNiceObjectFactory = new SexyBusinessObjectFactory();

            //DI
            var sexyBusinessService = new BusinessService(niceObjectFactory, KindOfBusiness.CryptoBusiness);
            var niceBusinessService = new BusinessService(veryNiceObjectFactory, KindOfBusiness.MachineLearningBusiness);

            niceBusinessService.DoBusiness();
            Console.ReadKey();

            sexyBusinessService.DoBusiness();
            Console.ReadKey();
        }
    }
}