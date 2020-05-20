using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcontrol7 : MonoBehaviour
{
    public int level;
    public string levelName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(6);

            //SceneManager.LoadScene(levelName);
        }
    }
}
