using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class FadeOutManager : MonoBehaviour
{
    public GameObject places;
    private string placeToChangeName;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoFadeOut(string placeName)
    {
        animator.SetBool("FadeOut", true);
        placeToChangeName = placeName;
    }
    public void SwitchToPlace()
    {
        GameObject placeGO = null;
        foreach (Transform place in places.transform)
        {
            if (place.gameObject.name == placeToChangeName)
            {
                placeGO = place.gameObject;
            }
            place.GetComponent<VideoPlayer>().Stop();
            place.gameObject.SetActive(false);
        }
        // placeGO.GetComponent<VideoPlayer>().Play();
        placeGO.gameObject.SetActive(true);
        animator.SetBool("FadeOut", false);
    }    
}
