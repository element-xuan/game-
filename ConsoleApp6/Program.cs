using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 游戏开始流程
            Console.WriteLine("—————————————————————————————————————————————");
            Console.WriteLine("——————————————————开始游戏—————————————————————");
            Console.WriteLine("——————————————————————————————————————————————");

            Console.WriteLine("尊敬的挑战者，请输入你的姓名！");
            string name = Console.ReadLine().Trim();

            Monster M1 = new Monster();
            Player P1 = new Player();
            P1.PlayerName = name;

            Console.WriteLine($"尊敬的挑战者{P1.PlayerName},您的生命值为{P1.PlayerHp}，您的攻击力当前为{P1.PlayerAtk}。");
            #endregion

            while (true)
            {
                Console.WriteLine("尊敬的挑战者，您遇到了怪物，请做出选择！  1战斗 2逃跑");
                int a = Convert.ToInt32(Console.ReadLine().Trim());
                if (a == 1)//战斗
                {
                    var program = new Program();
                    program.Fight(P1, M1);
                }
                else if (a == 2)//逃跑
                {
                    Console.WriteLine("你选择了逃跑！");
                }
                else//都未选择
                {
                    Console.WriteLine("你在干啥？？？？");
                }

            }
        }

        /// <summary>
        /// 战斗
        /// </summary>
        /// <param name="player">玩家对象</param>
        /// <param name="monster">怪物对象</param>
        void Fight(Player player, Monster monster)
        {
            while (true)
            {
                //玩家的血量  等于 玩家的血量减去怪物的攻击
                //player.PlayerHp = player.PlayerHp - monster.MonsterAtk;
                player.PlayerHp -= monster.MonsterAtk;//怪物对玩家造成伤害
                Console.WriteLine($"{monster.MonsterName}对{player.PlayerName}造成了{monster.MonsterAtk}伤害，你还有{player.PlayerHp}生命值，怪物还有{monster.MonsterHp}生命值");

                monster.MonsterHp -= player.PlayerAtk;//玩家对怪物造成伤害
                Console.WriteLine($"{player.PlayerName}对{monster.MonsterName}造成了{player.PlayerAtk}伤害，你还有{player.PlayerHp}生命值，怪物还有{monster.MonsterHp}生命值");

                if (player.PlayerHp <= 0)
                {
                    Console.WriteLine($"{player.PlayerName}死亡！！！");
                    break;
                }
                else if (monster.MonsterHp <= 0)
                {
                    Console.WriteLine($"{monster.MonsterName}死亡！！！");
                    break;
                }
            }

        }
    }
}
