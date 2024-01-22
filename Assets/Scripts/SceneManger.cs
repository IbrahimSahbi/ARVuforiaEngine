using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public int SceneNumber;
    public void OnButtonCLick(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
