using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationComplex
{
   internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BinaryFormatter serialization/deserialization\n");
            binaryFormatter();
        } 

        private static void binaryFormatter()
        {
            // Serialization
            var a = new Complex(243, 869);
            var b = new Complex(68, 134);
            var c = new Complex(4679, 4978);
            FileStream fileStream = new FileStream("complex.bf", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, a);
            binaryFormatter.Serialize(fileStream, b);
            binaryFormatter.Serialize(fileStream, c);
            fileStream.Close();

           fileStream = new FileStream("complex.bf", FileMode.Open, FileAccess.Read);
            //Deserialization

            var newA = binaryFormatter.Deserialize(fileStream) as Complex;
            var newB = binaryFormatter.Deserialize(fileStream) as Complex;
            var newC = binaryFormatter.Deserialize(fileStream) as Complex;

            fileStream.Close();

            Console.WriteLine(newA + "\n");
            Console.WriteLine(newB + "\n");
            Console.WriteLine(newC);

            
            Console.ReadKey(); 


        }

    }
}
