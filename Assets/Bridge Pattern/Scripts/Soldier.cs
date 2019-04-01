using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class Soldier : ICharacter
    {
        public Soldier()
        {
            characterName = "地球卫士";
            hp = 80;
        }
        public override void Attack(ICharacter target)
        {
            WeaponAttackTarget(target);
        }

        public override void UnderAttack(ICharacter target)
        {
            IWeapon underAttackWeapon = target.GetWeapon();
            int damage = underAttackWeapon.GetAttackValue();
            hp = (hp - damage < 0 ? 0 : hp - damage);
            if (hp == 0)
            {
                Death(target, underAttackWeapon);
            }
        }

        public override void Death(ICharacter attacker, IWeapon attackWeapon)
        {
            Debug.Log(attacker.GetCharacterName() + "用" + attackWeapon.GetWeaponName() + "击倒了" + this.characterName);
        }
    }
}

