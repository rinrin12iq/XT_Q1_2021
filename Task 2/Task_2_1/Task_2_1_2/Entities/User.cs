using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2.Entities
{
    public class User
    {
        private string _name;

        public List<Figure> UserFigures = new List<Figure>();

        public User(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

    }
}
