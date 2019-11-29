using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Models
{
    public class Ingredient
    {
        public string Name { get; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
