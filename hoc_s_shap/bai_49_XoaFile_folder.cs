using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO; // thư viện file
using System.Text;

namespace hoc_s_shap
{
    class bai_49_XoaFile_folder
    {
        static public void DeleteFile(string filePath)
        {
            // string filePath = "C:/test/test.txt";

            // Kiểm tra đường dẫn này có tồn tại hay không?
            if (File.Exists(filePath))
            {
                // Xóa file
                File.Delete(filePath);

                // Kiểm tra lại xem file còn tồn tại không.
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File deleted...");
                }

            }
            else
            {
                Console.WriteLine("File test.txt does not yet exist!");
            }

            Console.ReadKey();
        }

        static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }


        static void DeleteFoleder()
        {
            string strCmd;
            strCmd = "/C rmdir /q xoafile"; // nhớ phải có /C mới chạy được lệnh cmd
            Process.Start("CMD.exe", strCmd);



        }

        static void Main(string[] args)
        {

            string path = @"C:\\Users\\luc\\Desktop\\xoafile\\New Text Document.txt";
            string path2 = @"C:\\Users\\luc\\Desktop\\xoafile";
            // DeleteFile(path);
           // clearFolder(path2);
            DeleteFoleder();
            Console.ReadKey();

        }
    }
}
