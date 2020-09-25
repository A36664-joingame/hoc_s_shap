using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_45_delegate_hoc_lai
    {
      internal  delegate void kieu(int a, int b);
        internal delegate void kieu2(ref string a,ref string b);
        static void Main(string []args)
        {
            kieu bien = new kieu(sum) + new kieu(hieu);

            //    bien(2,4); //chuyền tham số
            kieu2 bien2 = new kieu2(nhap) + new kieu2(xuat);
            string a=null;
            string b=null;
            bien2(ref a, ref b);   // bắt buộc phải chuyền giá trị cho nó
        
         
            void nhap(ref string a,ref string  b)
            {

                Console.WriteLine("moi ban nhap gia tri cho a:");
                a = Console.ReadLine();
                Console.WriteLine("moi ban nhap gia tri cho b:");
                b = Console.ReadLine();
                
            }
            void xuat(ref string a,ref string b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            void sum(int a,int b)
            {
                Console.WriteLine(a + b);
            }
            void hieu(int a,int b)
            {
                Console.WriteLine(a - b);
            }
            
        }
    }
}
