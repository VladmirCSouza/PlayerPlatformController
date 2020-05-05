using Channel3.Character.State;
using UnityEngine;

public class WalkState : ICharacterState
{
    private string id = "WALK_STATE";
    public string Id { get => id; }

    public void OnStateEnter()
    {
        Debug.Log("OnStateEnter");
    }

    public void Update()
    {
        Debug.Log("Walk Update");
        if (Input.GetAxis("Horizontal") == 0)
        {
            PlayerFSM.Instance.ChangeState(new Idle());
        }
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
