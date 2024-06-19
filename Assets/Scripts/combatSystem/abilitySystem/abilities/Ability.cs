using UnityEngine;

namespace combatSystem.abilitySystem.abilities
{
    public abstract class Ability : MonoBehaviour, IAbility
    {
        protected float BaseCooldown;
        private float cooldownTimer;
        public float Cooldown => cooldownTimer;

        public bool IsOnCooldown()
        {
            return cooldownTimer > 0f;
        }

        public virtual void Activate(IStats stats)
        {
            Activate(stats, Vector3.zero);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public virtual void Activate(IStats stats, Vector3 targetPosition)
        {
            if (cooldownTimer <= 0f)
            {
                Execute(stats, targetPosition);
                float cooldownReductionFactor = (100f - stats.CooldownReduction) / 100f;
                cooldownTimer = BaseCooldown * cooldownReductionFactor;
            }
            else
            {
                Debug.Log($"{gameObject.GetType().Name} is on cooldown. {cooldownTimer}s remaining");
            }
        }

        protected abstract void Execute(IStats stats, Vector3 targetPosition);

        protected internal virtual void Update()
        {
            if (cooldownTimer > 0f)
            {
                cooldownTimer -= Time.deltaTime;
            }
        }
    }
}