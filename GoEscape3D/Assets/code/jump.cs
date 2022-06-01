using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    public Rigidbody player;
    float hiz = 0.8f;
    public GameObject img;
    void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && collision.gameObject.tag == "step")
        {
            player.AddForce(new Vector3(0, hiz, 0), ForceMode.Impulse);
        }
    }
}
