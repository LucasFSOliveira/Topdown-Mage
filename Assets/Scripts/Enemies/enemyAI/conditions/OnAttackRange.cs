using BaseStateMachines;

namespace Enemies.enemyAI.conditions
{
    public class OnAttackRange : Condition
    {
        public override bool IsMet()
        {
            var player = enemyActions.SearchForPlayer(enemyActions.stats.AttackRange);
            return player is not null;
        }
    }
}