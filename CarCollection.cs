using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    internal class CarCollection
    {
        private NameValueCollection collection;

        public CarCollection()
        {
            this.collection = new NameValueCollection();
        }

        //Add function
        public void AddCars(params string[] brandOrModel)
        {
            if(brandOrModel.Length % 2 != 0) 
            {
                Console.WriteLine("Brand and Model pairs are expected.");
                return;
            }

            for(int i = 0; i < brandOrModel.Length-1; i+=2)
            {
                collection.Add(brandOrModel[i], brandOrModel[i+1]);
            }
        }

        //Remove function
        public void RemoveByBrand(string brand)
        {
            collection.Remove(brand);
        }

        //Clear function
        public void RemoveAll()
        {
            collection.Clear();
        }

        //AllKeys attribute
        public void PrintCollection()
        {

            foreach (string brand in collection.AllKeys)
            {
                Console.WriteLine($"Brand: {brand} - Model(s): {collection[brand]}");
            }

        }

        //Get function
        public void PrintOne(int index)
        {
            string brand = collection.GetKey(index);
            Console.WriteLine($"Brand: {brand} - Model: {collection.Get(index)}");
        }

        public void PrintOne(string brand)
        {
            Console.WriteLine($"{brand} branded car model(s): {collection.Get(brand)}");
        }


        //compare 2 collections (== overloadning)
        //Count attribute
        public static bool operator ==(CarCollection c1, CarCollection c2)
        {
            return c1.collection.Count == c2.collection.Count;
        }

        public static bool operator !=(CarCollection c1, CarCollection c2)
        {
            return c1.collection.Count != c2.collection.Count;
        }

    }
}
