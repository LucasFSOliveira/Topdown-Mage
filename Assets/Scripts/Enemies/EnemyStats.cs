using combatSystem;
using healthSystem;
using UnityEngine;

namespace Enemies
{
    public class EnemyStats : MonoBehaviour, IStats
    {
        private Health health;
        [SerializeField] private float maxHealth;
        [SerializeField] private float damage;
        [SerializeField] private float magicPower;
        [SerializeField] private float armor;
        [SerializeField] private float attackSpeed;
        [SerializeField] private float cooldownReduction;

        public Health Health => health;
        public float Damage => damage;
        public float MagicPower => magicPower;
        public float Armor => armor;
        public float AttackSpeed => attackSpeed;
        public float CooldownReduction => cooldownReduction;
        public Transform Transform => transform;

        private void Start()
        {
            health = gameObject.AddComponent<Health>();
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

        public void ChangeCooldownReduction(float amount)
        {
            cooldownReduction += amount;
        }
    }
}