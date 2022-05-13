using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
     class AddOnePersister : IBottlePersister
     {
          public void Save(List<Bottles> bottles)
          {
               Console.WriteLine($"Was added {bottles.Count} botle/s to cart");
          }
     }
}
