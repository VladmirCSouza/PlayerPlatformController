using Channel3.Character.State;
using UnityEngine;

public class Idle : ICharacterState
{
    private string id = "IDLE";
    public string Id { get => id; }

    public void OnStateEnter()
    {
        Debug.Log("OnStateEnter");
    }

    public void Update()
    {
        Debug.Log("Idle Update");
        if (Input.GetAxis("Horizontal") != 0)
        {
            PlayerFSM.Instance.ChangeState(new WalkState());
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
