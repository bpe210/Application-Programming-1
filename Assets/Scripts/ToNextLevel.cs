using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    public GameObject nextlevel;
    private int nextSceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out _))
        {
            nextlevel.SetActive(true);
            Time.timeScale = 0;
        }   
    }
    public void NextLevel()
    {
       if(nextSceneName < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneName);
            Time.timeScale = 1;
        }
        
    }
  
    private void Start()
    {
        nextSceneName= SceneManager.GetActiveScene().buildIndex + 1;
    }

}
