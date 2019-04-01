using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public abstract class IWeapon
    {
        protected string weaponName = "";
        protected int attack = 0;
        protected float range = 0f;

        protected ICharacter weaponOwner = null;

        protected string bulletName = "";
        protected Vector3 bulletSpawnPosition = Vector3.zero;
        protected Vector3 bulletSpawnSpeed = Vector3.forward;
        protected string particleName = "";
        protected string audioName = "";

        public void SetOwner(ICharacter character)
        {
            weaponOwner = character;
        }

        public string GetWeaponName()
        {
            return weaponName;
        }

        public int GetAttackValue()
        {
            return attack;
        }

        public float GetAttackRange()
        {
            return range;
        }


        protected void SpawnBullet()
        {
            Debug.Log("子弹名字：" + bulletName+ "  子弹初始位置：" + bulletSpawnPosition + "  子弹初速度：" + bulletSpawnSpeed);
        }

        protected void ShowShootEffect()
        {
            Debug.Log("枪口特效：" + particleName);
        }


        protected void ShowSoundEffect()
        {
            Debug.Log("开火音效：" + audioName);
        }


        public abstract void Fire(ICharacter target);

        ~IWeapon()
        { }

    }
}

