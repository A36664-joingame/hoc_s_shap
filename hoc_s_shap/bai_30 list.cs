using System;
using System.Collections.Generic;  // phải có thư viện này mới sử dụng được generic
using System.Text;

namespace hoc_s_shap
{
    class bai_30_list
    {// chuy xuât đến danh sách của list thì dùng foreach cho nhanh
        static void Main(string[] args)
        {
            // có thể cho class vào trong list nhe vì class cũng chỉ lad kiểu dữ liệu



            #region khai báo và khởi tạo list    một list chỉ chứa được một kiểu duy nhất
            List<int> ten = new List<int>();// một list rỗng
            List<float> ten2 = new List<float>(4); // có sức chứa là 4
            List<float> ten3 = new List<float>(ten2);// list chứa list nhưng phải cùng kiểu hoặc kiểu này có khoảng lớn hơn kiểu kia
          
          //  List<string,float,int,double>= new List<string, float, int, double>();   // không thể chứa nhiều kiểu trong 1 list

            #endregion
            #region một số phương thức của list tự mò trong này chỉ có vài thứ căn bản
            List<string> name = new List<string>(4) { "nguyen van luc", " nguyen thi trang", " nguyen van vu", " duong thi bay" };
            // kiểm tra xem phần tử này có trong list hay không
            bool kiem_tra= name.Contains("nguyen van luc"); // nếu có là true không là false  // xem nó có chứa đựng cái phần tử này không
            Console.WriteLine(kiem_tra);
            // thêm phần tử
            name.Add(" chu van cong"); // thêm được cả dấu cách
            
            foreach(string bien in name)
            {
                Console.Write(bien);
            }
            //tìm kiếm phần tử trong mảng
         int a=name.BinarySearch(" nguyen van vu");  // ở trong list viết thế nào thì đây cũng phải có đủ kể cả dấu cách
            Console.WriteLine("\n{0}",a);
            // đếm số  lượng phần tử
            Console.WriteLine("so luong phan tu co trong list la:{0}",name.Count);
            #endregion

            // có cả kiểu này luân nhé học đến foreach và delegate thì xem lại
            List<string> a = new List<string>() { "nguyen van luc" };
           // a.ForEach((f) => Console.WriteLine(f));      // kiểu viết Các biểu thức lambda (gọi chung là viết tắt)
        }
    }
}
