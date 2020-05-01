using Channel3.Character;
using Channel3.Character.Behaviors;
using UnityEngine;

[RequireComponent (typeof(Character))]
public class Player : Character
{
    public override void Start()
    {
        base.Start();
        currentBehaviour = new WalkBehaviour();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            currentBehaviour.Update();
        }
    }

    public override void OnStateEnter(ICharacterBehaviour state)
    {
        Debug.Log("On state ENTER");
    }

    public override void OnStateUpdate(ICharacterBehaviour state)
    {
        Debug.Log("On state UPDATE");
    }

    public override void OnStateExit(ICharacterBehaviour state)
    {
        Debug.Log("On state EXIT");
    }

    public override bool CheckForValidStateChange(ICharacterBehaviour state)
    {
        Debug.Log("On state CHECK VALID STATE CHANGE");
        return true;
    }
}
