using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai1_nhap_xuat
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello cac ban den voi c#");
            //int a = 18, b = 20, c = 45, d = 55;
            //Console.WriteLine(a);
            // vì trí in ra giá trị trong chuỗi
            //  Console.WriteLine("a,b,d,c= {0} {1} {3} {2}", a, b, c, d);


            // đọc một giá trị từ bàn phím
            //Console.Write("moi ban nhap gi do:");
            //Console.WriteLine("ket qua phep nhap cua ban la: "+Console.ReadLine());  // chả về mã ascci


            //// nhạn bàn phím
            //Console.ReadKey();
            //Console.ReadKey(false);
            //Console.ReadKey(true);

            // nhập dữ liệu cho một biến
            //string a = Console.ReadLine();
            //int c = Console.Read();
            //Console.WriteLine(a);
            //Console.WriteLine(c);

            // vd người dùng muốn nhập vào vừa số vùa kí tự
            Console.Write("nhap msv cua ban:");
            string masv = Console.ReadLine();
            bool sai;
            int tuoi;
            sai = int.TryParse(masv, out tuoi);
            Console.WriteLine(tuoi);// nó sẽ chả ra giá trị là false=0 nếu nhập có suất hiện chữ cái
        }
    }
}
