using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai6_object_var_dynamic
    {
        static void Main(string[] args)
        {
            #region kiểu object là thánh có thể chứa tất cả
            //// kiểu object chả về kiểu dữ liệu của đối tượng
            //object tuoi = 18;
            //tuoi.ToString();           // đưa thành chuỗi
            //Console.WriteLine(tuoi);
            //tuoi.GetType();  // trả về lại kiểu dữ liệu của đối tượng
            //Console.WriteLine(tuoi);
            //tuoi.GetHashCode();  // trả về mã băm
            //Console.WriteLine(tuoi);
            #endregion


            #region từ khóa var
            /*   // từ khóa var  máy tự xác định kiểu cho giá trị, phải có giá trị ban đầu
               var name = "nguyen van luc";

               Console.WriteLine(name);   */
            #endregion


            #region kiểu dynamic 
            /*     // kiểu dynamic  chỉ xác định kiểu khi chạy trương trình
                 dynamic ten;
                 ten = "nguyen van luc";
            //     ten++;   // chưa sai cho đến khi nó chạy trương trình 
            // nếu đúng vẫn chạy nếu sai thì dừng
                 Console.WriteLine(ten);  */
            #endregion


            #region kỹ thuật boxing and unboxing 
            // kĩ thuật boxing and unboxing  có trong object
            /* int a = 10;
             object hop;
             hop = a;     // đưa vào hộp
             int c = (int)hop; // dùng một biến khác để mở hộp lấy giá trị trong hộp phải ép kiểu phù hợp với vật chuyền vào
             Console.WriteLine(c);  */

            #endregion





        }
    }
}
