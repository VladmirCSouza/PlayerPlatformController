using UnityEngine;
using Channel3.Character.Behaviors;

namespace Channel3.Character
{
    [RequireComponent (typeof(Rigidbody2D))]
    public class Character : MonoBehaviour
    {
        private Rigidbody2D rigidbody;

        internal IMoveBehaviour moveBehaviour { get; set; }
        internal IJumpBehaviour jumpBehaviour { get; set; }
        internal ICrouchBehaviour crouchBehaviour { get; set; }

        public virtual void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Move()
        {
            moveBehaviour.Move(rigidbody);
        }

        public void Jump()
        {
            jumpBehaviour.Jump();
        }

        public void Crouch()
        {
            crouchBehaviour.Crouch();
        }
    }
}

