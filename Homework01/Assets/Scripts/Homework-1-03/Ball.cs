using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Action<Ball> ballClicked;

    public ColorType color;

    private void OnMouseDown()
    {
        ballClicked?.Invoke(this);
        Debug.Log("Ball clicked");
    }
}
