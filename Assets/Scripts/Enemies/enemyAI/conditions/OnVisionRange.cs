using BaseStateMachines;

namespace Enemies.enemyAI.conditions
{
    public class OnVisionRange : Condition
    {
        public override bool IsMet()
        {
            var player = enemyActions.SearchForPlayer(enemyActions.stats.VisionRange);
            return player is not null;
        }
    }
}