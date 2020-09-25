using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hoc_s_shap
{                                                                    // vào đầu thì ra đầu     nó có thể chứa cả Arraylist bên trong
    class bai_36_queue                                                     
    {static void Main(string[] args) {
            #region vd queue
            Queue ten = new Queue();// khởi tạo rỗng
            Queue ten1 = new Queue(5); // khởi tạo có sức chứa
            Queue ten2 = new Queue(ten); // khởi tạo mang đặc điểm của thàng khác

            ArrayList myarray = new ArrayList();
            myarray.Add(1);
            myarray.Add(2);
            myarray.Add(3);
            myarray.Add(4);

            //                                            // nó có thể chứa cả Arraylist bên trong nó khi khởi tạo
            Queue ten3 = new Queue(myarray);

            ten.Enqueue(1); // add phần tử vào đầu
            ten.Enqueue(2);
            ten.Enqueue(5);

            foreach (object bien in ten)
            {
                Console.Write(bien);
            }
            ten.Dequeue();// lấy ra 
            Console.WriteLine();
            foreach (object bien in ten)
            {
                Console.Write(bien);
            }

            #endregion
        }
    }
}
