using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;   // phải có thư viên này

namespace hoc_s_shap
{
    class bai_18_ham_tinh_thoi_gian
    {
        static void Main(string[] args)
        {
            Stopwatch tinh_thoi_gian = new Stopwatch();   /// khởi tạo hàm tính thời gian

            tinh_thoi_gian.Start();  //để ở đầu câu lệnh cần tính
            for(double i = 0; i < 10000; i++)
            {
                Console.WriteLine("hello luc dep trai");
            }

            tinh_thoi_gian.Stop();   // đặt cuối câu lệnh cần tính
            // cách in ra thời gian vừa tính
            Console.WriteLine("thoi gian tinh theo giay={0},thoi gian tinh theo mli giay={1}", tinh_thoi_gian.Elapsed.Seconds, tinh_thoi_gian.Elapsed.Milliseconds);

        }
    }
}
