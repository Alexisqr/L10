
using System;
using System.Collections.Generic;
using System.Text;
using _3.Contracts;
using _03BarracksFactory.CustomAttributes;
using _03BarracksFactory.Core.Factories;

namespace _03BarracksFactory.Core.Commands
{
    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;
        public ReportCommand(string[] data)
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
            string output = this.repository.Statistics;
            return output;
        }
    }
}