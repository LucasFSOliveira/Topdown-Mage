using combatSystem;
using healthSystem;
using Scriptable_Objects_Scripts;
using UnityEngine;

namespace Enemies.generic
{
    public class EnemyStats : MonoBehaviour, IStats
    {
        [SerializeField] private Health health;
        [SerializeField] private CharacterType classType;
        [SerializeField] private float maxHealth;
        [SerializeField] private float damage;
        [SerializeField] private float magicPower;
        [SerializeField] private float armor;
        [SerializeField] private float attackSpeed;
        [SerializeField] private float attackRange;
        [SerializeField] private float visionRange;
        [SerializeField] private float cooldownReduction;
        [SerializeField] private float movementSpeed;

        public Health Health => health;
        public CharacterType ClassType => classType;
        public float Damage => damage;
        public float MagicPower => magicPower;
        public float Armor => armor;
        public float AttackSpeed => attackSpeed;
        public float AttackRange => attackRange;
        public float VisionRange => visionRange;
        public float CooldownReduction => cooldownReduction;
        public float MovementSpeed => movementSpeed;
        public Transform Transform => transform;

        private void Start()
        {
            health.setMaxHealth(maxHealth);
        }

        public void ChangeHealth(float amount)
        {
            health.changeMaxHealth(amount);
        }
        
        public void ChangeDamage(float amount)
        {
            damage += amount;
        }

        public void ChangeMagicPower(float amount)
        {
            magicPower += amount;
        }

        public void ChangeArmor(float amount)
        {
            armor += amount;
        }

        public void ChangeAttackSpeed(float amount)
        {
            attackSpeed *= amount;
        }

        public void ChangeAttackRange(float amount)
        {
            attackRange *= amount;
        }

        public void ChangeVisionRange(float amount)
        {
            visionRange *= amount;
        }

        public void ChangeCooldownReduction(float amount)
        {
            cooldownReduction += amount;
        }

        public void ChangeMovementSpeed(float amount)
        {
            movementSpeed += amount;
        }
    }
}