using System;
using System.Collections.Generic;
using System.Text;

// các phạm vi truy cập : public , private , protected , internal , protected internal
namespace hoc_s_shap
{
    #region private và từ khóa set get và các phương thức truy cập
    /*  class student
      {
          private int tuoi;
          private string name;
          private string gioi_tinh;
          // vân có thể tạo các hàm public để truy cập đến các thuộc tính của private như c++
          // nhưng C# hỗ chợ các hàm set và get nhanh hơn và hoàn thiện nhanh chóng hơn

          //tự tạo cho ta hàm get và set trỏ chuột vào cuối thành phần và nhấn Ctrl + R +E
          public string Gioi_tinh {   // get trỏ tới và set trỏ tới
              get => gioi_tinh; 
              set => gioi_tinh = value; } // giá trị value chính là giá trị Gioi_tinh ta chuyền vào
          public string Name { 
              get => name;
              set => name = value; }
          public int Tuoi {
              get
              {
                  return tuoi;
              }
              set
              {
                  if (value > 10) // value là giá trị chuyền vào và chính là Tuoi
                  {
                      tuoi = value;  // giá trị value chính là Tuoi khi chuyền giá trị vào
                  }
              }
          }

          //public int Tuoi1 { 
          //    get => tuoi; 
          //    set => tuoi = value;
          //}

          public void showinfo()
          {
              Console.WriteLine("ten cua sinh vien la:{0}", name);
              Console.WriteLine("tuoi cua sinh vien la :{0}",Tuoi);
              Console.WriteLine("gioi tinh cua sinh vien la:{0}",gioi_tinh);

          }
      }
        */
    #endregion
   
    class bai_24_cac_pham_vi_truy_cap
    {
        #region gọi lại sử lý private
      /*  static void Main(string[] args)
        {
            student luc = new student();
            luc.Gioi_tinh = "nam";
            luc.Name = "nguyen van luc";
            luc.Tuoi = 18;
            luc.showinfo();
        } */
        #endregion
    }
}
