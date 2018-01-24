using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLZF_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //开始表演：委托
            DelegateClass.Show();

            //可扩展
            GreetingClass.Greetingdelegate greetingdelegate = new GreetingClass.Greetingdelegate(GreetingClass.Greeting_LunTai);

            GreetingClass.Greeting("战三", greetingdelegate);

            //这样可以做到职责单一
            //只要在Greeting类中添加对应的方法，比如制造方向盘的，上层也就是当前重新调用委托，在参数中调用刚才添加的制造方向盘的方法
            GreetingClass.Greetingdelegate greetingdelegate1 = new GreetingClass.Greetingdelegate(GreetingClass.Greeting_FangXiangpan);

            //以上就已经指定了制造方向盘，现在只需要给Name就OK
            GreetingClass.Greeting("张三", greetingdelegate1);

            Console.ReadLine();
        }
    }
}
