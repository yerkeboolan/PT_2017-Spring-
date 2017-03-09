using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationComplex
{
  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BinaryFormatter serialization/deserialization\n");
            binaryFormatter();
        } 

        private static void binaryFormatter()
        {
            // Serialization
            Complex a = new Complex(245, 365);
            Complex b = new Complex(554, 998);
            Complex c = new Complex(7845, 8564);
            FileStream fileStream = new FileStream("complex.bf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, a);
            binaryFormatter.Serialize(fileStream, b);
            binaryFormatter.Serialize(fileStream, c);

            fileStream.Close();

           fileStream = new FileStream("complex.bf", FileMode.Open, FileAccess.Read);
            //Deserialization

            Complex newA = binaryFormatter.Deserialize(fileStream) as Complex;
            Complex newB = binaryFormatter.Deserialize(fileStream) as Complex;
            Complex newC = binaryFormatter.Deserialize(fileStream) as Complex;

            Console.WriteLine(newA + "\n");
            Console.WriteLine(newB + "\n");
            Console.WriteLine(newC);


            fileStream.Close();


            Console.ReadKey(); 


        }

    }
}
