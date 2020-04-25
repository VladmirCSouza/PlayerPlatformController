using System.Collections;
using System.Collections.Generic;
using Channel3.Character.Behaviors;
using UnityEngine;

public class MoveBehaviour : IMoveBehaviour
{
    public void Move(Rigidbody2D rigidbody)
    {
        Debug.Log("Move this shit");
    }
}
