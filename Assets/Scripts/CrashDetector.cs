using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You bumped your head.");
    }
}
