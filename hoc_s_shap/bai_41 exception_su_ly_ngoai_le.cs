using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{  /// <summary>
/// phạm vi rộng bắt bên dưới lớn bắt trên
/// </summary>
    class bai_41_exception_su_ly_ngoai_le
    {
        /*
         *   try{
         *        bắt cái throw
         *
         *
         *   }
         *
         *   catch{
         *
         *      sử lý cái throw
         *
         *
         *   }
         *
         *
         */

        /*khi chạy trương trinh có thể phát sinh ra các
         * lỗi thì ta cần phải bắt các ngoại lệ(lỗi)
         * để thực hiện sửa các lỗi
         * vd các lần bạn đăng nhập không thỏa mãn thì nó sẽ bắt lỗi và bắt bạn nhập lại chánh vỡ trương trình
         */
        // ta chỉ lấy vd đơn giản để hiểu thôi nhé

        // các biến cho bằng 0 còn đói tượng cho bằng Student newStudent = null;
        static void Main(string[] args)
        {
            #region vd về try(thử) và catch(bắt)

            Console.Write("moi ban nhap so thu nhat:");
            string number1 = Console.ReadLine();
            Console.Write("moi ban nhap so thu hai:");
            string number2 = Console.ReadLine();
            int so1 = 0;

            // try(thử) và catch(bắt lấy)
            try
            {
                // nghi ngờ cái gì thì cho vào đây để thử
                so1 = Convert.ToInt32(number1);
            }
            catch (FormatException fex) // keyword FormatException
            {
                Console.WriteLine(fex.Message);
                Console.WriteLine(fex.Source);
                Console.Write("\nnhap sai gia tri");
            }
            finally // khối dọn rác // bất kể lỗi hay không đều chạy vào đây
            {
                Console.WriteLine("\nda don rac va chay thanh cong");
            }

            int so2 = 0;
            try
            {
                so2 = Convert.ToInt32(number2);  // ta đang bắt cái ngoại lệ là ép kiểu nếu ép không được nó sẽ vào catch để sử lý thay đổi hoặc đưa ra thông báo gì đó
            }
            catch (FormatException fex)
            {
                Console.WriteLine("nhap sai ");
            }

            int so3 = 0;
            try
            {
                so3 = so1 / so2;   // ta cảm nhận được người dùng sẽ nhập mẫu là 0 sẽ bị lỗi ,lên bắt  người dùng nhập lại hoặc chỉ gửi thông báo thì vào catch sử lý những điều đó
            }
            catch (DivideByZeroException dvx)  // keyword DivideByZeroException xác định số 0
            {
                Console.WriteLine("so bi chia la so 0 len khong chia dc");
                Console.WriteLineO(dvx.ToString());// xem luân lỗi
            }

            #endregion vd về try(thử) và catch(bắt)

            //exception là bố nếu để đầu các con sẽ không thực hiện được vì vậy chỉ để cuối

            //  thường dùng throw để ném lỗi ra và bắt dùng try catch() để bắt nó lại
            //  throw new tên_của_cái_cần_ném(thông điệp);

            Console.WriteLine("\nthuong cua hai so la:{0}", so3);
            Console.ReadKey();
        }
    }
}