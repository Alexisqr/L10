using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BlackBoxInt
    {
        private int num;

        private BlackBoxInt()
        {
            this.num = 0;
        }

        private void Add(int input)
        {
            this.num += input;
        }

        private void Subtract(int input)
        {
            this.num -= input;
        }

        private void Multiply(int input)
        {
            this.num *= input;
        }

        private void Divide(int input)
        {
            this.num /= input;
        }

        private void LeftShift(int input)
        {
            this.num <<= input;
        }

        private void RightShift(int input)
        {
            this.num >>= input;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Type myType = typeof(BlackBoxInt);
            var print = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var ins = (BlackBoxInt)Activator.CreateInstance(myType, true); //значення true, щоб вказати, що пошук myType не чутливий до регістру;
            var input = Console.ReadLine();
            while (input!="END")
            {
                var data = input.Split('_');
                MethodInfo fun =null;
                foreach (var x in print )
                {
                    if (x.Name == data[0])
                    {
                        fun = x;
                        break;
                    }
                }
                Console.WriteLine(fun);
                fun.Invoke(ins, new object[] { int.Parse(data[1]) });
               
                 foreach (FieldInfo field in myType.GetFields(
                                  BindingFlags.Instance | BindingFlags.NonPublic))
                {
                  if (field.Name == "num")
                   {
                      Console.WriteLine(field.GetValue(ins));
                        break;
                   }
                 }
      
                input = Console.ReadLine();
            }
            }
    }
}
