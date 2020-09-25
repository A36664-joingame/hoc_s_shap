using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
// vào cuối ra đầu
namespace hoc_s_shap
{  
    class bai_35_stack_nganxep
    {                                      // vào đầu nhưng lại ra cuối   có thể chưa bât cứ thú gì vd Arraylist
        static void Main(string[] args)
        {
            Stack ten = new Stack();// hàm rỗng
            Stack ten1 = new Stack(5); // hàm có sức chứa
            Stack ten2 = new Stack(ten1);
            // tất cả lấy và đặt vào đều là vị trí cuối
            // vào cuối nhưng lại ra đầu tiên và được sếp lên đầu
            ten.Push(1);
            ten.Push(5);                                        
            ten.Push(3);
            foreach(object bien in ten)
            {
                Console.Write(bien);
            }
            // ten.Pop(); // lấy ra phần tử cuối và xóa luân phần tử đó    ***
            // Console.WriteLine();
            // foreach (object bien in ten)
            // {
            //     Console.Write(bien);
            // }
            // Console.WriteLine();
            //Console.Write( ten.Peek()); // lấy ra phần tử cuỗi nhưng không xóa phần tử đó   ****

            // khởi tạo lấy dữ liệu từ Arraylist
            ArrayList myarray = new ArrayList();
            myarray.Add(1);
            myarray.Add(2);
            myarray.Add(3);
            myarray.Add(4);
            Stack ten9 = new Stack(myarray);
            Console.WriteLine();
            foreach(var bien_tam in ten9)
            {
                Console.Write(bien_tam);
            }
        }
    }
}
