using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_47_sudung_listEvent
    {
        static void Main(String[] arge)
        {

            bai_47_listEvent luc = new bai_47_listEvent(1,1);


            luc._valuechage += hamchuyenvao;
            luc.X++;


        }


        public static void hamchuyenvao(object sender , eventmoinay e)
        {


            // làm những thứ ta muốn trong hàm này rồi dùng hàm này chuyền vào event và event có thể sử dụng hàm này


            Console.WriteLine("đã hiểu event");


        }



    }
}
