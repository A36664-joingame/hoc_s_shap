using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hoc_s_shap
{
    class bai_22_B_Regular__Expression
    {

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
        $ lấy thằng cuỗi Vd: luc nguyen van luc ->luc$   KQ:  luc (nằm đầu cuối)        vd 51235 khi dùng 5$ nó sẽ lấy thằng 5 ở cuối
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
        static void Main(String[] args)
        {

            //Regex ten = new Regex(@"\d");  // phải có @ nhe nó mới hiểu được định dạng
            //Match tenchomatch = ten.Match("nguyenvanluc160601");   // đưa vào chuỗi cần thực hiện

            //Console.WriteLine(tenchomatch.ToString());

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

        }

    }
}
