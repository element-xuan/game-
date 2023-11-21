using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// 玩家类
    /// </summary>
    internal class Player
    {
        #region 玩家的属性
        /// <summary>
        /// 玩家生命值
        /// </summary>
        public int PlayerHp { get; set; } = 10;

        /// <summary>
        /// 玩家攻击力
        /// </summary>
        public int PlayerAtk { get; set; } = 1;

        /// <summary>
        /// 玩家经验值
        /// </summary>
        public int PlayerExp { get; set; } = 0;

        /// <summary>
        /// 玩家昵称
        /// </summary>
        public string PlayerName { get; set; } = null;

        #endregion
    }
}
