using BaseStateMachines;

namespace Enemies.enemyAI.states
{
    public class Idle : State
    {
        public override void Enter() => gameObject.SetActive(true);

        public override void Exit() => gameObject.SetActive(false);

        public override void Execute()
        {
            
        }   
    }
}
