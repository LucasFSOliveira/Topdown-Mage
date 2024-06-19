using UnityEngine;

namespace combatSystem
{
    public interface IStats
    {
        float Damage { get; }
        float MagicPower { get; }
        float Armor { get; }
        float AttackSpeed { get; }
        float CooldownReduction { get; }
        Transform Transform { get; }

        void ChangeDamage(float amount);
        void ChangeMagicPower(float amount);
        void ChangeArmor(float amount);
        void ChangeAttackSpeed(float amount);
        void ChangeCooldownReduction(float amount);
    }
}