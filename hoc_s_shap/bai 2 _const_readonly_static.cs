using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai2_const_readonly_static
    {
        static void Main(string[] args)
        {
            // const không cho thay đổi giá trị
            const int a = 10;
            Console.WriteLine(a);

            // readonly sử dụng như hằng số lúc thực thi
            readonly int tuoi;

            /*    Từ khóa static được sử  dụng để tạo một biến hoặc một thành phần tĩnh,
                    nghĩa là giá trị của nó sẽ được chia sẻ cho toàn bộ các đối tượng và
                    không gắn vào một đối tượng cụ thể nào.
                    Từ khóa static có thể được áp dụng cho cả class, fields, properties,
                operators, events, constructor nhưng không dùng được cho index, destructors,
                hay kiểu nào hơn các classs. */
            static int b = 20;
        }
    }
}