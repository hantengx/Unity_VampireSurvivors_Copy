using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Data", menuName = "Scriptable Object/Weapon Data", order = int.MaxValue)]
public class WeaponData : ScriptableObject
{
    public enum WeaponType
    {
        Whip,
        Axe,
        Bible,
        Lightning,
        MagicWand,
        Pigeon
    }

    [SerializeField] WeaponType weaponType;
    [SerializeField] int attackPower;
    [SerializeField] float attackSpeed;
    [SerializeField] float inactiveDelay;
    [SerializeField] Sprite weaponSprite;
    [SerializeField] string description;

    public WeaponType GetWeaponType()
    {
        return weaponType;
    }

    public int GetAttackPower()
    {
        return attackPower;
    }

    public float GetAttackSpeed()
    {
        return attackSpeed;
    }

    public float GetInactiveDelay()
    {
        return inactiveDelay;
    }

    public Sprite GetSprite()
    {
        return weaponSprite;
    }

    public string GetDescription()
    {
        return description;
    }
}