using Enemies.enemyTypes.enemyAI;
using Managers;
using UnityEngine;

namespace Enemies.enemyTypes.generic
{
    public class EnemyAnimationHandler : MonoBehaviour
    {
        static readonly int SpeedParameterHash = Animator.StringToHash("Speed");

        private Animator animator;
        private Transform view;
        private Transform enemyTransform;
        private LevelManager levelManager;
        private string currentState;

        void Start()
        {
            enemyTransform = GetComponent<Transform>();
            view = GetComponentInChildren<Transform>();
            animator = GetComponentInChildren<Animator>();
            levelManager = GameObject.FindWithTag("LevelManagerHolder").GetComponent<LevelManager>();
            FixEnemySpawnRotation();
        }
        public void FixEnemySpawnRotation()
        {
            enemyTransform.rotation = Quaternion.Euler(0, 0, 0);
        }

        public void Chase()
        {
            Vector3 enemyDirection = levelManager.Player.transform.position - enemyTransform.position;
            animator.SetFloat(SpeedParameterHash, enemyDirection.magnitude);
            if (enemyDirection.magnitude > 0.05f)
            {
                view.transform.right = Vector2.Dot(enemyDirection, Vector2.right) * Vector2.right;
            }
        }

        public void Update()
        {
            currentState = GetComponent<EnemyBehaviour>().StateMachine.CurrentState.GetType().Name;
            switch (currentState)
            {
                case "Idle":
                    
                    break;
                case "Chase":
                    Chase();
                    break;
                case "Attack":
                    
                    break;
                case "Dead":
                    
                    break;
            }
        }
    }
}