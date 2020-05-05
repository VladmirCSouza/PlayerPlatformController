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
        PlayerFSM.Instance.ChangeState(new Idle());
    }

    private void Update()
    {
        PlayerFSM.Instance.StateUpdate();
    }
}
