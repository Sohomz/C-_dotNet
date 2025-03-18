using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingSerialization
{
    class Program
    {
        [Serializable] //used to mark class as serializable
        class Counter
        {
            public int Value {  get; set; }
        }
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            //Deserialization
            try
            {
                using (FileStream fs = new FileStream("counter.dat", FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        counter = (Counter)formatter.Deserialize(fs);
                        Console.WriteLine("Successfullyde serialized counter.");
                    }
                    else
                    {
                        counter = new Counter();
                        Console.WriteLine("File is empty. Initializing new counter");
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.ToString());
                counter = new Counter();
            }
            catch (FileNotFoundException ex)
            {
                counter = new Counter();
                Console.WriteLine(ex.ToString());
            }
            //Serialiaztion
            Console.WriteLine($"Current value: {counter.Value}");
            counter.Value++;

            using (FileStream fs = new FileStream("counter.dat", FileMode.Create))
            {
                BinaryFormatter formatter=new BinaryFormatter();
                formatter.Serialize(fs, counter);
                Console.WriteLine("Successfully serialized the counter");
            }
        }
    }
}
