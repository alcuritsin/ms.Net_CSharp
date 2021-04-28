using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenUtensils
{
    public enum TypeKnife
    {
        Sirloin, Universal, Chif
        // Филейный, Универсальный, Поворской :) 
    }
    public class Knife:Silverware
    {
        public TypeKnife _type { get; set; }
    }
}
