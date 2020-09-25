using System;
using System.Collections.Generic;
using System.Text;

namespace hoc_s_shap
{
    class tao_class_sinhvien2
    {
        private string name_player;

        public string Name_player { get => name_player; set => name_player = value; }
        public string Id_player { get => id_player; set => id_player = value; }

        private string id_player;

        public tao_class_sinhvien2(string name,string id)
        {
            this.Name_player = name;
            this.Id_player = id;
        }
    }
}
