using BaseStateMachines;

namespace Enemies.enemyAI.conditions
{
    public class OffAttackRange : Condition
    {
        public override bool IsMet()
        {
            var player = enemyActions.SearchForPlayer(enemyActions.stats.AttackRange);
            return player is null;
        }
    }
}