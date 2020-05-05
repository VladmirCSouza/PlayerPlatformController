using Channel3.Character.State;
using Channel3.Utils.Singleton;
using UnityEngine;

public class PlayerFSM : Singleton<PlayerFSM>
{

    private ICharacterState currentState;
    public ICharacterState CurrentState => currentState;

    public void ChangeState(ICharacterState newState)
    {
        // Leave like this for now
        if(CheckForValidStateChange(newState))
            currentState = newState;
    }

    public void OnStateEnter(ICharacterState state)
    {
        
    }

    public void StateUpdate()
    {
        currentState.Update();
    }

    public void StateFixedUpdate(ICharacterState state)
    {

    }

    public void OnStateExit(ICharacterState state)
    {
        
    }

    public bool CheckForValidStateChange(ICharacterState newState)
    {
        if(currentState == null)
            return true;

        if(currentState.Id == newState.Id)
            return false;

        return true;
    }
}