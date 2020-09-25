using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_48_event_tu_tao
    {
     private   int x;
       private int y;

        public int Y 
        {
            get => y; 
            set => y = value; 
        }
        public int X 
        {
            get => x;
            set 
            {
                x = value;

                if (valuechanged != null)
                {
                    valuechanged(this,new tao_du_lieu_thay_the_cho_evenArgs(this));       // CÂU LỆNH LÀ BÁT BUỘC
                }
            }

            

        }
        

        public bai_48_event_tu_tao(int x,int y)
        {
            this.X = x;
            this.Y = y;
            
        }

        private event EventHandler<tao_du_lieu_thay_the_cho_evenArgs> valuechanged;     // để cho nó biết mk thay thế eventArgs thì ta phải thêm tên cái event ta tạo mới vào
        public event EventHandler<tao_du_lieu_thay_the_cho_evenArgs> _valuechanged
        {
            add
            {
                valuechanged += value;
            }
            remove
            {
                valuechanged -= value;
            }
        }




    }

                                                                  // thực chất EventArgs cũng chỉ là một cái đối tượng của class
    class tao_du_lieu_thay_the_cho_evenArgs :EventArgs
    {




          public tao_du_lieu_thay_the_cho_evenArgs(bai_48_event_tu_tao chinh_no)    
        {
               // các dữ liệu mới nằm trong này
        }


    }





}
