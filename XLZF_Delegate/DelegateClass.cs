using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLZF_Delegate
{
    public class DelegateClass
    {

        //class 内声明delegate
        public delegate void weituo1(int x, int y);//1.声明委托

        public delegate string weituo2();

        public delegate DateTime weituo3(string name, int size);

        public static void Show()
        {
            Console.WriteLine("委托的意义：");

            Console.WriteLine("没有委托就没有异步");

            Console.WriteLine("对扩展开发，对修改封闭"); 

            Console.WriteLine("解耦，体现单一职责"); 

            Console.WriteLine("符合设计模式原则");

            Student student = new Student();

            student.id = 11;

            student.name = "帥帥";

            student.Study();

            weituo1 method = new weituo1(Plus);//2.实例化委托 委托的方法必须满足参数合顺序的一致性

            //weituo1 method1 = Plus;//简写

            //3.调用
            method.Invoke(3, 4);//Invoke 调用
            method(3, 4);//直接调用
            method.BeginInvoke(3, 5, null, null);//异步调用

            //多播委托 多播委托的价值：按顺序执行
            method += Plus;
            method += Plus;
            method += Plus;
            method += Plus;
            method -= Plus;

            method.GetInvocationList();//找出method中委托的多少方法

            
        }

        private static void Plus(int x, int y)
        {
            Console.WriteLine("这里是Plus x={0} y={1}", x, y);
        }

        private static void No(int x, string y)
        {
            Console.WriteLine("No x={0} y={1}", x, y);
        }
    }
}
