using Assets.Scripts.Player.Sensor;
using Channel3.Character;
using Channel3.Character.State;
using Channel3.ScriptableObjects;
using UnityEngine;

[RequireComponent (typeof(Character))]
public class PlayerBehaviour : Character
{    
    public delegate void OnPlayerStateChange(ICharacterState newPlayerState);
    public event OnPlayerStateChange OnStateChange;

    [SerializeField] public CharacterData data;
    [SerializeField] private PlayerSensor groundSensor;
    [SerializeField] private bool onGround = false;
    
    private void Update()
    {
        if (OnStateChange == null) return;

        if (Input.GetAxis("Horizontal") == 0 || (groundSensor.State()))
        {
            onGround = true;
            PlayerFSM.Instance.ChangeState(new Idle());
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            PlayerFSM.Instance.ChangeState(new WalkState(Input.GetAxis("Horizontal")));
        }

        if (Input.GetAxis("Vertical") > 0 && onGround)
        {
            onGround = false;
            groundSensor.Disable(0.2f);
            PlayerFSM.Instance.ChangeState(new Jump());
        }

        if (PlayerFSM.Instance.ValidUpdate)
        {
            OnStateChange.Invoke(PlayerFSM.Instance.CurrentState);
            PlayerFSM.Instance.Reset();
        }
    }
}
