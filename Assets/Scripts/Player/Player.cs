using Channel3.Character;
using Channel3.Character.State;
using UnityEngine;

[RequireComponent (typeof(Character))]
public class Player : Character
{    
    public delegate void OnPlayerStateChange(ICharacterState newPlayerState);
    public event OnPlayerStateChange OnStateChange;

    public override void Start()
    {
        base.Start();
        currentState = new Idle();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log(currentState.GetType());
            currentState.Update();
        }
    }

    public override void OnStateEnter(ICharacterState state)
    {
        Debug.Log("On state ENTER");
        OnStateChange?.Invoke(state);
    }

    public override void OnStateUpdate(ICharacterState state)
    {
        Debug.Log("On state UPDATE");
    }

    public override void OnStateExit(ICharacterState state)
    {
        Debug.Log("On state EXIT");
    }

    public override bool CheckForValidStateChange(ICharacterState state)
    {
        Debug.Log("On state CHECK VALID STATE CHANGE");
        return true;
    }
}
