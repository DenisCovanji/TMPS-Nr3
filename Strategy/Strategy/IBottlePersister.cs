using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
     interface IBottlePersister
     {
          void Save(List<Bottles> bottles);
     }
}
