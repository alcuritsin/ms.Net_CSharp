using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenUtensils
{
        public enum TypeFork
        {
            Serving, Dining, Fishing
            //Сервировочная, столовая, для рыбы.
        }
    public class Fork:Silverware
    {
        //  Класс вилка
        public TypeFork _type { get; set; }
    }
}
