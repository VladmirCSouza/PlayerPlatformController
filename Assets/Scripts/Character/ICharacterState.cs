namespace Channel3.Character.State
{
    public interface ICharacterState
    {
        string Id { get; }

        void OnStateEnter();
        void Update();
        void FixedUpdate();
        void OnStateExit();
    }
}

