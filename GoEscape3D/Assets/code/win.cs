using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class win : MonoBehaviour
{
    public GameObject winer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "finish")
        {
            Debug.Log("oyun bitti");
            winer.SetActive(true);
            Time.timeScale = 0.0f;
            Invoke("newScene", 1.0f);
        }
    }

    public void newScene()
    {
        SceneManager.LoadScene("Scenes/lvl");
        Debug.Log("algýlaa");

    }
}
