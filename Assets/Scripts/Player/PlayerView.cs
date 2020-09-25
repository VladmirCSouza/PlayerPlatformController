using Channel3.Character.State;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerView:MonoBehaviour
    {
        [SerializeField] private PlayerBehaviour playerBehaviour;
        [SerializeField] private Animator animator;
        [SerializeField] private SpriteRenderer renderer;
        [SerializeField] private Rigidbody2D body2d;

        void Start()
        {
            playerBehaviour.OnStateChange += UpdateView;
        }

        private void UpdateView(ICharacterState state)
        {
            animator.SetFloat("AirSpeedY", body2d.velocity.y);

            switch (state)
            {
                case Idle idle:

                    animator.SetBool("Grounded", true);
                    animator.SetInteger("AnimState", 0);

                    break;
                case WalkState walk:

                    if (walk.Axis > 0)
                    {
                        renderer.flipX = false;
                    }

                    else if (walk.Axis < 0)
                    {
                        renderer.flipX = true;
                    }

                    body2d.velocity = new Vector2(walk.Axis * playerBehaviour.data.RunSpeed, body2d.velocity.y);
                    animator.SetInteger("AnimState", 1);
                    break;
                case Jump walk:

                    animator.SetBool("Grounded", false);
                    animator.SetFloat("AirSpeedY", 10f);
                    animator.SetTrigger("Jump");
                    body2d.velocity = new Vector2(body2d.velocity.x, playerBehaviour.data.FirstJumpPower);

                    break;
            }
        }
    }
}
