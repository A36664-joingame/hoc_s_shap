using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace hoc_s_shap
{
    class bai_37_bitarray // chỉ mang giá trị true(1) false(0)
    {static void Main(string[] args)
        {
            #region CHÚ Ý
            /*
             * Các phép toán AND, OR, NOT, XOR đã được trình bày trong bài TOÁN TỬ TRONG C# các bạn có thể xem lại.
               Các phép toán AND, OR, NOT, XOR phải được thực hiện trên 2 BitArray có cùng độ dài nếu không sẽ báo lỗi.
               Các phép toán AND, OR, NOT, XOR sẽ làm thay đổi cả BitArray gọi nó.
             */
            #endregion
            #region khởi tạo bitarray
            // không thể khởi tạo thành phần rỗng ***
            BitArray ten = new BitArray(5);// gồm 5 phần tử mặc định là 0 hoặc false
            BitArray ten1 = new BitArray(5, true);// gồm 5 phần tử và mang giá trị true
            // khởi tạo từ một mảng bool
            bool[] bien = new bool[] { true, false, true, true, false };
            bool[] bien3 = new bool[] { false, true, true, false, false };
            BitArray ten2 = new BitArray(bien);
            BitArray ten3 = new BitArray(bien3);
            ten3.And(ten2);                                  // nó sẽ sét như bảng chân lí trong toán logic nên số lượng phần tử của hai cái phải bằng nhau
           foreach(bool bien_tam in ten3)
            {
                Console.Write(bien_tam.ToString()+" ");
            }
            ten3.Or(ten2);          // nhớ là sau khi or hay and là các BitArray đều đã thay đổi nên khi dùng tiếp nhớ kiểm tra kĩ
            Console.WriteLine();                     
            foreach (bool bien_tam in ten3)
            {
                Console.Write(bien_tam.ToString() + " ");
            }

            #endregion
        }
    }
}
