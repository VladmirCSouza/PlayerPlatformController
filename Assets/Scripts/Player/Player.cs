using Channel3.Character;
using UnityEngine;

[RequireComponent (typeof(Character))]
public class Player : Character
{
    public override void Start()
    {
        base.Start();
        moveBehaviour = new MoveBehaviour();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Move();
        }
    }
}
