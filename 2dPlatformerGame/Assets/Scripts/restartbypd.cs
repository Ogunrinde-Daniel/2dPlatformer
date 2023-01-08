using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbypd : MonoBehaviour
{

    public void restartLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
