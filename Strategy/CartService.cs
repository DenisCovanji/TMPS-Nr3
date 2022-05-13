using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class CartService
     {
          private readonly List<Bottles> _bottles;
          private IBottlePersister _persister;

          public CartService(IBottlePersister persister)
          {
               _bottles = new List<Bottles>();
               _persister = persister;
          }
          public void AddBottles(Bottles bottles)
          {
               _bottles.Add(bottles);
          }

          public void Remove(Bottles bottles)
          {
               _bottles.Remove(bottles);
          }

          public void SetPersister(IBottlePersister persister)
          {
               _persister = persister;
          }

          public void PersistBottles()
          {
               _persister.Save(_bottles);
          }

     }
}
