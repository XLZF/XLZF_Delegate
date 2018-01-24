using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLZF_Delegate
{
    public class Student
    {
        public int id { get; set; }

        public string name { get; set; }

        public void Study()
        {
            Console.WriteLine("我爱学习~");
        }
    }
}
