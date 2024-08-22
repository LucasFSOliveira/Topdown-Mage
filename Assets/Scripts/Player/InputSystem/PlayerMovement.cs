using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace Player.InputSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        static readonly int SpeedParameterHash = Animator.StringToHash("Speed");
        
        
        [SerializeField] Animator animator;
        [SerializeField] GameObject view;
        private PlayerStats stats;
        private float speed;
        
        void Start()
        {
            stats = GetComponent<PlayerStats>();
        }
        void Update()
        {
            speed = stats.MovementSpeed;
            Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position = transform.position + playerInput.normalized * (speed * Time.deltaTime);
            
            animator.SetFloat(SpeedParameterHash, playerInput.magnitude);
            if (playerInput.magnitude > 0.05f)
            {
                view.transform.right = Vector2.Dot(playerInput, Vector2.right) * Vector2.right;
            }
        }
    }   
}