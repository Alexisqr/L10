using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Controllers
{
    using System.Linq;
    using _7.Fectories;
    using _7.Interface;
    using System.Net.NetworkInformation;
    public class OutputWriter
    {
        public void WriteLine(string text) { Console.WriteLine(text); }
    }
    public class InputReader
    {
        internal string ReadLine() => Console.ReadLine();
    }
    public class Engine
    {
        private WeaponController manager;
        private GemFactory gemFactory;
        private InputReader reader;
        private OutputWriter writer;


        public Engine()
        {
            this.manager = new WeaponController();
            this.gemFactory = new GemFactory();
            this.reader = new InputReader();
            this.writer = new OutputWriter();


        }
        public void Run()
        {
            var command = this.reader.ReadLine().Split(';');

            while (command[0] != "END")
            {
                Console.WriteLine(command[0]);
                switch (command[0])
                {
                    case "Create":
                        this.CommandForCreatingWeapon(command.Skip(1).ToArray());
                        break;
                    case "Add":
                        this.CommandForAddingGemToWeapon(command.Skip(1).ToArray());
                        Console.WriteLine("--+---+---+-----+----+---");
                        break;
                    case "Remove":
                        this.CommandForRemovingGemFromWeapon(command.Skip(1).ToArray());
                        break;
                    case "Print":

                    default:
                        break;
                }

                 command = this.reader.ReadLine().Split(';');
            }

            this.writer.WriteLine(this.manager.GetWeapons());
        }

        private void CommandForRemovingGemFromWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);
            this.manager.RemoveGemFromWeapon(weaponName, socketIndex);
        }

        private void CommandForAddingGemToWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);
            var gemType = cmd[2].Split();
            var gem = this.gemFactory.CreateGem(gemType[1], gemType[0]);

            if (gem == null)
            {
                return;
            }
        
            this.manager.AddGemToWeapon(weaponName, socketIndex, gem);
        }

        private void CommandForCreatingWeapon(string[] cmd)
        {
            var weaponName = cmd[1];
            var weaponType = cmd[0].Split();
            var weaponKind = weaponType[1];
            var weaponRarity = weaponType[0];
            Console.WriteLine(weaponName);
            Console.WriteLine (weaponType);
            Console.WriteLine(weaponKind);
            Console.WriteLine(weaponRarity);
            this.manager.CreateWeapon(weaponKind, weaponName, weaponRarity);
        }
    }
}
