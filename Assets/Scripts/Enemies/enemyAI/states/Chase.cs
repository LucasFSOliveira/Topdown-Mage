using State = BaseStateMachines.State;

namespace Enemies.enemyAI.states
{
    public class Chase : State
    {
        public override void Enter() => gameObject.SetActive(true);

        public override void Exit() => gameObject.SetActive(false);

        public override void Execute()
        {
            enemyActions.MoveToPlayer();
        }   
    }
}
