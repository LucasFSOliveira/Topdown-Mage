using combatSystem;
using combatSystem.healthSystem;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.generic
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyActions : MonoBehaviour
    {
        internal GameObject PlayerGameObject;
        internal IStats PlayerStats;
        internal IDamageable PlayerHealth;
        [SerializeField] internal EnemyStats stats;
        [SerializeField] internal Animator animator;
        [SerializeField] private string playerTag;
        [SerializeField] private LayerMask playerLayerMask;
        [SerializeField] private NavMeshAgent navMeshAgent;

        public GameObject SearchForPlayer(float range)
        {
            if (PlayerGameObject is not null && Vector2.Distance(PlayerGameObject.transform.position,
                                                                    transform.position) <= range)
                return PlayerGameObject;

            Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, range, playerLayerMask.value);
            if (playerCollider is not null)
            {
                PlayerGameObject = playerCollider.gameObject;
                PlayerStats = PlayerGameObject.GetComponent<IStats>();
                PlayerHealth = PlayerGameObject.GetComponent<IDamageable>();
                return PlayerGameObject;
            }

            return null;
        }

        public void MoveToPlayer()
        {
            if (PlayerGameObject is null) return;
            navMeshAgent.SetDestination(PlayerGameObject.transform.position);
        }

        public void MoveToTargetPosition(Vector3 targetPosition)
        {
            navMeshAgent.SetDestination(targetPosition);
        }

        /// <summary>
        /// Generates a random position within a specified range around the current position of the game object.
        /// </summary>
        /// <param name="range">The range within which to generate the random position.</param>
        /// <returns>A new position as a Vector3.</returns>
        public Vector2 SetRandomPosition(float range)
        {
            Vector3 randomCirclePos = Random.insideUnitCircle.normalized * Mathf.Max(Random.insideUnitSphere.magnitude, 0.2f);
            NavMeshHit hit;
            if (NavMesh.SamplePosition(transform.position + randomCirclePos, out hit, range, NavMesh.AllAreas))
            {
                return hit.position;
            }
            return SetRandomPosition(range/2); // Search for a new(close) position if the current one is invalid
        }
    }
}
