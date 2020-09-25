using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace hoc_s_shap
{
    class bai_47_listEvent
    {
        int x;
        int y;
        public int X { 
            get => x;
            set
            {
                x = value;

                // câu lệnh để lấy ra event mang ten mình muỗ ra khỏi danh sách
                EventHandler<eventmoinay> temp = (EventHandler<eventmoinay>)Event_tao["tencacevent"];   
                if (temp != null)
                {
                    temp(this, new eventmoinay(this));    // temp chính là event mang tên là "tencacevent"   giờ ta có cả danh sách event lấy từng cái ra dùng thôi
                }

            }
        }
        public int Y {
            get => y;
            set { 
                
                y = value;
                EventHandler<eventmoinay> temp = (EventHandler<eventmoinay>)Event_tao["tencacevent"];
                if (temp != null)
                {
                    temp(this, new eventmoinay(this));    // temp chính là event mang tên là "tencacevent"   giờ ta có cả danh sách event lấy từng cái ra dùng thôi
                }
            }
        }

        public bai_47_listEvent(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }






        public EventHandlerList Event_tao = new EventHandlerList();    /// tạo một list có thể chứa cá event

       

        private event EventHandler<eventmoinay> valuechange;
        public event EventHandler<eventmoinay> _valuechage
        {
            add
            {
                Event_tao.AddHandler("tencacevent", value);        // add từng event đồng thời tạo tên cho từng event được add vào
                valuechange += value;
            }
            remove
            {
                Event_tao.RemoveHandler("tencacevent", value);     // remove theeo tên và event tương ứng
            }
        }




    }


    class eventmoinay : EventArgs
    {


        public eventmoinay(bai_47_listEvent Point)
        {

        }


    }



    //// thường người ta dùng enum để lưu các tên cảu event
    
    enum listname
    {
       tencacevent1,      // nhớ khi cho vào trên kia nhớ ép sang kiểu int vì nó là kiểu int nhe
       tencacevent2
    }


}
