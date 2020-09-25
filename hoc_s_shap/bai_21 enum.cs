using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
  
    class bai_21_enum
    {
        // khai báo kiểu (LIỆT KÊ) danh sách của một đối tượng dì đó
        // cái nào liệt kê thì dùng
        // khi so sánh phải ép kiểu 
        // enum bắt đầu từu 0
        public enum coller
        {
            RED,
            bluer,
            yellow,

        }
        static void Main(string[] args)
        {
            coller luc = new coller();
            //Console.WriteLine(coller.bluer);

            
        }
        
    }
}
