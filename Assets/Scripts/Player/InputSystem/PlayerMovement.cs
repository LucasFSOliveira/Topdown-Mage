using UnityEngine;

namespace Player.InputSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        public float Speed => speed;

        void Update()
        {
            Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position = transform.position + playerInput.normalized * (Speed * Time.deltaTime);
        }

        public void ChangeSpeed(float amount)
        {
            speed += amount;
        }
    }   
}