using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection();
            fillCollection(ref carCollection);

            Console.WriteLine("Car brands and cars:");
            carCollection.PrintCollection();

            Console.WriteLine("\nFirst value:");
            carCollection.PrintOne(1);

            //add some Porsches, and print all Porsche branded cars
            Console.WriteLine();
            carCollection.AddCars("Porsche", "Spider", "Porsche", "Cayman");
            carCollection.PrintOne("Porsche");

            //remove one value
            Console.WriteLine("\nRemove Volvo:");
            carCollection.RemoveByBrand("Volvo");
            carCollection.PrintCollection();


            Console.WriteLine("\n\nCreate otherCollection1 and otherCollection2");

            CarCollection otherCollection1 = new CarCollection();
            otherCollection1.AddCars("Toyota", "Camry", "Honda", "Accord");
            
            CarCollection otherCollection2 = new CarCollection();
            otherCollection2.AddCars("Mazda", "MX7");
            otherCollection2.AddCars("Toyota", "Corolla");

            Console.WriteLine("\nAre the the new collections equal length?");
            Console.WriteLine(otherCollection1==otherCollection2);

            Console.WriteLine("\nAre carCollection and otherCollection1 equal length?");
            Console.WriteLine(carCollection==otherCollection1);

            //remove all values from carCollection
            Console.WriteLine("\nClear whole collection (delete values)");
            carCollection.RemoveAll();
            Console.WriteLine("carCollection now:");
            carCollection.PrintCollection();

            Console.WriteLine("\nEnd of Program...");
            Console.ReadKey();
        }

        static void fillCollection(ref CarCollection carCollection)
        {
            carCollection.AddCars("Toyota", "Camry");
            carCollection.AddCars("Honda", "Accord");
            carCollection.AddCars("Ford", "Mustang");
            carCollection.AddCars("Tesla", "Model 3");
            carCollection.AddCars("BMW", "X5");
            carCollection.AddCars("Chevrolet", "Camaro");
            carCollection.AddCars("Nissan", "GT-R");
            carCollection.AddCars("Audi", "A6");
            carCollection.AddCars("Mercedes-Benz", "E-Class");
            carCollection.AddCars("Volkswagen", "Golf");
            carCollection.AddCars("Subaru", "Impreza WRX");
            carCollection.AddCars("Lexus", "RX");
            carCollection.AddCars("Hyundai", "Elantra");
            carCollection.AddCars("Kia", "Stinger");
            carCollection.AddCars("Volvo", "S60");
            carCollection.AddCars("Mazda", "MX-5");
            carCollection.AddCars("Porsche", "911");
            carCollection.AddCars("Jaguar", "F-Type");
            carCollection.AddCars("Land Rover", "Range Rover");
            carCollection.AddCars("Ferrari", "812 GTS");
        }

    }
}
