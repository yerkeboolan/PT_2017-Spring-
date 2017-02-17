using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializable
{
    
        [Serializable]
        public class IAM
        {
      

        public string Name { get; set; }
            public string Sname { get; set; }
            public int Age { get; set; }
            public int Gpa { get; set; }

            public IAM() { }

            public IAM(string name, string sname,  int age, int gpa)
            {
                Name = name;
                Sname = sname;
                Age = age;
                Gpa = gpa;
            }

     
    }
    class Program
    { 
        static void Main(string[] args)
        {
            // объект для сериализации 
            IAM iam = new IAM("Yerkebulan", "Zhumagali",  18, 4);
            Console.WriteLine("Объект создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(IAM));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("iamyerke.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, iam);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация 
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                IAM newIam = (IAM)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}\nGPA: {3}", newIam.Name, newIam.Sname,newIam.Age, newIam.Gpa);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
