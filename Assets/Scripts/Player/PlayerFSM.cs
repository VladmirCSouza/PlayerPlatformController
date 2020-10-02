using Channel3.Character.State;
using Channel3.Utils.Singleton;

public class PlayerFSM : Singleton<PlayerFSM>
{
    public ICharacterState CurrentState { get; private set; }

    public bool ValidUpdate { get; private set; }
    public void ChangeState(ICharacterState newState)
    {
        CurrentState = newState;
        ValidUpdate = true;

    }

    public void Reset()
    {
        ValidUpdate = false;
    }

}