using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLZF_Delegate
{
    /// <summary>
    /// 猫叫一声
    /// 导致
    /// 狗叫一声
    /// 老鼠逃跑
    /// 人被吵醒
    /// 小偷躲起来
    /// </summary>
    public class Cat
    {
        public delegate void CatMiao();//声明委托

        public static CatMiao CatMiaoMethod;//委托的实例化

        //委托是一种类型，事件是委托类型的实例
        public static event CatMiao CatMiaoMethodEvent;//事件声明 事件的本质就是在委托的实例加 Event 关键字修饰

        public static void Miao()
        {
            Console.WriteLine("猫叫了一声~~~");
        }

        public static void DiaoYong()
        {
            if (CatMiaoMethod != null)
            {
                Console.WriteLine("*******委托*********");
                CatMiaoMethod.Invoke();
            }
            
            if (CatMiaoMethodEvent != null)
            {
                Console.WriteLine("*******事件*********");
                CatMiaoMethodEvent?.Invoke();
            }
        }
        //好尴尬，ide先把if 去掉，又把方法体去掉改成lambda表达式，好方，要我干嘛，信不信我掀桌子
        //if (CatMiaoMethod != null)
        //    CatMiaoMethod();


    }
}
