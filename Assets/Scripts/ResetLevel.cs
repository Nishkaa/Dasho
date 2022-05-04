using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(RestartLevel());
        }*/

    }
    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level01");
        //After we have waited 1 seconds print the time again.
    }
}
