using System;
using System.Security.Policy;


namespace WarriorAndMageProject
{
    internal class EquipmentManager
    {
        public Weapon weapon;
        public Head head;
        public Body body;
        public Hands hands;
        public Legs legs;
        public Boots boots;
        public Ring ring1;
        public Ring ring2;
        public Necklace necklace;

        public  EquipmentManager()
        {
            weapon = null;
            head = null;
            body = null;
            hands = null;
            legs = null;
            boots = null;
            ring1 = null;
            ring2 = null;
            necklace = null;
        }

        public void WearItem(Item item, Player player)
        {
           
           
            if (!CanEquipItem(item, player))
            {
                Console.WriteLine($"Оружие '{item.Name}' не подходит для вашего класса.");
                return;
            }

            if (CanEquipItem(item, player))
            {
                    

                if (item is Weapon)
                {
                    if (weapon == null)
                    {
                        weapon = (Weapon)item;
                        Console.WriteLine($"Оружие '{item.Name}' экипировано.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот оружия занят)");
                    }
                    return;
                }


                if (item is Head)
                {
                    if (head == null)
                    {
                        head = (Head)item;
                        Console.WriteLine($"Головной убор '{item.Name}' экипирован.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот головы занят)");
                    }
                    return;
                }


                if (item is Body)
                {
                    if (body == null)
                    {
                        body = (Body)item;
                        Console.WriteLine($"Нагрудник '{item.Name}' экипирован.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот тела занят)");
                    }
                    return;
                }


                if (item is Hands)
                {
                    if (hands == null)
                    {
                        hands = (Hands)item;
                        Console.WriteLine($"Перчатки '{item.Name}' экипированы.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот рук занят)");
                    }
                    return;
                }

                if (item is Legs)
                {
                    if (legs == null)
                    {
                        legs = (Legs)item;
                        Console.WriteLine($"Поножи '{item.Name}' экипированы.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот ног занят)");
                    }
                    return;
                }


                if (item is Boots)
                {
                    if (boots == null)
                    {
                        boots = (Boots)item;
                        Console.WriteLine($"Обувь '{item.Name}' экипирована.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот обуви занят)");
                    }
                    return;
                }


                if (item is Ring)
                {
                    if (item is Ring)
                    {
                        if (ring1 == null)
                        {
                            ring1 = (Ring)item;
                            Console.WriteLine($"Кольцо '{item.Name}' экипировано в слот 1.");
                        }
                        else if (ring2 == null)
                        {
                            ring2 = (Ring)item;
                            Console.WriteLine($"Кольцо '{item.Name}' экипировано в слот 2.");
                        }
                        else
                        {
                            Console.WriteLine("Этот предмет cейчас невозможно экипировать (оба слота колец заняты)");
                        }
                        return;
                    }
                }

                if (item is Necklace)
                {
                    if (necklace == null)
                    {
                        necklace = (Necklace)item;
                        Console.WriteLine($"Ожерелье '{item.Name}' экипировано.");
                    }
                    else
                    {
                        Console.WriteLine("Этот предмет cейчас невозможно экипировать (слот ожерелья занят)");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine($"Предмет '{item.Name}' нельзя экипировать.");
                    return;
                }

            }
            


            player.UpdateEquipmentBonuses();
          
        }
        

        public void TakeOffItem(Item item, Player player)
        {
            if (item == null)
            {
                Console.WriteLine("Предмет не указан.");
                return;
            }

            if (item is Weapon && weapon == item)
            {
                Console.WriteLine($"Оружие '{item.Name}' снято.");
                weapon = null;
            }
            else if (item is Head && head == item)
            {
                Console.WriteLine($"Головной убор '{item.Name}' снят.");
                head = null;
            }
            else if (item is Body && body == item)
            {
                Console.WriteLine($"Нагрудник '{item.Name}' снят.");
                body = null;
            }
            else if (item is Hands && hands == item)
            {
                Console.WriteLine($"Перчатки '{item.Name}' сняты.");
                hands = null;
            }
            else if (item is Legs && legs == item)
            {
                Console.WriteLine($"Поножи '{item.Name}' сняты.");
                legs = null;
            }
            else if (item is Boots && boots == item)
            {
                Console.WriteLine($"Обувь '{item.Name}' снята.");
                boots = null;
            }
            else if (item is Ring)
            {
                if (ring1 == item)
                {
                    Console.WriteLine($"Кольцо '{item.Name}' снято с слота 1.");
                    ring1 = null;
                }
                else if (ring2 == item)
                {
                    Console.WriteLine($"Кольцо '{item.Name}' снято с слота 2.");
                    ring2 = null;
                }
                else
                {
                    Console.WriteLine($"Кольцо '{item.Name}' не было экипировано.");
                }
            }
            else if (item is Necklace && necklace == item)
            {
                Console.WriteLine($"Ожерелье '{item.Name}' снято.");
                necklace = null;
            }
            else if (item is Weapon)
            { 
            }
            else
            {
                Console.WriteLine($"Предмет '{item.Name}' не был экипирован или имеет несовместимый тип.");
            }

            player.UpdateEquipmentBonuses();
        }




        public int GetArmorPoints()
        {
            int totalArmor = 0;

            if (head != null)
            {
                totalArmor += head.ArmorValue;
            }
            if (body != null)
            {
                totalArmor += body.ArmorValue;
            }
            if (hands != null)
            {
                totalArmor += hands.ArmorValue;
            }
            if (legs != null)
            {
                totalArmor += legs.ArmorValue;
            }
            if (boots != null)
            {
                totalArmor += boots.ArmorValue;
            }

            return totalArmor;
        }

        public int GetManaPoints(Player player)
        {
            int totalMana = 0;
            if (player is Mage)
            {
                if (weapon != null)
                {
                    totalMana += weapon.ManaValue;
                }
                if (head != null)
                {
                    totalMana += head.ManaValue;
                }
                if (body != null)
                {
                    totalMana += body.ManaValue;
                }
                if (hands != null)
                {
                    totalMana += hands.ManaValue;
                }
                if (legs != null)
                {
                    totalMana += legs.ManaValue;
                }
                if (boots != null)
                {
                    totalMana += boots.ManaValue;
                }
                if (ring1 != null)
                {
                    totalMana += ring1.ManaValue;
                }
                if (ring2 != null)
                {
                    totalMana += ring2.ManaValue;
                }
                if (necklace != null)
                {
                    totalMana += necklace.ManaValue;
                }
            }
            



            return totalMana;
        }
        public int GetIntelligencePoint(Player player)
        {
            int totalIntelligence = 0;
            if (player is Mage)
            {

                if (weapon != null)
                {
                    totalIntelligence += weapon.IntelligenceValue;
                }


                if (head != null)
                {
                    totalIntelligence += head.IntelligenceValue;
                }
                if (body != null)
                {
                    totalIntelligence += body.IntelligenceValue;
                }
                if (hands != null)
                {
                    totalIntelligence += hands.IntelligenceValue;
                }
                if (legs != null)
                {
                    totalIntelligence += legs.IntelligenceValue;
                }
                if (boots != null)
                {
                    totalIntelligence += boots.IntelligenceValue;
                }
                if (ring1 != null)
                {
                    totalIntelligence += ring1.IntelligenceValue;
                }
                if (ring2 != null)
                {
                    totalIntelligence += ring2.IntelligenceValue;
                }
                if (necklace != null)
                {
                    totalIntelligence += necklace.IntelligenceValue;
                }
            }

            return totalIntelligence;
        }

        public int GetRagePoint(Player player)
        {
            int totalRage = 0;
            if (player is Warrior)
            {
                if (weapon != null)
                {
                    totalRage += weapon.RageValue;
                }
                if (head != null)
                {
                    totalRage += head.RageValue;
                }
                if (body != null)
                {
                    totalRage += body.RageValue;
                }
                if (hands != null)
                {
                    totalRage += hands.RageValue;
                }
                if (legs != null)
                {
                    totalRage += legs.RageValue;
                }
                if (boots != null)
                {
                    totalRage += boots.RageValue;
                }
                if (ring1 != null)
                {
                    totalRage += ring1.RageValue;
                }
                if (ring2 != null)
                {
                    totalRage += ring2.RageValue;
                }
                if (necklace != null)
                {
                    totalRage += necklace.RageValue;
                }
            }



            return totalRage;
        }



        public int GetStrengthPoint(Player player)
        {
            int totalStrength = 0;


            if (weapon != null)
            {
                totalStrength += weapon.StrengthValue;
            }
            if (head != null)
            {
                totalStrength += head.StrengthValue;
            }
            if (body != null)
            {
                totalStrength += body.StrengthValue;
            }
            if (hands != null)
            {
                totalStrength += hands.StrengthValue;
            }
            if (legs != null)
            {
                totalStrength += legs.StrengthValue;
            }
            if (boots != null)
            {
                totalStrength += boots.StrengthValue;
            }
            if (ring1 != null)
            {
                totalStrength += ring1.StrengthValue;
            }
            if (ring2 != null)
            {
                totalStrength += ring2.StrengthValue;
            }
            if (necklace != null)
            {
                totalStrength += necklace.StrengthValue;
            }

            return totalStrength;
        }



        private bool CanEquipItem(Item item, Player player)
        {
            if (item is Armor armorItem)
            {
                if (player is Mage && armorItem.Class == "mage")
                {
                    return true;
                }
                else if (player is Warrior && armorItem.Class == "warrior")
                {
                    return true;
                }
            }
            else if (item is Weapon weaponItem)  
            {
                if (player is Mage && weaponItem.Class == "mage")
                {
                    return true;
                }
                else if (player is Warrior && weaponItem.Class == "warrior")
                {
                    return true;
                }
            }

            return false;
        }



    }
}