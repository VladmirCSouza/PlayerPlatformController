namespace Channel3.Character.State
{
    public interface ICharacterState
    {
        void OnStateEnter();
        void Update();
        void FixedUpdate();
        void OnStateExit();
    }
}

