using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainWinScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Magic Coconut Game");
    }
}
