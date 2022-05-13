using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
     class AddTwoPersister : IBottlePersister
     {
          public void Save(List<Bottles> bottles)
          {
               Console.WriteLine($"Was added {bottles.Count * 2} botle/s to cart");
          }
     }
}
