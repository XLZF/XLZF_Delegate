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
            #region 20180124

            //开始表演：委托
            //DelegateClass.Show();

            //可扩展
            //GreetingClass.Greetingdelegate greetingdelegate = new GreetingClass.Greetingdelegate(GreetingClass.Greeting_LunTai);

            //GreetingClass.Greeting("战三", greetingdelegate);

            //这样可以做到职责单一
            //只要在Greeting类中添加对应的方法，比如制造方向盘的，上层也就是当前重新调用委托，在参数中调用刚才添加的制造方向盘的方法
            //GreetingClass.Greetingdelegate greetingdelegate1 = new GreetingClass.Greetingdelegate(GreetingClass.Greeting_FangXiangpan);

            //以上就已经指定了制造方向盘，现在只需要给Name就OK
            //GreetingClass.Greeting("张三", greetingdelegate1);

            #endregion

            #region 20180125
            //多播委托
            //也是解耦 当想添加一个babyCry，只要添加Baby类，在上端添加代码就ok
            Cat.CatMiaoMethod += Cat.Miao;

            Cat.CatMiaoMethod += Dog.Wang;

            Cat.CatMiaoMethod += Mouse.Run;

            Cat.CatMiaoMethod += People.GetBed;

            Cat.CatMiaoMethod += Stealer.Hided;

            Cat.CatMiaoMethod += Baby.Cry;
            
            //观察者模式和事件

            //事件         
            //cat.CatMiaoMethodEvent catMiaoMethodEvent = new cat.CatMiaoMethodEvent(Dog.Wang);//1.不能初始化 防止外部直接赋值为null 导致注册失效
            //cat.CatMiaoMethodEvent();//2.不能直接被调用 是一种权限的控制
            Cat.CatMiaoMethodEvent += Cat.Miao;

            Cat.CatMiaoMethodEvent += Dog.Wang;

            Cat.CatMiaoMethodEvent += Mouse.Run;

            Cat.CatMiaoMethodEvent += People.GetBed;

            Cat.CatMiaoMethodEvent += Stealer.Hided;

            Cat.CatMiaoMethodEvent += Baby.Cry;

            Cat.DiaoYong();

            #endregion

            Console.ReadLine();
        }
    }
}
