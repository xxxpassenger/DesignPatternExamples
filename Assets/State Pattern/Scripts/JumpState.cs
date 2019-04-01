using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace DesignPattern
{
    public class JumpState : HeroBaseState
    {
        private Hero hero;
        public JumpState(Hero hero)
        {
            this.hero = hero;
        }

        public void Execute()
        {
            Debug.Log("主角在跳跃状态中...");
        }

        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("主角已经在跳跃中...");
                return;
            }
        }

        public void OnStateEnter()
        {
            Debug.Log("主角进入跳跃状态！");
            Thread.Sleep(1000);
            hero.SetHeroState(new IdleState(hero));
        }

        public void OnStateExit()
        {
            Debug.Log("主角退出跳跃状态！");
        }
    }
}

