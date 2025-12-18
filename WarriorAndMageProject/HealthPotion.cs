using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class HealthPotion : Item, IUsableItem
    {
        private readonly int healingPoints;

        public HealthPotion(int maxStack, int healingPoints, string name, string description) : base(maxStack, name, description)
        {
            this.healingPoints = healingPoints;
        }

        public void Use(Player player, Enemy target = null)
        {
            int currentHealingPoints = Math.Max(0, healingPoints);

            player.Healing(currentHealingPoints);
        }
    }
}
