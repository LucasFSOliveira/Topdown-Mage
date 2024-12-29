namespace BaseStateMachines
{
    public interface IState
    {
        IState ProcessTransitions();
        
        void Enter();
        
        void Exit();
        
        void Execute();
    }
}