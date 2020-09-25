using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_46_user_event
    {
       static void Main(string[] args)
        {
            bai_46_event hoc = new bai_46_event(1, 1);

          
                hoc.X++;
                Console.WriteLine(hoc.X);



                hoc.valueChanged += Hoc_valueChanged;  // chính là + thêm value





                hoc.Y++;
                Console.WriteLine(hoc.Y);
            
            
        }
        
        private static void Hoc_valueChanged(object sender, EventArgs e)  // chính là value
        {
            // ép kiểu cho sender nên dùng as
            bai_46_event point = sender as bai_46_event;
            Console.WriteLine("tao da vao roi nhe");
        }
    }
}
