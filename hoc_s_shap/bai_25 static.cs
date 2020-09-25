using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_25_static
    {
        #region lý thuyết về thành viên tĩnh
        /*thành viên tĩnh
         * chỉ có thể sử dụng khi khởi tạo đối tượng
         * dữ liệu thuộc về riêng mỗi đối tượng (sét cùng một thuộc tính thì các đối tượng khác nhau thì thuộc tính đó sẽ mang các giá trị khác nhau
         *được gọi thông qua tên của đối tượng 
 *      đoi lúc người lập trình muốn 1 thuộc tính nào đó được dùng chung mọi đối tượng chỉ được cấp phát một vùng nhớ duy nhất
 *    -  ĐẶC ĐIỂM CỦA THÀNH VIÊN TĨNH:
 *      được khởi tạo một lần duy nhất ngay khi biên dịch chương trình
 *      có thể dùng chung cho mọi đối tượng
 *      được gọi thông qua tên lớp
 *      được hủy khi kết thúc trương trình
 *       
 */
        // khi ta lưu giá trị cho một biến tạo một lần nhưng không bị reset lại giá trị 
        // bắt buộc gọi qua tên lớp

        #endregion

        #region trương hợp dùng static
        /* một hàm mà muốn sử dụng bình thương trong class 
        mà khi ta không muốn tạo một đối tượng cụ thể để gọi 
            lại hàm đó thì ta dùng static trước kiểu của tên hàm */


        #endregion

        #region lý thuyết lớp tĩnh
        // chỉ chứa các thành phần tĩnh
        // không thể khai báo hoặc khởi tạo một đối tượng  của lớp tĩnh
        #endregion

        // muốn sài phương thức hay thuộc tính static nào trong lớp thì cũng cần 
        // phải tạo ra các phương thức static để truy cập đến nó
        // CHú ý (chỉ trong class thì dùng kiểu đấy còn ở ngoài dùng tên class gọi bình thường)


        static void Main(String[] args)
        {
            vailol a = new vailol();
            a.Test2();

        }

    }

    static class vailol
    {
        static void Test()
        {
            Console.WriteLine("đầu buồi");
        }
        public void Test2()
        {
            Console.WriteLine("địt");
        }

        public void lol()
        {
            vailol a = new vailol();

            Test();
        }

    }

  

}
