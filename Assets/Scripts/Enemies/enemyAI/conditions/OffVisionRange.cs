using BaseStateMachines;

namespace Enemies.enemyAI.conditions
{
    public class OffVisionRange : Condition
    {
        private OnVisionRange onVisionRange;

        private void Start()
        {
            onVisionRange = GetComponent<OnVisionRange>();
        }

        public override bool IsMet()
        {
            return !onVisionRange.IsMet();
        }
    }
}