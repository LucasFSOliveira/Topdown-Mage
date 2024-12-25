using System.Collections.Generic;
using UnityEngine;
using combatSystem;
using combatSystem.abilitySystem;
using combatSystem.abilitySystem.abilities;

namespace Player
{
    public class PlayerAbilities : MonoBehaviour, IHaveAbilities
    {
        [SerializeField] private List<Ability> abilities;

        public List<IAbility> Abilities => abilities.ConvertAll(ability => (IAbility)ability);

        private void Update()
        {   
            if (abilities.Count <= 0) return;
            foreach (var ability in abilities)
            {
                ability.Update();
            }
        }

        public void ActivateAbility(int index, Vector3 targetPosition)
        {
            if (index >= 0 && index < abilities.Count)
            {
                abilities[index].Activate(GetComponent<IStats>(), targetPosition);
            }
            else
            {
                Debug.LogWarning("Ability index out of range.");
            }
        }

        public void AddAbility(Ability ability)
        {
            abilities.Add(ability);
            Debug.Log($"Ability {ability.GetType().Name} added.");
        }

        public void RemoveAbility(Ability ability)
        {
            if (abilities.Contains(ability))
            {
                abilities.Remove(ability);
                Debug.Log($"Ability {ability.GetType().Name} removed.");
            }
            else
            {
                Debug.LogWarning("Ability not found in the list.");
            }
        }
    }
}