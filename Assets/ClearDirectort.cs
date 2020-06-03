using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirectort : MonoBehaviour {
    // Start is called before the first frame update

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown (0)) { SceneManager.LoadScene ("GameScene"); }
    }
}