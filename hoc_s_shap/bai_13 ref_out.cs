using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_13_ref_out
    {  // ref là lấy luân giá trị thực để sử lý  giống tham cchieeus
        #region Vd hàm khi không sử dụng ref 


        /*     static int a = 18;
              static void Main(string[] args)
              {

                  Console.WriteLine(a);

                  thu(a);
                  Console.WriteLine(a);

              }

             static void thu(int a)
              {


                  a++;  // thay đổi thì chỉ có trong hàm vì giá trị a này chỉ là giá trị coppy


              }    */

        #endregion

        #region VD dùng ref để lấy giá trị thực ra để thay đổi nó như tham chiếu

        /* static void Main(string[] args)
         {
              int a = 18;
             Console.WriteLine(a);

             thu(ref a);
             Console.WriteLine(a);

         }

         static void thu(ref int a)
         {


             a++;  


         }  */
        #endregion

        /* out cũng giống ref nhưng ban đầu 
         * có hoặc không cần khởi tạo giá trị ban đầu
           chỉ khởi tạo trong hàm */
        #region Vd dùng out
        
        static void Main(string[] args)
        {
            int a;

         //   Console.WriteLine( a);

            thu(out a);
            Console.WriteLine(a);

        }

        static void thu(out int a)
        {

            // giá trị phải trong hàm
            a = 21;

            a++;  

        }
        #endregion
    }
}
