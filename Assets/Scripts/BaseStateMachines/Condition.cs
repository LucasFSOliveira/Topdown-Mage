using UnityEngine;

namespace BaseStateMachines
{
    public abstract class Condition : MonoBehaviour
    {
        public abstract bool IsMet();
    }
}