using System;
using System.Collections.Generic;
using System.Text;

 // các phạm vi truy cập private ,public , static ,protected ,internal,protected internal


namespace hoc_s_shap
{

    class animal
    {
        public string ten_loai;
        public char[] gioi_tinh;
        public int tuoi;
        public int chieu_cao;
        public animal()  // hàm tạo không tham số
        {
            Console.WriteLine("dang chay");
        }
        
        public animal( int tuoi, int chieu_cao) // hàm tạo có tham số
        {
           this.tuoi = tuoi;
            this.chieu_cao = chieu_cao;

        }
        
        public void showinfo()
        {
            Console.WriteLine(tuoi);
            Console.WriteLine(chieu_cao);
        }
       
        public void run()
        {
            Console.WriteLine("con cho dang chay");
        }
        ~animal() /// hàm hủy
        {
            Console.WriteLine("da huy");
        }


        public static animal MyProperty { get; set; }  // thông báo là học cái này nhe , học wpf priject quản ký kho thì biết 
    }
   
    class bai_23_class
    {
        static void Main(string[] args)
        {
            animal meo = new animal(); // khởi tạo đối tượng của lớp bắt buộc có toán tử new
            
            animal chuot = new animal(18, 20);
            chuot.showinfo();

            // nếu muốn gọi các hàm khác mà trên có các hàm tạo chứa các tham số thì gọi hàm đấy trước để chánh bị gọi nhầm gây ra lỗi
            animal cho = new animal();   // nó đã không bị nhầm khi ta gọi hàm run
            cho.run();

            animal.MyProperty.run(); // nhìn phát biết ngay vì đây là static nên có thể lấy luân tên class để trỏ tới thôi còn cái hàm này khi học wpf làm quản lý kho nên biết
            // nếu không để static thì gọi thông qua đối tượng vẫn thế
           
            Console.ReadKey();
        }
    }
}
