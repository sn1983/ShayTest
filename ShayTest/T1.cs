using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayTest
{
    public  class T1
    {
        public enum Colors
        {
            Red,
            Yellow,
            Green
        }
        public Colors[] colors_array { get; set; }
       
        public T1()
        {
             this.colors_array = new  Colors[]{ Colors.Red, Colors.Green, Colors.Green, Colors.Yellow, Colors.Red };
        }

        public Colors[] SortByColor() {
            //using buble sort to perform that
            var n = colors_array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (colors_array[j] > colors_array[j + 1])
                    {
                        var tempVar = colors_array[j];
                        colors_array[j] = colors_array[j + 1];
                        colors_array[j + 1] = tempVar;
                    }
            return colors_array;


            
        
        } 
    }
}
