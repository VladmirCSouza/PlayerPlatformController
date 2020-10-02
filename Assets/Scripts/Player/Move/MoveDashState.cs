using Channel3.Character.State;
using UnityEngine;

namespace Assets.Scripts.Player.Move
{
    public class MoveDashState : ICharacterState
    {
        private string id = "MOVE_DASH_STATE";
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
}
