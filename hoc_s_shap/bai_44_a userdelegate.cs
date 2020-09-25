using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hoc_s_shap
{
  /// <summary>
  /// có khả năng trỏ đến cái hàm đấy và sử dụng lại không thể thay đổi hàm đó muốn thay đổi chỉ có vào hàm chính để thay đổi
  /// có thể dùng cho cộng hàm nhiều lần lên  
  /// có thể gọi tất cả các hàm cùng một lúc để sử dụng nếu chuyền đủ paramenter cho nó 
  /// như ta có một hàm nhập ta muốn có nhiều hàm nhập thì ta có thể cộng hàm để tăng hàm đó lên
  /// </summary>

    class bai_44_a_userdelegate
    {
            #region cách sử dụng đơn giản vãi lol
            // ta có một kiểu dữ liệu hàm của delegate
            delegate void kie_du_lieu_nha();   // chỉ là kiểu dữ liệu
                                               // nếu cái hàm mà ta trỏ đến có tham số thì delegate cũng phải có đủ paramenter(tham số) chuyền vào
                                               // và kiểu dữ liệu của delegate cũng phải giống với kiểu mà hàm muốn trỏ vào

            delegate void kieu(ref int a, ref int b,ref int c);  // kiểu có paramenter(tham số) chuyền vào


            delegate void kieu2( ref string a, ref string b);

        delegate void kieu3(ref string a);

            public void de_mo()
            {
                 // khởi tạo đối tượng mang tính chất của delegate
               
                kie_du_lieu_nha bien = new kie_du_lieu_nha(ham_binh_thuong);
                // như kiểu cái biến này trỏ tới cái hàm kia
                // tăng số lượng của hàm
                bien += new kie_du_lieu_nha(them_mot_ham);  // có thể làm như thế này luân
                                                            // người ta gọi là mulltiDelegate
                                                            // bien(); // muốn sử dụng thì là như này như ta tạo một cái hàm tạo vậy

            // có cả kiểu mày cũng là mulltiplay

            kie_du_lieu_nha bien1 = new kie_du_lieu_nha(ham_binh_thuong);
                kie_du_lieu_nha bien2 = new kie_du_lieu_nha(them_mot_ham);
                kie_du_lieu_nha bien3 = bien1 + bien2;   // như kiểu cộng hàm
                                                         // gọi từng thằng nha không phải gọi cùng lúc đâu
                                                         // nó gióng như queue
                                                         // bien3(); // chỉ cần gọi biến 3


                // chuyền tham số parmenter
      // paramenter của delegate phải trùng với số pramenter của hàm chuyển vào,hàm chuyền vào phải có đủ số paramenter của delegate mới gọi được
                         kieu ten_bien = new kieu(ref ham_sum) + new kieu(ref ham_sum);  // cộng hàm  // hàm sum có đủ parmenter thì có thể cho vào
              //  int a = 3, b = 5;
              //  ten_bien(ref a, ref b);  // nhớp cách dùng ref nhe nó cũng chỉ là tham chiếu thôi

            // có cả kiểu  này luân nha nhanh gọn nhẹ dùng chỉ một lần rồi vứt như phò

            //kieu2 luc = new kieu2(( ref string a, ref  string b) => { Console.WriteLine(a + b); }) + new kieu2(( ref string a,  ref string b) => { Console.WriteLine(Convert.ToInt32(a) * Convert.ToInt32(b)); }) + new kieu2((ref string a,  ref string b) => { a = Console.ReadLine(); b =Console.ReadLine(); });
            //string a;
            //string b;
           // luc( ref  a, ref  b);  // bắt buộc phải chuyền giá trị cho nó

            // giông kiểu void ten(ref string){Console.ReadLine()};
           kieu3 luc1 = new kieu3((ref string a) => { Console.ReadLine(); }) + new kieu3((ref string a) => { Console.WriteLine(a); });


           
            List<string> a = new List<string>() { "nguyen van luc" };
            a.ForEach((f) => Console.WriteLine(f));


        }
            public void ham_binh_thuong()
            {
                Console.WriteLine("nguyen van luc dep trai");
            }

            public void them_mot_ham()
            {
                Console.WriteLine("dieu ai cung biet");
            }

            public void ham_sum(ref int a,ref int b,ref int c)  // không có public cũng được nha
            {
                Console.WriteLine(a*b *c);
            }

            public void ham_tich(ref int a, ref int b)
            {
                Console.WriteLine(a * b);
            }

            public void nhap(ref int a, ref int b)
            {

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

    
        }
            #endregion
        
    }
}
