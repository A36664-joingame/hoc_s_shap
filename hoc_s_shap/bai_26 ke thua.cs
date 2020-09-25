using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap


{
    #region lớp con kế thừ từ lớp cha
    class student
    {
        protected string name;
        public int tuoi;
        public string gioi_tinh;
        public string masv;

        public void showinfo()
        {
            Console.WriteLine("ten hoc sinh la:{0}", name);
            Console.WriteLine("tuoi hoc sinh la:{0}", tuoi);
            Console.WriteLine("gioi tinh sinh vien la:{0}", gioi_tinh);
            Console.WriteLine("ma sinh vien la:{0}", masv);
        }
    }
    class luc : student  // kế thừ từ lớp student
    {
    public void thongtin()  // phải có hàm mới truy cập đến các thuộc tính của cha được
        {
            this.name = "nguyen van luc";
            tuoi = 18;                // thông tin này chính là của lớp lực rồi
            gioi_tinh = "nam";
            masv = "A36664";
        }
        void in_thong_tin()
        {
            showinfo();
        }
    }
    #endregion

    #region lớp cha có phương thức tham số và cách dùng từ khóa base
    /* nếu lớp cha có phương thức khởi tạo chứa tham số thid lớp con phải có 
     phương thức khởi tạo tương ứng và thực hiện gọi phương thức khởi tạo
     của lớp cha thông qua từ khóa base   */
     class animal
    {
        public string name;
        public string mau_long;
        public int tuoi;
        public animal(string name1,string mau_long1,int tuoi1)
        {
           this.name = name1;
           this.mau_long = mau_long1;
           this.tuoi = tuoi1;
        }
        public void showinfo_animal()
        {
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("mau long:{0}", mau_long);
            Console.WriteLine("tuoi :{0}", tuoi);
        }
    }
    class meo : animal
    { // cứ viết đi bao giờ đúng thì thôi

        // khi có tham số ở phương thức hàm tạo của cha mà hàm con  muốn sử dụng thì phải
        // có base tương đương phương thức của cha được gọi lại nhưng chuyền tham số khác
        // nó sẽ chuyển giá trị của ta khi ta chuyền vào rồi cha thực hiện hộ nhưng lại của con

        public meo(string name2,string maulong,int tuoi2) : base(name2, maulong, tuoi2)
        {                                                 // bắt buộc có base
            // base sẽ lấy giá trị ta chuyền vào đưa cho thằng cha sử lý
            // rồi lại chả cho thằng con và thuộc tính đó của thằng con
           
           // base.showinfo_animal()// có thể gọi mọi thành phân của lớp cha bằng base
            
            /*name = name2;
            mau_long = maulong ;   // thừa không cần (CHÚ Ý)
            /tuoi=tuoi2;  */
        }
        public void showinfo_meo()
        {
            showinfo_animal();
        }
    }

    #endregion

    class bai_26_ke_thua
    {
        static void Main(string[] args)
        {
            //luc luc2 = new luc();
            //luc2.thongtin();
            //luc2.showinfo();
            meo black_meo = new meo("meo chi ba", "black", 15);
            black_meo.showinfo_meo();
            
        }
    }
}
