using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLZF_Delegate
{
    /// <summary>
    /// 委托：解耦
    /// </summary>
    public class GreetingClass
    {
        /// <summary>
        /// 制造 轮胎
        /// </summary>
        /// <param name="name">品牌</param>
        public static void Greeting_LunTai(string name)
        {
            Console.WriteLine("{0}制造轮胎", name);
        }

        /// <summary>
        /// 制造 后视镜
        /// </summary>
        /// <param name="name">品牌</param>
        public static void Greeting_HouShijing(string name)
        {
            Console.WriteLine("{0}制造后视镜", name);
        }

        /// <summary>
        /// 制造 车门
        /// </summary>
        /// <param name="name">品牌</param>
        public static void Greeting_Chemen(string name)
        {
            Console.WriteLine("{0}制造车门", name);
        }

        /// <summary>
        /// 制造 车门
        /// </summary>
        /// <param name="name">品牌</param>
        public static void Greeting_FangXiangpan(string name)
        {
            Console.WriteLine("{0}制造方向盘", name);
        }

        /// <summary>
        /// 普通写法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="p_Type"></param>
        public static void Greeting(string name, P_Type p_Type)
        {
            if (p_Type == P_Type.Chinese)
            {
                Console.WriteLine("{0}制造轮胎", name);
            }
            else if (p_Type == P_Type.English)
            {
                Console.WriteLine("{0}制造后视镜", name);
            }
            else if (p_Type == P_Type.Janpanese)
            {
                Console.WriteLine("{0}制造车门", name);
            }
            else
            {
                throw new Exception("wrong P_type~!!");
            }
        }

        #region 委托写法

        /// <summary>
        /// 声明委托
        /// </summary>
        /// <param name="name"></param>
        public delegate void Greetingdelegate(string name);

        public static void Greeting(string name, Greetingdelegate greetingdelegate)//传方法来，去执行
        {
            greetingdelegate.Invoke(name);
        }
        
        #endregion


        public enum P_Type
        {
            Chinese,
            English,
            Janpanese
        }
    }
}
