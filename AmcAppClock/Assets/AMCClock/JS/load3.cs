using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class load3 : MonoBehaviour
{

    public Slider slider;
    public GameObject panel;
    private AsyncOperation async_operation;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoadScene");
        slider.value = 0;
        async_operation.allowSceneActivation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (async_operation != null)
        {
            if (slider.value < async_operation.progress * 100 + 10)
            {
                slider.value++;
            }
            if (slider.value == 100)
            {
                async_operation.allowSceneActivation = true;
            }
        }
    }

    IEnumerator LoadScene()
    {
        async_operation = SceneManager.LoadSceneAsync("aa2");
        yield return async_operation;
    }
}