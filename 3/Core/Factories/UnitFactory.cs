namespace _03BarracksFactory.Core.Factories
{
    using System;
    using _3.Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            Type classType = Type.GetType("_03BarracksFactory.Models.Units." + unitType);
             if (classType == null)
            {
                return null;
            }
                return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
