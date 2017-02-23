using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MySnakeSuperClasses.Models
{
    [Serializable]
    public class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();


        public Drawer() { }
        public Drawer(ConsoleColor color, char sign, List<Point> body)
        {
            this.color = color;
            this.sign = sign;
            this.body = body;


        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public void save()
        {
            Type t = this.GetType();
            FileStream fs = new FileStream(String.Format("{0}.dat", t.Name), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void release()
        {
            Type t = this.GetType();
            FileStream fs = new FileStream(String.Format("{0}.dat", t.Name), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            if (t == typeof(Wall))
                Game.wall = bf.Deserialize(fs) as Wall;
            if (t == typeof(Snake))
                Game.snake = bf.Deserialize(fs) as Snake;
            if (t == typeof(Food))
                Game.food = bf.Deserialize(fs) as Food;
           fs.Close();
        }





    }
}
