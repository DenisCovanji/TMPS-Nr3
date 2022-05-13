using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class Program
     {
          static void Main(string[] args)
          {
               IBottlePersister oneBottle = new AddTwoPersister();
               IBottlePersister twoBottle = new AddOnePersister();
               IBottlePersister Bax = new AddBaxPersister();

               CartService bottleService = new CartService(oneBottle);

               Bottles Cola = new Bottles("Cola", 22);
               Bottles Fanta = new Bottles("Fanta", 21);
               Bottles ChisinauBlonda = new Bottles("ChisinauBlonda", 24);


               bottleService.AddBottles(Cola);
               bottleService.AddBottles(Fanta);

               bottleService.PersistBottles();

               bottleService.SetPersister(twoBottle);

               bottleService.PersistBottles();

               bottleService.Remove(Cola);
               bottleService.Remove(Fanta);

               bottleService.AddBottles(ChisinauBlonda);
               bottleService.SetPersister(Bax);
               bottleService.PersistBottles();

               Console.ReadKey();
          }
     }
}
