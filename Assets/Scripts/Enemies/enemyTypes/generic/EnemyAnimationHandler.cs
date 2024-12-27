using UnityEngine;

namespace Enemies.enemyTypes.generic
{
    public class EnemyAnimationHandler : MonoBehaviour
    {
        static readonly int SpeedParameterHash = Animator.StringToHash("Speed");

        private Animator animator;
        private Transform view;
        private Transform enemyTransform;

        void Start()
        {
            enemyTransform = GetComponent<Transform>();
            view = GetComponentInChildren<Transform>();
            animator = GetComponentInChildren<Animator>();
        }

        public void Move(Vector3 playerPosition)
        {
            Vector3 enemyDirection = playerPosition - enemyTransform.position;

            animator.SetFloat(SpeedParameterHash, enemyDirection.magnitude);
            if (enemyDirection.magnitude > 0.05f)
            {
                view.transform.right = Vector2.Dot(enemyDirection, Vector2.right) * Vector2.right;
            }
        }
    }
}