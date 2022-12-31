public abstract class BaseState {
    //instance of enemy class
    public Enemy enemy;
    public StateMachine stateMachine;

    //instance of statemachine class

    public abstract void Enter();
    public abstract void Perform();
    public abstract void Exit();
}
