using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class Bottles
     {
          public string Id { get; }
          public decimal Price { get; }

          public Bottles(string id, decimal price)
          {
               Id = id;
               Price = price;
          }

     }
}
