using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Character
    {
        public string _name;
        public int _life;
        public int _attack;
        public int _defense;

        public Character(string name, int life, int attack, int defense)
        {
            this._name = name;
            this._life = life;
            this._attack = attack;
            this._defense = defense;
        }


        public bool IsAlive()
        {
            if (this._life > 0) return true;
            else return false;
        }

        public void Attack(Character character)
        {
            character._life = character._life - (character._attack - character._defense);
        }
    }
}
