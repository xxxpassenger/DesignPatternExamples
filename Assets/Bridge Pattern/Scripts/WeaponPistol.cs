using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class WeaponPistol : IWeapon
    {
        public WeaponPistol()
        {
            weaponName = "P92";
            attack = 10;
            range = 50f;
            weaponOwner = null;
            bulletName = "PistolBullet";
            bulletSpawnPosition = Vector3.zero;
            bulletSpawnSpeed = Vector3.forward;
            particleName = "PistolParticle";
            audioName = "PistolAudioName";
        }

        public override void Fire(ICharacter target)
        {
            ShowShootEffect();
            SpawnBullet();
            ShowSoundEffect();

            target.UnderAttack(weaponOwner);
        }

        ~WeaponPistol()
        { }
    }
}

