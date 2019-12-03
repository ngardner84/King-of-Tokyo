using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class dontDestroyVolume : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
}
