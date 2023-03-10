using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyGame
{
    public static class ItemFactory
    {
        public static Item[] Items = new Item[]
        {
            new Item("Кунаи","Assets/Images/kynai.jpg",new Point(2, 3))
            {
                Hp = 0, Hungry = 0, Damage = 15
            },
            new Item("Чидори","Assets/Images/chidori.jpg",new Point(1,5))
            {
                Hp = 5, Hungry = 0, Damage = 35
            },
            new Item("Рениган","Assets/Images/renigan.png",new Point(5,4))
            {
                Hp = 20, Hungry = 0, Damage = 58
            },
            new Item("Бьякуган","Assets/Images/bykygan.jpg",new Point(0,6))
            {

                Hp = 15, Hungry = 0, Damage = 35
            },
            new Item("Расенган","Assets/Images/rasengan.jpg",new Point(2,6))
            {

                Hp = 20, Hungry = 0, Damage = 69
            },
            new Item("Меч Самехада", "Assets/Images/Samehada.jpg",new Point(2,1))
            {

                Hp = 15, Hungry = 0, Damage = 43
            },
            new Item("Клан Чиноике","Assets/Images/Chinoike.jpg",new Point(3,6))
            {

                Hp = 30, Hungry = 0, Damage = 48
            },

            new Item("Техника бога грома","Assets/Images/thunder_god_technique.jpg",new Point(4,6))
            {

                Hp = 80, Hungry = 0, Damage = 16
            },
            new Item("Техника призыва","Assets/Images/summoning_technique.jpg",new Point(5,3))
            {

                Hp = 40, Hungry = 0, Damage = 35
             },

            new Item("Печать техники Силы сотни","Assets/Images/Forces_of_a_hundred.jpg",new Point(1,6))
            {

                Hp = 90, Hungry = 0, Damage = 23
            },

        };


    }
}
