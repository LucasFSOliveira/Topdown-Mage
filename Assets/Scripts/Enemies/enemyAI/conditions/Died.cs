using BaseStateMachines;

namespace Enemies.enemyAI.conditions
{
    public class Died : Condition
    {
        public override bool IsMet()
        {
            return enemyActions.stats.Health.CurrentHealth <= 0;
        }
    }
}
