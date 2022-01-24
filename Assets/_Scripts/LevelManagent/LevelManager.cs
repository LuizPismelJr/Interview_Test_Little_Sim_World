using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [Header("canvasToLoad")]
    [SerializeField] GameObject loadCanvas;
    [Header("barToLoad")]
    [SerializeField] Image progressBar;

    float totalToFill;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        ProgressBar();
    }

    public async void LoadLevel(string sceneId)
    {
        totalToFill = 0;
        progressBar.fillAmount = 0;

        var scene = SceneManager.LoadSceneAsync(sceneId);
        scene.allowSceneActivation = false;

        loadCanvas.SetActive(true);

        await Task.Delay(1);

        for (int i = 0; i < scene.progress; i++)
        {
            totalToFill = scene.progress;
        }

        //do { totalToFill = scene.progress; } while (scene.progress < 0.9);

        scene.allowSceneActivation = true;
        loadCanvas.SetActive(false);
    }

    void ProgressBar()
    {
        progressBar.fillAmount = Mathf.MoveTowards(progressBar.fillAmount, totalToFill, 3 * Time.deltaTime);
    }
}
