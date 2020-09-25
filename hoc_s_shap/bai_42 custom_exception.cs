using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace hoc_s_shap
{
    class bai_42_custom_exception

    {
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }

        [Serializable]
        class InvalidStudentNameException : Exception  // kế thừ từ Exception  cái này hay sử dụng nhe nó có nhiều thứ hỗ chợ lắm ,viết exception thường dùng cái này lắm
        {
            public InvalidStudentNameException() /// tạo ra quy tắc của chính mình
            {
            }

            public InvalidStudentNameException(string name) : base(String.Format("Invalid Student Name: {0}", name))
            {
            }
        }
        static void Main(string[] args)
        {
            #region lý thuyết và cách dùng khi tạo ra các ngoại lệ

            /*Chúng ta đã thấy các lớp ngoại lệ tích hợp trong phần trước. Tuy nhiên,
             * bạn thường muốn đưa ra một ngoại lệ khi quy tắc kinh doanh trong ứng dụng của bạn bị vi phạm.
             * Vì vậy, để làm điều này,
             * bạn có thể tạo một lớp ngoại lệ tùy chỉnh bằng cách lấy lớp Exception hoặc ApplicationException
             * một ứng dụng khồng muốn các kí tự đặc biệt trong đăng nhập
             */
            //     Exception hoặc ApplicationException

            #endregion lý thuyết và cách dùng khi tạo ra các ngoại lệ

            #region vd áp dùng kí tự lồn với ném lỗi ra bắt lại

            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "nguyenvan12";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }

            Console.ReadKey();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
        }

        #endregion vd áp dùng kí tự lồn với ném lỗi ra bắt lại
    }
}