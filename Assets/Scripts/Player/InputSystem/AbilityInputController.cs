using UnityEngine;

namespace Player.InputSystem
{
    public class AbilityInputController : MonoBehaviour
    {
        private PlayerAbilities playerAbilities;

        private void Start()
        {
            playerAbilities = GetComponent<PlayerAbilities>();
            if (playerAbilities == null)
            {
                Debug.LogError("PlayerAbilities component not found on this GameObject.");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Vector3 mousePosition = GetMouseWorldPosition();
                playerAbilities.ActivateAbility(0, mousePosition);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Vector3 mousePosition = GetMouseWorldPosition();
                playerAbilities.ActivateAbility(1, mousePosition);
            }
        }

        private Vector3 GetMouseWorldPosition()
        {
            Vector3 mouseScreenPosition = Input.mousePosition;
            Vector3 mouseWorldPosition = Camera.main!.ScreenToWorldPoint(mouseScreenPosition);
            mouseWorldPosition.z = 0;
            return mouseWorldPosition;
        }
    }
}