using System;
using System.Collections.Generic;
using System.Text;


namespace hoc_s_shap
{
    class bai_19_string
    {
        static void Main(string[] args)
        {
            #region vd các phương thức trong string chỉ một số cái thôi nhé
            string name = " nguyen van luc ";

            name = name.Trim();  // cắt kí tự dấu cách hai đầu
            Console.WriteLine(name);
            int a = name.Length;
            Console.WriteLine(a);
            //     //Console.WriteLine(name.Contains("luc"));// trả về kiểu luân lý nếu kí tự đó có trong string

            //     //      Console.WriteLine(name.Replace("nguyen van luc", "hoang phuong nam")); // thay thế kí tự hoặc chuỗi


            //string[] name2=name.Split("luc");  // cắt kí tự
            //     for(int i = 0; i < name2.GetLength(0); i++)
            //     {
            //         Console.Write(name2[i]);
            //     }
            #endregion

            #region stringbuilder
            //// chánh chàn bộ nhớ nên sử dụng khi muốn thêm phần tử vào chuỗi
            //StringBuilder buildername =new StringBuilder("nguyen van");

            //buildername.Append(" luc");
            //Console.Write(buildername);

            #endregion


            //string luc = "nguyen van luc";
            //luc.ToUpper();
            //Console.WriteLine(luc);




        }

    }
}
