using HealthClinic.Excaption;
using HealthClinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Menu
{
    public sealed class SpecialtyMenu
    {
        private readonly ISpecialtyUtility _util;
        public SpecialtyMenu(ISpecialtyUtility util) => _util = util;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n--- Specialty Menu ---");
                Console.WriteLine("1. Add Specialty");
                Console.WriteLine("2. Update Specialty");
                Console.WriteLine("3. Deactivate Specialty");
                Console.WriteLine("0. Back");
                Console.Write("Select: ");
                var ch = Console.ReadLine();

                try
                {
                    switch (ch)
                    {
                        case "1":
                            Console.Write("Name: ");
                            _util.AddSpecialty(Console.ReadLine() ?? "");
                            Console.WriteLine("Added.");
                            break;
                        case "2":
                            Console.Write("Specialty ID: ");
                            var id = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Name: ");
                            var name = Console.ReadLine() ?? "";
                            Console.Write("Is Active (true/false): ");
                            var active = bool.Parse(Console.ReadLine() ?? "true");
                            _util.UpdateSpecialty(id, name, active);
                            Console.WriteLine("Updated.");
                            break;
                        case "3":
                            Console.Write("Specialty ID: ");
                            var did = int.Parse(Console.ReadLine() ?? "0");
                            _util.DeleteSpecialty(did);
                            Console.WriteLine("Deactivated.");
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (healthClinicException ex) { Console.WriteLine($"Error: {ex.Message}"); }
            }
        }
    }
}
