using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class bai_48_sudung_event_tutao
    {

        static void Main(String[] args)
        {
            bai_48_event_tu_tao luc = new bai_48_event_tu_tao(1, 1);


            luc._valuechanged += ham_chuyen_cho_event;




        }


        public static void ham_chuyen_cho_event(object sender , tao_du_lieu_thay_the_cho_evenArgs e)
        {

            /////
          


        }



    }
}
