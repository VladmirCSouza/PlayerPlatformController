using System;
using Channel3.Character.State;
using UnityEngine;

public class WalkState : ICharacterState
{
    private string id = "WALK_STATE";
    public string Id { get => id; }

    public float Axis { get; private set; }
    public WalkState(float axis)
    {
        Axis = axis;
    }
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
