using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai3_ep_kieu
    {
        static void Main(string[] args)
        {
            #region chuyển đổi kiểu ngầm định chỉ dành cho lớn hơn chứa nhỏ hơn vd long chứa int
            //// chuyển đổi kiểu ngầm định chỉ dành cho lớn hơn chứa nhỏ hơn
            //int k = 10;
            //long l = k;
            #endregion

            #region  chuyển đổi kiểu tường minh
            //// chuyển đổi kiểu tường minh
            //int a = 10;
            //byte c = (byte)a;
            //int d = 5, b = 2;
            //float h = (float)d / 2;
            //// h=d*1.0f/2
            //Console.WriteLine(h);
            #endregion


            #region ép kiểu bằng parse 
            //nhưng khi chuyển nhầm nó không biết có sai hay không
            // ép kiểu bằng parse từ chuỗi sang số (chuỗi phải là số)
            //string l = "10";
            //int a = int.Parse(l);
            //Console.WriteLine(a);
            #endregion

            #region ép kiểu bằng tryparse
            // kể cả ép sai thi nó cũng in ra giá trị kiểu bool
            // ép kiểu bằng tryparse(biến muốn ép ,out biến nhận kq)  từ chuỗi
            //bool s;
            //string luc = "10";
            //int tuoi;
            //s = int.TryParse(luc, out tuoi);
            //Console.WriteLine(tuoi);
            #endregion


            #region ép kiểu bằng Convert
            // ép kiểu bằng Convert
            Console.Write("nhap tuoi cua ban:");
            string tuoi = Console.ReadLine();
          int a=  Convert.ToInt32(tuoi);
            Console.WriteLine("tuoi cau ban la:{0}",a);
            #endregion


        }
    }
}
