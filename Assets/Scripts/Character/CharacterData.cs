using UnityEngine;

namespace Channel3.ScriptableObjects 
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Channel 3/ScriptableObjects/Character Data", order = 1)]
    public class CharacterData : ScriptableObject
    {
        [Header("HEALTH")]
        [Range(0, 100)]
        [SerializeField] private int health = 100;
        public int Health => health;

        [Header("MOVEMENT")]
        [SerializeField] private float walkSpeed = 50.0f;
        public float WalkSpeed => walkSpeed;
        [SerializeField] private float runSpeed = 150.0f;
        public float RunSpeed => runSpeed;
        [SerializeField] private float crouchSpeed = 25.0f;
        public float CrouchSpeed => crouchSpeed;

        [Header("JUMP")]
        [SerializeField] private float firstJumpPower = 50.0f;
        public float FirstJumpPower => firstJumpPower;
        [SerializeField] private float secondJumpPower = 25.0f;
        public float SecondJumpPower => secondJumpPower;
        [SerializeField] private float wallJumpPower = 20.0f;
        public float WallJumpPower => wallJumpPower;
        [SerializeField] private bool canDoubleJump = true;
        public bool CanDoubleJump { get => canDoubleJump; set => canDoubleJump = value; }
        [SerializeField] private bool canDoWallJump = true;
        public bool CanDoWallJump { get => canDoWallJump; set => canDoWallJump = value; }


    }
}

