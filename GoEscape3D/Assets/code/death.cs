using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOver;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "death")
        {
            player.SetActive(false);
            gameOver.SetActive(true);
        }
    }

    public void tekrar()
    {
        SceneManager.LoadScene("Scenes/elma");
        Time.timeScale = 1.0f;
    }
}
