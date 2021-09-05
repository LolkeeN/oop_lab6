using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab6
{
    abstract class CGraphicsObject
    {
        private String name;
        double square;

        public virtual double getSquare()
        {
            return square;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public virtual String show()
        {
            return this.GetType().ToString();
        }

        public virtual String getClassName()
        {
            return this.GetType().ToString();
        }

    }
}
