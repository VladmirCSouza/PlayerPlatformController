using Channel3.Character.State;
using UnityEngine;

public class MoveCrouchedState : ICharacterState
{
    private string id = "MOVE_CROUCHED_STATE";
    public string Id { get => id; }

    public void OnStateEnter()
    {
        Debug.Log("OnStateEnter");
    }

    public void Update()
    {
        Debug.Log("Update");
    }
    
    public void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    
    public void OnStateExit()
    {
        Debug.Log("OnStateEnter");
    }
}
