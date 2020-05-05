using Channel3.Character.State;
using UnityEngine;

public class Jump : ICharacterState
{
    private string id = "JUMP";
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
