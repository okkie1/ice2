using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice2
{
    public abstract class Burger
    {
        private String storychoice = "Bob's Adventure";
        

        public virtual String getstorychoice()
        {
            this.storychoice = "Bob's Adventure ";
            return this.storychoice;
        }

        
       
    }
}
