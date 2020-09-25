using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hoc_s_shap
{
    class bai_22__Regular_Expression
    {static void Main(string[] args)
        {
            #region   các định dạng

            /*
             
            chú ý : \d  và \d+  ta có chuỗi 51235 nếu \d thì nó sẽ lấy hết nhưng tách ra còn khi \d+ nó cũng lấy hêt nhưng không  tách mà để lên mọt dòng

            . là lấy tất cả kể cả số hay chứ cúng hiện tất nhưng khồng dùng trên một dòng
            + xuất hiện nhiều lần VD \d+  xuất hiện nhiều số
            \. đại diện cho các kí tự , ngoại trừ kí tự \n
            \d kí hiệu số từ 0->9 ,[0-9]
            \D ngược lại của \d LẤY KÍ HIỆU CHỮ
            \s lấy kí hiệu khoảng chống
            \S lấy ra tất cả kí hiệu ngoài khoảng trống
            \w láy ra [a-z,A-Z,0-9] trừ  kí hiệu đặc biệt @ # % *
            \W ngược lại của \w
            ^ lấy ra thằng ở đầu chuỗi (bắt đầu chuỗi hoặc dòng)  VD: nguyen van luc nguyen -> ^nguyen     KQ: nguyen ở đầu             vd 51235 ta dùng ^5 thì nó lấy ở đầu
            $ lấy thằng cuỗi Vd: luc nguyen van luc ->luc&   KQ:  luc (nằm đầu cuối)        vd 51235 khi dùng 5$ nó sẽ lấy thằng 5 ở cuối
            \A bắt đầu chuỗi
            \z ết thúc một chuỗi
            | tưng tự 0rr kết hợ nhiều điều kiện   Vd:  nguyen ->   n|e   KQ:  n e
            [abc] lấy ra các kí tự nằm trong (ko ra một cụm)
            [a-Z] lấy ra tất cả các kí tự trỏng khoảng (không ra một cụm)  ta có thể set khoảng cho nó vd [a-c] thì nó sẽ lấy các kí tự khaongr a c
            [0-9] lấy ra tất cả các số có trong khoảng

            CHÚ Y : cứ thêm ^ vào là phủ định

            ()     giống như trong ngoặc trước ngoài ngoặc sau
            1? giống với tư đúng trước 0 hay 1 lần                  vd  5235  ta thấy số 5 thứ hai khớp với số 5 thứ nhất một lần và số 5 thứ nhất không khớp với số nào, khi ta dùng 5? thì nó sẽ ra số 5 trước và 5 sau
            1* giống với từ đứng trước 0 lần trở lên          
            1+ giống với từ đứng trước 1 lần trở lên

            0{số lần xuất hiện của số}       số nào cũng được nha
            {n,}
            {m,n}
            (m<n)
             
            (.)  vd có 3 thằng giống nhau thì chỉ lấy hai thằng , nếu có 2 thằng giồng nau chỉ lấy một thằng từ trái sang phải  VD: nguyen van luc nguyen van luc nguyen van luc  // nguyen van luc(.)   nó sẽ lấy ra 2 thằng nguyễn văn lực ở đầu

            (.*) thì nó sẽ lấy ra tất vì * nó khớp với từ đứng trước 0 lần trở lên có nghĩa là nhiều lần cũng được và kq trên cùng hàng

            (.*?) thì nó sẽ lấy hết nhưng nó sẽ không cùng trên một dòng  

             nếu muốn dùng kí tự / mà không phải cảu regex thì thêm '/  nháy đơn vào

            (?<word>\w+) nối một hoặc nhiều kí tự

            \s+ ghép một hoặc nhiều kí tự khoảng trắng


            // lấy ra một dòng sau dòng khác
            (?<=   thứ đằng trước thứ cần tìm   ).*?(?=") // dấu " là dấu kết thúc cảu thứ cần tìm cần điền dấu thích hợp ở đay chỉ là vd dừng ở dấu " 

             
             */

            #endregion








            //// biểu thức chính quy
            //// chủ yếu dùng cho cắt chuỗi lấy ra các phần tử trong chuỗi cực nhanh và dẽ hiểu tuy mk chưa hiểu

            Regex ten = new Regex(@"\d");  // cái này là cái cắt chính
            Match ten1 = ten.Match("nguyen van luc 16062001");
            #region cách 1 lấy không đủ
            Console.WriteLine(ten1.ToString()); // chỉ lấy được phần tử đầu

            //#endregion





            #region cách 2 lấy hết
            while (ten1 != Match.Empty) // Empty xem chuỗi có rông hay không
            {
                Console.WriteLine(ten1.ToString());
                ten1 = ten1.NextMatch(); // lấy ra thằng thỏa mãn điều kiện Rgex tiếp theo 
            }
            #endregion





            #region cách 3 cũng lấy hết nhưng nhanh hơn cách này hay nhất vì nhanh chòng
            foreach (Match ten_bien_tam in ten.Matches("nguyen van luc 160601"))   ///kiểu là kiểu Match
            {                              // thêm es là nhiêu thằng không có là một thằng
                Console.WriteLine(ten_bien_tam.ToString());
            }

            #endregion




            #region Group and Groupcollection   được cái là ngăn cách bằng cách đặt tên  thì gom nhóm chúng bằng cách đặt tên thì gọn hơn   như kiểu muốn có một nhóm cụ thể ta muốn lấy ra bằng tên
            // tạo một biểu thức

            //(?<ten>) là cú pháp
            Regex bien = new Regex(@"(?<hour>\d+):(?<minute>\d+):(?<seconds>\d+)"); // hour minute seconds chỉ là ta đặt tên rồi tí truy xuất nhanh hơn thôi  
            /* dấu : chỉ là dấu cắt vd 10:5:45 thì nó xác định ra phần nào có dấu :
                                         10/5/65 thì nó cũng xác định ra phần nào có dấu /
                                         */
             // làm theo Group 
            foreach (Match bie_tam in bien.Matches("16/6/2001 10:45:35 10/12/2019"))
            {
                // lấy ra từng cái
                Console.Write(bie_tam.ToString());
                Console.WriteLine("\nhour=" + bie_tam.Groups["hour"]);        // xuất theo ten đã đặt cho tưng thành phần
                Console.WriteLine("minute=" + bie_tam.Groups["minute"]);
                Console.WriteLine("seconds=" + bie_tam.Groups["seconds"]);

            }

            // làm theo cách nình thương khi ta không đặt tên thì nó sẽ như thế này nhưng ta không cắt được từng thành phần của nó ra chỉ cắt được chuỗi tương ứng thôi
            Regex bien3 = new Regex(@"(\d+):(\d+):(\d+)");
            foreach(Match bienluc in bien3.Matches("16/6/2001 10:45:35 10/12/2019"))
            {
                Console.WriteLine(bienluc.ToString());
            }



            #endregion

            #region capture and capturecollection 

            //vd khi ta có tên hai công ti nếu cong ti thứ nhất nằm trước cùng tên thứ hai nó sẽ lấy ra 2 thẳng thứ nhất vậy nên muốn lấy ra thằng thứ 
            //  2 thì phải làm thế nào ? đổi tên công ti thằng thứ 2 thì cũng được nhưng giờ có 1 tỉ công ti thì đổi tên kiểu gì vì vậy nên ta cần capture
            // ta sẽ cho nó và 1 danh sách mang tên capture và nó sẽ lấy ra hết các định dạng đúng giống nó của các phần tử có trong danh sách mà nó chứa

            //// mỗi khi tìm thấy chuỗi con nào c# sẽ bắt nó lại và lưu vào capture
            //// giúp lấy cắt được tất cả các phần tử trong chuỗi dễ dàng
            //// nó giống như nhiều group hợp lại vậy                                           // đoạn dọc dấu chấm nhớ phải thêm dấu \ vào để nó có thể phân biệt với dấu chấm
            Regex cap = new Regex(@"(?<time>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match bien3 in cap.Matches("16:6:45 tencongty 192.45.7 luc"))
            {
                Console.WriteLine("time=" + bien3.Groups["time"]);
                Console.WriteLine("ip=" + bien3.Groups["ip"]);
                Console.WriteLine();
                foreach (Capture bien4 in bien3.Groups["company"].Captures)
                {
                    Console.WriteLine("company=" + bien4.ToString());
                }
            }



            #endregion
        }
    }
}
