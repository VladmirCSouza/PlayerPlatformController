namespace Channel3.Character.Behaviors
{
    public interface ICharacterBehaviour
    {
        void OnStateEnter();
        void Update();
        void FixedUpdate();
        void OnStateExit();
    }
}

