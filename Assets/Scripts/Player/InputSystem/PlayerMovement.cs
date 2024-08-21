using UnityEngine;

namespace Player.InputSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        static readonly int SpeedParameterHash = Animator.StringToHash("Speed");
        
        [SerializeField] private float speed;
        private float Speed => speed;
        [SerializeField] Animator animator;
        [SerializeField] GameObject view;
        
        void Update()
        {
            Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position = transform.position + playerInput.normalized * (Speed * Time.deltaTime);
            
            animator.SetFloat(SpeedParameterHash, playerInput.magnitude);
            if (playerInput.magnitude > 0.05f)
            {
                view.transform.right = Vector2.Dot(playerInput, Vector2.right) * Vector2.right;
            }
        }

        public void ChangeSpeed(float amount)
        {
            speed += amount;
        }
    }   
}