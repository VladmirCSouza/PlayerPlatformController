using UnityEngine;
using Channel3.Character.State;

namespace Channel3.Character
{
    [RequireComponent (typeof(Rigidbody2D))]
    public abstract class Character : MonoBehaviour
    {
        private new Rigidbody2D rigidbody;
        internal ICharacterState currentState;

        public virtual void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        public abstract void OnStateEnter(ICharacterState state);
        public abstract void OnStateUpdate(ICharacterState state);
        public abstract void OnStateExit(ICharacterState state);
        public abstract bool CheckForValidStateChange(ICharacterState state);
    }
}

