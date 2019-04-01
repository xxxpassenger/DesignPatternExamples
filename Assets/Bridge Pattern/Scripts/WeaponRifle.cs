using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class WeaponRifle : IWeapon
    {
        public WeaponRifle()
        {
            weaponName = "AKM";
            attack = 20;
            range = 150f;
            weaponOwner = null;
            bulletName = "RifleBullet";
            bulletSpawnPosition = Vector3.zero;
            bulletSpawnSpeed = Vector3.forward;
            particleName = "RifleParticle";
            audioName = "RifleAudioName";
        }
        public override void Fire(ICharacter target)
        {
            ShowShootEffect();
            SpawnBullet();
            ShowSoundEffect();

            target.UnderAttack(weaponOwner);
        }
    }
}

