
using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.CustomAttributes;
using _3.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()//Модифікатор override потрібен для розширення або зміни абстрактної чи віртуальної
                                        //реалізації успадкованого методу, властивості, індексатора чи події.
        {
            Environment.Exit(0);
            return null;
        }
    }
}