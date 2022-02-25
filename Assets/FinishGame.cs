using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        print("Congrats! You have won the game!");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
