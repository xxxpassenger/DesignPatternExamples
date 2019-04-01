using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public abstract class ICharacter
    {
        protected int hp = 100;

        protected string characterName = "";

        private IWeapon weapon = null;

        public void SetWeapon(IWeapon weapon)
        {
            if (this.weapon!=null)
            {
                this.weapon = null;
            }
            this.weapon = weapon;

            weapon.SetOwner(this);      
        }

        public IWeapon GetWeapon()
        {
            return weapon;
        }


        public string GetCharacterName()
        {
            return characterName;
        }

        protected void WeaponAttackTarget(ICharacter target)
        {
            weapon.Fire(target);
        }

        public int GetAttackValue()
        {
            return weapon.GetAttackValue();
        }


        public float GetAttackRange()
        {
            return weapon.GetAttackRange();
        }

        public abstract void Attack(ICharacter target);

        public abstract void UnderAttack(ICharacter target);

        public abstract void Death(ICharacter attacker,IWeapon attackWeapon);
    }
}

