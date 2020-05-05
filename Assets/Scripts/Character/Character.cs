using UnityEngine;
using Channel3.Character.State;

namespace Channel3.Character
{
    [RequireComponent (typeof(Rigidbody2D))]
    public abstract class Character : MonoBehaviour
    {
        private new Rigidbody2D rigidbody;

        public virtual void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
    }
}

