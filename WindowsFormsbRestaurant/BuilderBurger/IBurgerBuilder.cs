using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsbRestaurant.BuilderBurger;
using WindowsFormsbRestaurant.DBCon;

namespace WindowsFormsbRestaurant.BuilderBurger
{
    internal interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese();
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddLetuce();
        IBurgerBuilder AddTomato();
        IBurgerBuilder AddPickles();
        Burgers GetBurgers();

    }
}
