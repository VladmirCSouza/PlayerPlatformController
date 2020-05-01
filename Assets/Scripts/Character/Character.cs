using UnityEngine;
using Channel3.Character.Behaviors;

namespace Channel3.Character
{
    [RequireComponent (typeof(Rigidbody2D))]
    public abstract class Character : MonoBehaviour
    {
        private new Rigidbody2D rigidbody;
        internal ICharacterBehaviour currentBehaviour;

        public virtual void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        public abstract void OnStateEnter(ICharacterBehaviour state);
        public abstract void OnStateUpdate(ICharacterBehaviour state);
        public abstract void OnStateExit(ICharacterBehaviour state);
        public abstract bool CheckForValidStateChange(ICharacterBehaviour state);
    }
}

