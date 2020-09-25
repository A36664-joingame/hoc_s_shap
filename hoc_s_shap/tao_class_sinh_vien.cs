using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{

    class info_student
    {
        private int age;
        private string name_student;
        private string masv;

        public int Age { get => age; set => age = value; }
        public string Name_student { get => name_student; set => name_student = value; }
        public string Masv { get => masv; set => masv = value; }
    
   public    info_student(int age,string name,string masv)
        {
            this.Age = age;
            this.Name_student = name;
            this.Masv = masv;
        }
   public     void showinfo()
        {
            Console.WriteLine(this.name_student);
            Console.WriteLine(this.age);
            Console.WriteLine(this.masv);
        }
    
    }
    
    class tao_class_sinh_vien
    {
        private List<tao_class_sinhvien2> player;

        internal List<tao_class_sinhvien2> Player { get => player; set => player = value; }

       public void make_list_student()
        {
            this.Player = new List<tao_class_sinhvien2>()
            {
                new tao_class_sinhvien2("nguyen van luc","A36664"),
                new tao_class_sinhvien2("nguyen van vu", "A36665")

            };
        }
     static    void set_player()
        {
            string name_player1 = Player[1].Name_player;
            string id_Player1 = Player[1].Id_player;
            string name_player0 = Player[0].Name_player;
            string id_player0 = Player[0].Id_player;
        }
        static void Main(string[] args)
        {   
            info_student info = new info_student(18, "nguyen van luc", "A3664");
            info.showinfo();
            
            

        }
    }
}
