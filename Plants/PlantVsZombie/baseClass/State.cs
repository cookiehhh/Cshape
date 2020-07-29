using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantVsZombie.interfaces;

namespace PlantVsZombie.baseClass
{
    public class State : IState
	{
        private int currentState;


        public int getCurrentState()
        {
            return currentState;
        }
    }
}
