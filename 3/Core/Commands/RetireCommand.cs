using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Core.Factories;
using _03BarracksFactory.CustomAttributes;
using _3.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;
        public RetireCommand(string[] data)
            : base(data)
        {
        }
        
        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public override string Execute()
        {
            try
            {
                this.repository.RemoveUnit(this.Data[1]);
                return $"{this.Data[1]} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }
    }
}