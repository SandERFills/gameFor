using System;

namespace behaviorOne
{
    public class Actor
    {
        private string heroName;
        private int healhPoints;
        private int damage;
        public Actor(){}
        public Actor(string name,int hp,int dmg){
                this.heroName = name;
                this.healhPoints=hp;
                this.damage=dmg;
Console.WriteLine(heroName);
        }
        public void PrintName(){
        
        }
    }
}
