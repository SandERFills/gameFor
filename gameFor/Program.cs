using System;
using behaviorOne;

namespace ConsoleWar
{
    class Program
    {
        
static bool AttackeIter(Actor attacker,Actor defender)
        {
            
           Console.WriteLine(attacker.heroName+" бьёт "+defender.heroName);
           defender.healhPoints-=attacker.damage;
            if (defender.healhPoints<0 )
            {
                return true;
            }
            else
            {
                System.Console.WriteLine("YOU DEAD!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            System.Console.Write("Введите имя вашего героя: ");
            string itputPerson =Console.ReadLine();
            bool isEnable=false;
            Actor hero =new Actor(itputPerson,100,20);
            Actor enemy =new Actor("Убийца",50,60);
            System.Console.WriteLine(hero.healhPoints);
           System.Console.WriteLine("Ваше имя :" +hero.PrintName());
           System.Console.Write("Готовы ли вы идти? ");
           itputPerson=Console.ReadLine();
            if(itputPerson.ToLower()=="yes" || itputPerson.ToLower()=="да"){
                isEnable=true;
            }

            while (isEnable)
            {
                System.Console.WriteLine("Плечо ныло от воткнутого в него клинка");
                // if(AttackeIter(enemy, hero)){
                //     System.Console.WriteLine("YOU DEAD!");
                //     break;
                // }
                System.Console.WriteLine("О нет ,он ударил и осталось"+hero.healhPoints);
                
            }
            
        }
    }
}
