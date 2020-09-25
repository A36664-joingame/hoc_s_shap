using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap                    
{
    class bai_31_dictionary
    {static void Main(string[] args)
        {    // KHÔNG ĐƯỢC TỰ SẮP XẾP MÀ KHI THÊM phần tử NÓ SẼ VÀO CUỐI CÒN HASHTABLE THÌ TỰ SẮP XẾP
                                //xác định kiểu của key và value khi khai báo đối tượng dictionary

            #region khởi tạo dictionary và truy xuất bằng foreach  cần KeyValuePair<>
            Dictionary<int, string> ten = new Dictionary<int, string>();
            ten.Add(18, "nguyen van luc");
            ten.Add(20, "nguyen thi trang");
            ten.Add(43, "nguyen van vu");
            ten.Add(56, "nguyen van hoang");
            // truy xuất bằng foreach
          foreach(KeyValuePair<int,string>bien in ten) // chú ý   keyword KeyValuePair     để có thể dùng nhiều kiểu cho mộ lúc
            {
                Console.WriteLine(bien);// đay là kiểu truy xuất hết
                Console.WriteLine("gia tri key la:"+bien.Key);// truy xuất key ra
                Console.WriteLine("gia tri values la:"+bien.Value);// truy xuất values ra
               
            }


            #endregion


            

         //   Dictionary<int, string, int, int> tenluc = new Dictionary<int, string, int, int>();      // không cho nhiều kiểu khi khai bó Dictionary
        }
    }
}
