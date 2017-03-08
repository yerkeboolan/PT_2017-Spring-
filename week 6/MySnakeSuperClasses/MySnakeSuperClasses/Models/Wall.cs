using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeSuperClasses.Models
{
    [Serializable]
    public class Wall: Drawer
    {
        public Wall(ConsoleColor color, char sign, List<Point> body) : base (color, sign, body)
        {
            
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            Delete(body);
            body.Clear(); 
        

            string filename = string.Format(@"Levels\level{0}.txt", level);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            int row = 0;
            while((line = sr.ReadLine()) != null)
            {
                for (int col = 0; col < line.Length; col++)
                {
                    if(line[col] == '#')
                    {
                        body.Add(new Point(col, row));
                    }
                }
                row++;
            }
            Draw();
        }
        public void Delete(List<Point> body)
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(' ');
            }
            body.Clear();
        }
    }
}
