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
