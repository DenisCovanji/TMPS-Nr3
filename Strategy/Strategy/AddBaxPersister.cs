using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
     class AddBaxPersister : IBottlePersister
     {
          public void Save(List<Bottles> bottles)
          {
               Console.WriteLine($"Was added {bottles.Count*6} botle/s to cart");
          }
     }
}
