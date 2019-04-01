using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class IdleState : HeroBaseState
    {
        private Hero hero = null;
        public IdleState(Hero hero)
        {
            this.hero = hero;
        }
        public void Execute()
        {
            Debug.Log("主角在站立状态中...");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                hero.SetHeroState(new JumpState(hero));
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                hero.SetHeroState(new CrouchState(hero));
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                hero.SetHeroState(new RunState(hero));
            }
        }

        public void OnStateEnter()
        {
            Debug.Log("主角进入站立状态！");
        }

        public void OnStateExit()
        {
            Debug.Log("主角退出站立状态！");
        }
    }
}

