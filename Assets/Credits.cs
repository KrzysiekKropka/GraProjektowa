using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void EndCredits()
    {
        SceneManager.LoadScene("Menu");
    }
}
