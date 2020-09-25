using System;
using System.Collections.Generic;
using System.Text;
using System.Collections; // để có thể dùng các thành phần

namespace hoc_s_shap
{
    // cách sử dụng nó như một cái mảng    có thể Add nhiều thẻ loại cho nó và truy xuất nó một cách phù hợp mới truy xuất được

    // lợi ích của nó so với Array bình thường là có thể Add được nhiều kiểu cho nó mà Array bình 
    //thường chỉ có thể chung kiểu khai báo ngay từ
    // ban đầu muốn Add vào Array bình thương thì chỉ có thể ép kiểu sáng cùng loại không thẻ ép kiểu từ string sang int

    class bai_33_arraylist
    {
        static void Main(string[] args)
        {
            #region khởi tạo arraylist

            ArrayList ten = new ArrayList();// khởi tạo rỗng
            ArrayList ten2 = new ArrayList(4);// khởi tạo có số lượng sức chứa
            ArrayList ten3 = new ArrayList(ten2); // chứa luân thằng khác
                                                  // tạo một bản sao
            ten3.Clone(); // giống và chứa luân thằng mà bạn sao chép
            ten.Add("B");
            ten.Add("A");
            ten.Add("g");
            ten.Add("a");                                  // cũng có thể Add được nhiều kiểu vào trong nó nhưng khi chuy xuất phải là kiểu phù hợp var
            ten.Add("c");
            ten.Add(12);
            ten.Add(4.5);
            //  ten.Add(1);
            //foreach (string bien in ten)
            //{
            //    Console.Write(bien);
            //    Console.Write("truy xuat den vi tri:{0}",bien.);
            //}
            int c = ten.Count;
            for (int i = 0; i < c; i++)
            {                                       // có thẻ truy xuất các phần tử theo vị trí
                Console.Write(ten[i]);
            }
            //ten.Sort();
            //Console.WriteLine();
            //foreach (string bien in ten)
            //{
            //    Console.Write("{0}", bien);

            //}
            //ArrayList ten4 = new ArrayList(ten);                // chứa hoàn toàn được dữ liệu của tên khác kể cả khác kiểu
            //ten4.Add(45);
            //foreach (var bien_tao in ten4)
            //{
            //    Console.Write(bien_tao);
            //}

            #endregion khởi tạo arraylist
        }
    }
}