using System;

namespace behaviorOne
{
    public class Actor
    {
        public string heroName;
        public int healhPoints;
        public int damage;
        public Actor(){}
        public Actor(string name,int hp,int dmg){
                this.heroName = name;
                this.healhPoints=hp;
                this.damage=dmg;    

        }
        public string PrintName(){
        return heroName;
        }
        
    }
}
