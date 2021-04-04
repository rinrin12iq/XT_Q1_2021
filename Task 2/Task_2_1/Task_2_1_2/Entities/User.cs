using System.Collections.Generic;

namespace Task_2_1_2.Entities
{
    public class User
    {
        public List<Figure> UserFigures = new List<Figure>();
        private string _name;

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
