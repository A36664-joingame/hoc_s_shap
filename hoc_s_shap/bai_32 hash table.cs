using System;
using System.Collections.Generic; // đủ biết là có hay không
using System.Text;
using System.Collections;// phải có thư viện này mới có Hashtable
// lợi ích vd ta tìm kiếm key="luc"  nó sẽ ra các giá trị như: lực đẹp trai ,học giỏi ,có nhiều người yêu....
namespace hoc_s_shap
{
    // tự động sắp xếp các phần tử theo quy luật của nó mà đéo biết kiểu gì
    class bai_32_hash_table
    {  


         // khai báo kiểu cho key và value chỉ khi Add nên có thể Add nhiều kiểu cho key và value



        #region lý thuyết hashtable
        /*      Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value. 
         *      Key đại diện cho 1 khoá giống như chỉ số phần tử của mảng và Value chính là giá trị tương ứng của khoá đó. 
         *      Ta sẽ sử dụng Key để truy cập đến Value tương ứng.
                Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu     **** chú ý ****
                từ những kiểu cơ sở đến kiểu phức tạp là (class).
                Nếu các Key của Hashtable là các số nguyên tăng dần từ 0 thì
                Hashtable nhìn trông giống ArrayList (chỉ là giống về bề ngoài thôi chứ bên trong rất khác nhau)
         */
        #endregion                              
        static void Main(string[] args)
        {
            #region khởi tạo Hashtable và truy xuất bằng foreach cần  dictionaryEntry
        //    // khởi tạo một hashtable
        //    // không cần xác định kiểu như dictionary
        //    Hashtable ten = new Hashtable(); // khởi tạo rỗng
        //    Hashtable ten2 = new Hashtable(5); // khởi tạo có vũng chứa
        //    ten.Add(18, "nguyen van luc"); //(key,"valuas")
        //    ten.Add(43, "nguyen van vu");
        //    foreach(DictionaryEntry bien in ten) // **** chú ý *****        dictionaryEntry
        //    {
        //        Console.WriteLine("theo key:{0}",bien.Key);   // in ra key
        //        Console.WriteLine("theo value:{0}",bien.Value); // in ra value
        //    }
        //    // truy xuất theo key
        //    Console.WriteLine("gia tri truy xuat theo key:{0}",ten[18]); // điền key vào

        //    // ví dụ ta gán một cái key với một values mới mà trong hashtable
        //    // không có thì nó sẽ tự thêm vào hashtable

        //    ten[40] = "duong thi bay";      //key=40   , value ="duong thi bay"
        //    //nó sẽ tự động thêm vào nếu không có

        //    foreach (DictionaryEntry bien in ten)                     // nó sẽ tự sắp sếp theo một quy luật nào đó
        //    {
        //        Console.WriteLine(bien.Key);
        //        Console.WriteLine(bien.Value);
        //    }

            #endregion


            Hashtable luc = new Hashtable();
            luc.Add(18, 45);                                           // không thể một lúc add nhiều giá trị cho nó
            foreach (DictionaryEntry bien_tam in luc)
            {
                Console.WriteLine(bien_tam.Key);
                Console.WriteLine(bien_tam.Value);
            }
        }
    }
}
