using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewFadeOutManager : MonoBehaviour
{
    private string placeToChangeName;
    private Image fadeImage;
    // Start is called before the first frame update
    void Start()
    {
        fadeImage = transform.Find("Image").GetComponent<Image>();
        fadeImage.CrossFadeAlpha (0f, 3f, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoFadeOut(string placeName)
    {
        fadeImage.CrossFadeAlpha (1f, 3f, false);
        placeToChangeName = placeName;
        StartCoroutine(SwitchToPlace());
    }
    IEnumerator SwitchToPlace()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(placeToChangeName);
    }    
}
