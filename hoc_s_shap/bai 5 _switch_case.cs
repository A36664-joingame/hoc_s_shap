using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai5_switch_case
    {
        static void Main(string[] args)
        {
            #region switch case đối với số
            // switch case đối với số
            //  Console.WriteLine("nhap luc chon cua ban:");
            //  string tuoi = Console.ReadLine();
            //  int age = Convert.ToInt32(tuoi);
            //  switch (age)
            //  {
            //      case 1:

            //          Console.WriteLine("ban bi dien");
            //          break;

            //      case 2:
            //          Console.WriteLine("ban bi khung");
            //break;
            //      case 3:
            //          Console.WriteLine("ban khong sao ca"); 
            //          break;
            //      default:
            //          Console.WriteLine("khong co cau cha loi:");
            //          break;
            //  }

            #endregion


            #region switch case đối với kí tự 
            //switch case đối với kí tự 

            Console.WriteLine("con cho co may chan?"+ "\n\t\t\tA=1"+ "\n\t\t\tB=2"+ "\n\t\t\tC=3"+ "\n\t\t\tD=4");
            while (true)
            {
                Console.Write("nhap vao lua chon cua ban:");
                string luachon = Console.ReadLine();

                switch (luachon)
                {
                    case "a":
                    case "A":
                    case "c":
                    case "C":
                    case "B":
                    case "b":
                        Console.WriteLine("ban da cha loi sai");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("ban da cha loi dung");
                        break;
                    default:
                        Console.WriteLine("cau lua chon cua ban khong co");
                        break;


                }
                if (luachon=="D" || luachon == "d"){
                    break;

                }

            }

            #endregion
        }
    }
}
