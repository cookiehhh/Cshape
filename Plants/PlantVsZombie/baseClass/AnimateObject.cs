using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlantVsZombie.baseClass
{
    class AnimateObject : BaseObject
    {
        public AnimateObject() : base() { }
        public AnimateObject(Point location) : base(location) { }
        //血量
        public int Blood { get; private set; }
        //id
        //攻击时的伤害
        protected int damage;
        public int Damage { get { return damage; } }
        //对象拥有的状态
        protected State state;
    }
}
