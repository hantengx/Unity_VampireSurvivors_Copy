using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonSpawner : WeaponSpawner
{
    internal override IEnumerator StartAttack()
    {
        while (true)
        {
            SpawnWeapon(Direction.Self);
            yield return new WaitForSeconds(GetAttackSpeed());
        }
    }
}