using System;
using System.Collections.Generic;
using System.Text;
// nhớ là interface không thể khởi tạo đối tượng 
// người ta thường đặt tên cho interface bắt đầu bằng chữ I 
namespace hoc_s_shap
    #region lý thuyết và lưu ý khi sử dụng interface
{  // những thằng muốn một quy chuẩn nhất định phải phù hợp mới thực hiện được thì dùng interface
   // không cho đa kế thừa
   // phải thỏa mãn nhiều điều kiện
   // như một khuôn mẫu mà các thành phần phải tuân thủ mới chạy được
    /*
     * không thể khai báo phạm vi truy cập
     * không cần tử khóa override mà vẫn có thể ghi đè được
     *giông phương thức thuần ảo không cân khai báo abstract
     * không cần hàm khởi tạo(constructor) và hàm hủy(destructor)
     * các lớp có thể thực thi nhiều interface cùng một lúc(có trường hợp còn thay thế được tính đa kế thừa)
     * một interface có thể kế thừa nhiều interface nhưng không thể kế thừa bất cứ lớp nào
     * không thể khởi tạo đối tượng
     * chỉ có thể kế thừa từ các interface khác
     * mặc định phạm vi truy cập là public
     */
    #endregion
        interface ten_interface    // cũng gần giống nhưng khác abstractor
    {  
        void speak()
        {
            Console.WriteLine("interface dang noi");
        }
    }
    class noi : ten_interface  //một class kế thừu lại interface 
    {   // phải thực hiện khuôn mẫu của nó
        public void speak()  // bắt buộc tạo lại hàm này vì nó kế thừa từ khuôn mẫu là inteface
        {
            Console.WriteLine("noi dang noi");//có thể nội dung khác nhau nhưng cùng chức năng


        }                                                         // interface là một khuôn mặc định
    }
    class bai_28_interface
    {
        static void Main(string[] args)
        {
            //noi speak = new noi();
            //speak.speak();
            ten_interface speak = new noi();  // câu lệnh nay đã thể hiên tính đa hình
            speak.speak();
            



           
        }
    }
}
