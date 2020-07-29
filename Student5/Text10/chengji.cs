using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text10
{
    class chengji
    {
        int classid;
        string name;
        double fenshu;
        public chengji(int id, string name, double fenshu)
        {
            classid = id;
            this.fenshu = fenshu;
            this.name = name;
        }
        public double FENSHU
        {
            get { return fenshu; }
        }
        public int ID
        {
            get { return classid; }
        }
        public string NAME
        {
            get { return name; }
        }
    }
}
