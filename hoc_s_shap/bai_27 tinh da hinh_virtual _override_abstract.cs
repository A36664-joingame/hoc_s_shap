using System;
using System.Collections.Generic;
using System.Text;
// đa hình là các đối tượng của các lớp khác nhau cùng thực hiện một hình thức nhưng lại thực hiện một cách khác nhau
// vd meo,cho,trau cùng thuộc animal cùng thực hiện kêu nhưng lại kêu khác nhau
// virtual là từ khóa dùng để khai báo một phương thức ảo(là phương thức có thể ghi đè được)
// override là từ khóa để đánh dấu phương thức ghi đè được lên phươn thức của lớp cha
                  // phửi có virtual mới có sửa là override
namespace hoc_s_shap
{    // virtual và override như xác định đầu cuối để thực hiện vậy

    #region vd sử dụng virtual và override
    class animal
    {
       public virtual void speak()  // phải virtual để xác định phương thức cần ghi đè
        {
            Console.WriteLine("dong vat dang noi");
        }
    }
    class cho : animal
    {
        public override void speak()  // để thực hiện ghi đè
        {
            Console.WriteLine("con cho dang noi");
        }
    }
    class meo : animal
    {
        public override void speak()      // để thực hiện ghi đè cho phương thức
        {
            Console.WriteLine("con meo dang noi");
        }
    }
    #endregion

    #region khai báo một lớp trừu tương hoặc một phương thức thuần ảo bằng abstract
    abstract class student     // abstract cũng như virtual
    {

    }
    abstract void hoc_sinh()  // hàm ảo hay trong class gọi là phương thức
    {

    }
    // lưu ý khi kể thừa một lớp trừu tượng bạn bắt buộc phải override tất cả các 
    // phương thức thuần ảo nhằm đảm bảo tính hợp lệ cho chương trình

    #endregion
        // abstract chỉ dùng được một class duy nhất
    class bai_27_tinh_da_hinh_virtual__override
    {
        static void Main(string[] args)
        {  // mình muốn cùng phương thức của animal nhưng được sử dụng cho tất cả
            animal cho = new cho();  // nếu không override thì nó sẽ không được thực hiện ghi đè lên
            animal meo = new meo();
            cho.speak();
            meo.speak();
        }
    }
}
