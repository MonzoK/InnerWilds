using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutscene : MonoBehaviour
{

    private void OnEnable()
    {
        SceneManager.LoadScene("Beaver section", LoadSceneMode.Single);
    }


}