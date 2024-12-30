using healthSystem;
using Scriptable_Objects_Scripts;
using UnityEngine;

namespace combatSystem
{
    public interface IStats
    {
        Health Health { get; }
        CharacterType ClassType { get; }
        float Damage { get; }
        float MagicPower { get; }
        float Armor { get; }
        float AttackSpeed { get; }
        float AttackRange { get; }
        float VisionRange { get; }
        float CooldownReduction { get; }
        float MovementSpeed { get; }

        void ChangeHealth(float amount);
        void ChangeDamage(float amount);
        void ChangeMagicPower(float amount);
        void ChangeArmor(float amount);
        void ChangeAttackSpeed(float amount);
        void ChangeAttackRange(float amount);
        void ChangeVisionRange(float amount);
        void ChangeCooldownReduction(float amount);
        void ChangeMovementSpeed(float amount);
    }

}