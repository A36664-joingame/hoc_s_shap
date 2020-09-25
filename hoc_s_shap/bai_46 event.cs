using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_46_event
    {
        private int x;
        private int y;

        public int X {
            get {
                return x;
            }
            set
            {
                x = value;
                   
            } 
        }
        public int Y {
            get
            {
                return y;
            }
            set
            {
                y = value;
                if (value_changed != null)
                {
                    value_changed(this,new EventArgs());    // this là trỏ tớ chính cái class mà chứa this để nay mai có thể dùng sender bên hàm chuyền
                                                            //vào có thể biết được cac thuộc tính thay đổi như thế nào
                }

            }
        }

        private event EventHandler value_changed;
        public event EventHandler valueChanged
        {
            add
            {
                value_changed += value;  // thêm  value chính là mấy cái hàm 
            }
            remove
            {
                value_changed -=value;
            }
        }

     public   bai_46_event(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
