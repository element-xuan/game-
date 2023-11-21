using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// 怪物类
    /// </summary>
    internal class Monster
    {
        #region 怪物的属性
        /// <summary>
        /// 怪物生命值
        /// </summary>
        public int MonsterHp
        {
            get { return MonsterHp = 5; }
            set
            {
                if (value < 0)
                {
                    MonsterHp = 0;
                }
            }
        }

        /// <summary>
        /// 怪物攻击力
        /// </summary>
        public int MonsterAtk { get; set; } = 1;

        /// <summary>
        /// 怪物经验值
        /// </summary>
        public int MonsterExp { get; set; } = 0;

        /// <summary>
        /// 怪物昵称
        /// </summary>
        public string MonsterName { get; set; } = "小白1号";

        #endregion
    }
}
