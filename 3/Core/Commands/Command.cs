using _3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
       

        protected Command(string[] data)
        {
            this.Data = data;

        }

        protected string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

       
        public abstract string Execute();
    }
}
