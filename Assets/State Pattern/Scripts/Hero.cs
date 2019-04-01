using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class Hero
    {
        HeroBaseState heroState = null;

        public Hero()
        {
            heroState = new IdleState(this);
        }

        public void SetHeroState(HeroBaseState newState)
        {
            heroState.OnStateExit();
            heroState = newState;
            heroState.OnStateEnter();
        }

        public void HandleInput()
        {

        }


        public void Update()
        {
            heroState.HandleInput();
            heroState.Execute();
        }
    }
}

