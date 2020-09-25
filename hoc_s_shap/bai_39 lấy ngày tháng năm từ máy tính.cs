using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hoc_s_shap
{
    class bai_39_lấy_ngày_tháng_năm_từ_máy_tính
    {
        // lấy ngày giờ hiên tại của hên thống
        static Tuple<int, int, int,float> get_nam_thang_ngay()
        {
            DateTime ngay_he_thong = DateTime.Now;
            return Tuple.Create<int, int, int,float>(ngay_he_thong.Day, ngay_he_thong.Month, ngay_he_thong.Year,ngay_he_thong.Second);

        }
        static void Main(string[] args)
        {
            var ngay_may = get_nam_thang_ngay();
            Console.WriteLine("-------------ngay thang nam ---------");
            Console.Write("ngay:{0}\\thang:{1}\\nam:{2}", ngay_may.Item1, ngay_may.Item2, ngay_may.Item3);
            Console.WriteLine("\n{0}", ngay_may.ToString());
           

        
            Console.ReadKey();

        }
    }
}
