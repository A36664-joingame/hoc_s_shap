using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_20_struct
    {
        // là kiểu dữ liệu có cấu trúc
        // được kết hợp từ các kiểu dữ liệu nguyên thủy hoặc các kiểu dữ liệu cấu trúc khác
        // là kiểu dữ liệu tham trị 
        // tham trị là tạo ra một bản sao mang thuộc tính hình thái củ cái gốc rồi khi thay đổi nó không bị ảnh hưởng đến giá trị ban đầu
        // tham chiếu là ta dùng thẳng luân giá trị gốc để thay đổi 

        // chú ý struct không được kết thừa
        #region vd một struct đơn giản
        /*  struct sinhvien
          {
              public int tuoi;

          }
          static void Main(string[] args)
          {
              sinhvien luc;
              luc.tuoi = Convert.ToInt32( Console.ReadLine());
              Console.WriteLine(luc.tuoi);


          }  */
        #endregion

        #region nhập điểm của hai sinh vien in ra sinh vien nào có  điểm lớn hơn
       struct mark_sinhvien
        {
          public  double mark;
        }
            // out cứ viết đi lỗi thid viết song mới hết lỗi nhe
        static void nhap_mark(out mark_sinhvien sinhvien1,out mark_sinhvien sinhvien2 )
        {
            Console.Write("nhap diem sinh vien thu nhat:");
            sinhvien1.mark = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nnhap diem sinh vien thu hai:");
            sinhvien2.mark = Convert.ToDouble(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            mark_sinhvien sinhvien1;
            mark_sinhvien  sinhvien2;
            nhap_mark(out sinhvien1,out sinhvien2);
          
            if (sinhvien1.mark > sinhvien2.mark)
            {
                Console.WriteLine("diem lon nhat la={0}", sinhvien1.mark);
            }
            else
            {
                Console.WriteLine("dim sinh vien lon nhat la={0}", sinhvien2.mark);
            }


        }

        #endregion
    }
}
