using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai7_goto
    {
        static void Main(string[] args)
        {
            // Gotto đi đến vị trí này để thực hiện
            #region     vd 1
            /*  int tuoi = 18;
              goto tuoi;

              if (tuoi > 10)
              {
                  Console.WriteLine("ke me may:");
              }

              tuoi:   // nó sẽ đi đến vj trí này dù đằng trước có cái gì
              Console.WriteLine(tuoi);   */
            #endregion;

            #region vd 2;
            /* string name = "van";
             switch (name)
             {
                 case "nguyen":
                     Console.WriteLine("ban da dich chuyen tuc thoi thanh cong");
                     break;
                 case "nguyen van luc":
                     goto case "nguyen";
                     break;
                 case "van":
                     goto case "nguyen van luc";
                 case "luc":
                     goto case "van";


             }   */
            #endregion;

            #region vd 3 goto  nhu vong lap
            int n = 1;
            bat_dau:
            Console.WriteLine("10");
            n++;
            if (n< 10)
            {
                goto bat_dau;
                
            }
#endregion;

        }
    }
}