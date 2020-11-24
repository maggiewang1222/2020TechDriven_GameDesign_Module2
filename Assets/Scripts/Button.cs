using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(_nextLevelName);
    }
}
