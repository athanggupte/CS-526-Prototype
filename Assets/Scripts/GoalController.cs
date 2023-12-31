using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal Triggered");

        if (collision.CompareTag("Player"))
        {
            UIController.currentMenu = UIController.MenuScreen.LevelEnd;
            SceneManager.LoadScene(0);
        }
    }
}
