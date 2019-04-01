using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class BridgePatternTest : MonoBehaviour
    {
        void Start()
        {

            IWeapon pistol = new WeaponPistol();
            IWeapon rifle = new WeaponRifle();
            ICharacter soldier = new Soldier();
            ICharacter enemy = new Enemy();


            //example 1:
            /*
            soldier.SetWeapon(pistol);
            enemy.SetWeapon(rifle);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            */

            //example 2:

            soldier.SetWeapon(rifle);
            enemy.SetWeapon(pistol);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
            enemy.Attack(soldier);
        }
    }
}

