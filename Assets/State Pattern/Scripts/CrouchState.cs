using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class CrouchState : HeroBaseState
    {
        private Hero hero = null;
        public CrouchState(Hero hero)
        {
            this.hero = hero;
        }
        public void Execute()
        {
            Debug.Log("主角在蹲下状态中...");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                hero.SetHeroState(new JumpState(hero));
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                hero.SetHeroState(new IdleState(hero));
            }
        }

        public void OnStateEnter()
        {
            Debug.Log("主角进入蹲下状态！");
        }

        public void OnStateExit()
        {
            Debug.Log("主角退出蹲下状态！");
        }
    }
}

