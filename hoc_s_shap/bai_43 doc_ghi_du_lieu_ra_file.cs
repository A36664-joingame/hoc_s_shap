using System;
using System.Collections.Generic;
using System.Text;
using System.IO;  // cần có thưu viện io bao gồm nhiều thứ

#region ứng dụng đọc ghi dữ liệu ra file

/*ghi các đoạn mã mà chả thằng đéo nào đọc được
 * làm các mục setting trong game mà không đụng đến các đoạn code của mk
 * làm file để chứa dữ liệu mật mà chả có thằng nào đọc được
 * lưu dữ liệu suống file nhưng giờ toàn lưu trên wep
 * nhiều quá tự nghĩ đi
 *
 */

#endregion ứng dụng đọc ghi dữ liệu ra file

namespace hoc_s_shap
{
    class bai_43_doc_ghi_du_lieu_ra_file
    {
        static void Main(string[] args)
        {
            #region cấu trúc thứ 0

            // khai báo filetxt truy cập file txt
            FileStream tendedung = new FileStream("địa chỉ đến file", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);
            // khai báo ghi
            StreamWriter bienghi = new StreamWriter(tendedung);

            bienghi.WriteLine("nguyen van luc");

            // giải phóng và đóng file
            bienghi.Flush();
            bienghi.Close();

            StreamReader biendoc = new StreamReader("luc1.love");

            Console.WriteLine(biendoc.ReadToEnd());

            biendoc.Close();

            #endregion cấu trúc thứ 0

            #region cấu trúc thứ nhất

            //FileStream ten = new FileStream("luc.love", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);
            //int i = 8;
            //// vài cái ghi lằng nhằng tự tìm hiểu
            ////    string name = "nguyen van luc";
            //ten.WriteByte((byte)i);
            ////char t = 't';
            ////ten.WriteByte(Convert.ToByte(t));
            //byte[] name = { 1, 2, 3, 4, 5, 6, 7, 5 };
            //ten.Write(name);

            //// đọc file tự tìm hiểu
            //Console.WriteLine("co the doc hay khong:{0}",ten.CanRead);// xem có thể đọc hay không chả về true or false
            //Console.WriteLine("doc kieu byte:{0}",ten.ReadByte());
            //Console.WriteLine("\ndoc binh thuong:{0}",ten.Read(name));
            //ten.Close();

            #endregion cấu trúc thứ nhất

            #region cấu trúc thứu hai

            // ghi
            //   StreamWriter ten1 = new StreamWriter("luc.txt");
            //    Console.OutputEncoding = Encoding.UTF8; // ghi theo form utf8      ******
            //    ten1.Write("nguyễn văn lưc");
            //    Console.WriteLine("nhap vao name cua ban:");
            //    string name2 = Console.ReadLine();
            //    ten1.WriteLineAsync(name2);
            //    ten1.Close();
            ////    đọc tự tìm hiểu không tự học thì chết đi
            //    string dia_chi_file = @"luc.txt";
            //    StreamReader ten2 = new StreamReader(dia_chi_file);
            //    Console.OutputEncoding = Encoding.UTF8;
            //    Console.WriteLine(ten2.ReadLine());
            //  Console.WriteLine(ten2.ReadToEnd());   /// kiểu này cũng là đọc hết nhưng không thể thao tác đến các thành phần của file

            // cách đọc hết các dữ liệu từ file mà nay mai có thể thao tác được từng dong thành phần của file

            //string bien;
            //while ((bien = ten2.ReadLine()) != null)
            //{
            //    Console.WriteLine("ban da doc thanh cong:");
            //    Console.WriteLine(bien);
            //}

            //ten2.Close();

            #endregion cấu trúc thứu hai

            #region cấu trúc thứ ba

            string dia_chi_file = @"luc.txt";
            //string filepath = @"c:\temp\testfile.txt";
            //// equals string filepath = "c:\\temp\\testfile.txt";

            //string filetext = "Hello World" + Environment.NewLine + "line2" + Environment.NewLine + "line3";
            ////equals string filetext = "Hello World\r\nline2\r\nline3";

            //File.WriteAllText(filepath, filetext, Encoding.Unicode);
            //// hoặc
            //File.WriteAllText(@"c:\temp\testfile.txt", "Hello World\r\nline2\r\nline3", Encoding.Unicode);

            //File.GetAttributes(dia_chi_file);/// xây dựng thêm vào file có địa chỉ

            //Console.WriteLine(File.ReadAllText(dia_chi_file));

            #endregion cấu trúc thứ ba

            #region đọc và ghi tiếng việt

            //File.WriteAllText(dia_chi_file, "nguễn văn vũ ", Encoding.UTF8);
            //Console.WriteLine(File.ReadAllText(dia_chi_file, Encoding.UTF8));

            //// đọc file cho vào một mảng
            //string[] mang = { File.ReadAllText(dia_chi_file) };
            //foreach(var bien in mang)
            // {
            //    Console.WriteLine("da cho vao mang thanh cong");
            //    Console.WriteLine(bien);
            //}

            #endregion đọc và ghi tiếng việt
        }
    }
}