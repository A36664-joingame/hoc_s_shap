using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;  // vẫn phải sử dụng

                                              // quan trọng nhất của sortedlist là sắp xêp theo key còn hashtable là tự sắp xếp
                                              // có khả năng lưu trũ và tính chất giống với hashtable và dictionary

namespace hoc_s_shap
{  // kế thừa từ arraylist and hashtable
    // là kiểu sắp xếp theo key
    class bai_34__SortedList
    {static void Main(string[] args)
        {
            #region đặc điểm của sortedlist
            /*
             * Là 1 Hashtable nhưng các giá trị được sắp xếp theo Key.
               Việc sắp xếp này được thực hiện một cách tự động mỗi khi thêm 1 phần tử mới vào SortedList.
             * Có thể truy xuất đến các phần tử trong SortedList thông qua Key (như Hashtable) hoặc 
               thông qua chỉ số phần tử (như ArrayList).
             * SortedList chính là sự kết hợp giữa ArrayList với Hashtable.
             * 
             */
            #endregion
            #region khởi tạo sortedlist
            SortedList ten = new SortedList();// khởi tạo rỗng
            SortedList ten1 = new SortedList(5);// khởi tạo có sức chứa
            SortedList ten2 = new SortedList(ten1);// muốn có cái này thì phải nằm trong Main


            // có thể truy xuất index
            /* muốn add cả cái hàm lớn thì phải có toán tử new
            vd Sortedlist ten4=new Sortedlist(new person(tham so));
             */
            #endregion
            // cũng có thể generic luân
            SortedList<int, string> mySortedList = new SortedList<int, string>(10);
            mySortedList.Add(18, "nguyen van luc");
            mySortedList.Add(20, "nguyen thi trang");
            mySortedList.Add(3, "chu tien dat");          // chứng tỏ nó đã sắp xêp theo key
            mySortedList.Add(16, "nguyen thi trang");
            // theo tính đa hình thì nó có thể khởi tạo 
            foreach (KeyValuePair<int, string> bien in mySortedList)
            {
               
                Console.WriteLine(bien.Key);
                Console.WriteLine(bien.Value);
              

            }



        }
    }
}
