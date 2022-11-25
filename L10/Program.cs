
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace L10
{
    class HarvestingFields
    {
        private Int32 testInt;
        public Double testDouble;
        protected String testString;
        private Int64 testLong;
        protected Double aDouble;
        public String aString;
        private Calendar aCalendar;
        public StringBuilder aBuilder;
        private Char testChar;
        public Int16 testShort;
        protected Byte testByte;
        public Byte aByte;
        protected StringBuilder aBuffer;
        //private BigInteger testBigInt;
       // protected BigInteger testBigNumber;
        protected Single testFloat;
        public Single aFloat;
        private Thread aThread;
        public Thread testThread;
        private Object aPredicate;
        protected Object testPredicate;
        public Object anObject;
        private Object hiddenObject;
        protected Object fatherMotherObject;
        private String anotherString;
        protected String moarString;
        public Int32 anotherIntBitesTheDust;
        private Exception internalException;
        protected Exception inheritableException;
        public Exception justException;
        public Stream aStream;
        protected Stream moarStreamz;
        private Stream secretStream;
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Type myType = typeof(HarvestingFields);

           

            string input = Console.ReadLine();
            while (input != "HARVEST")
            {
                foreach (FieldInfo field in myType.GetFields(
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {

                    string modificator = "";

                    switch (input)
                    {
                        case "public":
                            if (field.IsPublic)
                            {
                                modificator += "public ";

                                Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                            }
                            break;
                        case "protected":
                            if (field.IsFamily)
                            {
                                modificator += "protected ";

                                Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                            }
                            break;
                        case "private":
                            if (field.IsPrivate)
                            {
                                modificator += "private ";

                                Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                            }
                            break;
                        case "all":
                            if (field.IsFamily)
                            {
                                modificator += "protected ";
                            }
                            if (field.IsPrivate)
                            {
                                modificator += "private ";
                            }
                            if (field.IsPublic)
                            {
                                modificator += "public ";
                            }
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                            break;
                    }


                }
                input = Console.ReadLine();
            }
        }
    }
}
