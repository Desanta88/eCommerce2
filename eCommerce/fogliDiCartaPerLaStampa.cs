﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class FogliDiCartaPerLaStampa:Cancelleria
    {
        private float grammatura { get; set; }
        public FogliDiCartaPerLaStampa(string pro, string name, string desc, int price,int s,float gramm) : base(pro, name, desc, price,s)
        {
            this.grammatura = gramm;
        }
        public FogliDiCartaPerLaStampa()
        {

        }
    }
}
