using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class RunState : HeroBaseState
    {
        private Hero hero = null;

        public RunState(Hero hero)
        {
            this.hero = hero;
        }

        public void Execute()
        {
            Debug.Log("主角在跑步状态中...");
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
            else if (Input.GetKeyDown(KeyCode.V))
            {
                hero.SetHeroState(new IdleState(hero));
            }
        }

        public void OnStateEnter()
        {
            Debug.Log("主角进入跑步状态！");
        }

        public void OnStateExit()
        {
            Debug.Log("主角退出跑步状态！");
        }
    }
}
