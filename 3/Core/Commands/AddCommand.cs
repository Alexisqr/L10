using _03BarracksFactory.CustomAttributes;
using _03BarracksFactory.Core.Commands;
using _3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;
      
        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }
        public AddCommand(string[] data)
          : base(data)
        {
        }
        public override string Execute()//Модифікатор override потрібен для розширення або зміни абстрактної чи віртуальної
                                        //реалізації успадкованого методу, властивості, індексатора чи події.
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
