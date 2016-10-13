using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games.KillingGame.Roles
{
    public class Killer : Role
    {
       public Killer(uint count) : base(count) { }
    }
}