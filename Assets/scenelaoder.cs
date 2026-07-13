using UnityEngine;
using UnityEngine.SceneManagement;
public class scenelaoder : MonoBehaviour
{
    private object sceneManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("circle", LoadSceneMode.Additive);
        SceneManager.LoadScene("Character", LoadSceneMode.Additive);
        SceneManager.LoadScene("UII", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
