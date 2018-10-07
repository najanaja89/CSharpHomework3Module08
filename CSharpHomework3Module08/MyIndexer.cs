using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework3Module08
{
    class MyIndexer
    {
        private double[] data;
        private int size;
        public MyIndexer(int size)
        {
            this.size = size;
            data = new double[size];
        }

        public double this[int index]
        {
            get
            {
                return Math.Pow(data[index], 2);
            }
            set
            {
                data[index] = value;
            }
        }

    }
}
