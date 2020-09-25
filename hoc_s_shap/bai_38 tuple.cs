using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace hoc_s_shap
{
    #region một số về tuple
    /*
     * Tuple là một kiểu dữ liệu có cấu trúc,
     * giúp lưu trữ các dữ liệu phức tạp mà không cần phải tạo ra một struct 
     * hay class mới (Nếu bạn nào chưa nắm về kiểu dữ liệu có cấu trúc cũng như struct, 
     * class thì có thể xem lại bài STRUCT TRONG C# và CLASS TRONG C#).
     */
    #endregion
    #region cách dùng tuple
    /*Trường hợp đầu tiên là khi bạn viết một phương thức và muốn trả về 1 lúc nhiều giá trị. 
     * Lúc này Tuple sẽ giúp bạn dễ dàng giải quyết mà không cần phải tạo thêm struct hay class.
      Trong nhiều trường hợp khác bạn chỉ muốn tạo nhanh 1 đối tượng với 1 vài thuộc tính và 
    chỉ sử dụng 1 lần thôi thì việc dùng struct hoặc class là rất lãng phí,
    làm chương trình của bạn trở nên dài dòng hơn.
    Khi đó Tuple được sử dụng như một phương án thay thế tốt hơn vì
    có sẵn rồi giờ lấy ra dùng thôi không cần khai báo gì nữa.
      Ngoài ra, Tuple đã override sẵn:
      Phương thức Equals (phương thức dùng để so sánh 2 đối tượng).
      Phương thức ToString (Phương thức chuyển giá trị đối tượng sang chuỗi).
      Phương thức GetHashCode (Phương thức trả về mã băm của một đối tượng, dùng để hỗ trợ so sánh 2 đối tượng).
     */
    #endregion
    class bai_38_tuple
    {// tuple như kiểu dữ liệu có nhiều thuộc tính bên trong cũng như struct và class
        // truy xuất bằng từng item một
        static void Main(string[] args)
        {
            #region khởi tạo tuple
            //// khởi tạo bằng từ khóa var vì không biế trước kiểu dữ liệu cho nó
            //// tổng cộng có 8 lần dữ liệu có thể chuyền vào
            //var bien = Tuple.Create<int>(18); // kiểu khởi tạo có một dữ liệu
            //var bien2 = Tuple.Create<int, string, int, char, double,float>(1, "nguyen van luc", 6, 'A',4.5,3.6f);
            //// khởi tạo thồn qua contructor băng toán tử new
            //var bien3 = new Tuple<int, string, char>(18, "nguyen van luc", 'l');
            #endregion
            #region truy xuất phần tử từ tuple
            //Console.WriteLine(bien.Item1); // truy xuất bằng item
            //Console.Write("item1={0},intem2={1},item3={2},intem4={3},intem5={4},intem6={5}", bien2.Item1, bien2.Item2, bien2.Item3, bien2.Item4, bien2.Item5, bien2.Item6);
            //Console.ReadLine();
            #endregion

            var ngay_may = get_nam_thang_ngay();
            Console.WriteLine("-------------ngay thang nam ---------");
            Console.Write("ngay:{0}\\thang:{1}\\nam:{2}", ngay_may.Item1, ngay_may.Item2, ngay_may.Item3);
            Console.WriteLine("\n{0}",ngay_may.ToString());
            Console.ReadKey();

            
            
            
            
        }
        // lấy ngày giờ hiên tại của hên thống
        static Tuple<int, int, int> get_nam_thang_ngay()
        {
            DateTime ngay_he_thong = DateTime.Now;
            return Tuple.Create<int, int, int>(ngay_he_thong.Day, ngay_he_thong.Month, ngay_he_thong.Year);

        }
         Tuple<int, string, double, float, char> aLotOfType = new Tuple{ 12, "nguyen van luc", 12.4, 4.5f, 'e' };
        
    }
}
