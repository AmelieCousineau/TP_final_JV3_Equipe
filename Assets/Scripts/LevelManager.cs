using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField] private GameObject loaderCanvas;
    [SerializeField] private Image progressBar;

    private void Awake()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }

    public void LoadNewGame(){
        Debug.Log("test1");
        SceneManager.LoadScene("Level01");
    }

    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
        Debug.Log("Quitter");
        Application.Quit();
    }

    public async void LoadAsyncScene(string SceneName){
        var scene = SceneManager.LoadSceneAsync(SceneName);

        scene.allowSceneActivation = false;

        loaderCanvas.SetActive(true);

        do{
            await Task.Delay(100);
            progressBar.fillAmount = scene.progress;
        }while(scene.progress < 0.9f);

        scene.allowSceneActivation = true;

        loaderCanvas.SetActive(false);
    }
}
