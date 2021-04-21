using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointOfInterest : MonoBehaviour
{
    // Start is called before the first frame update
    [TextArea]
    public string info;
    public Sprite spriteInfo;
    private Text infoTxt;
    private Image infoImage;
    private GameObject information;
    private Animator buttonAnimator;
    private bool isPressed;
    void Start()
    {
        information = transform.Find("Information").gameObject;
        infoTxt = transform.Find("Information").Find("Text").GetComponent<Text>();
        infoTxt.text = info;
        infoImage =  transform.Find("Information").Find("Image").GetComponent<Image>();
        infoImage.sprite = spriteInfo;
        buttonAnimator = transform.Find("Button").GetComponent<Animator>();
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleButton()
    {
        if (isPressed == false)
        {
            isPressed = true;
            information.SetActive(true);
        }
        else if (isPressed == true)
        {
            isPressed = false;
            information.SetActive(false);
        }
    }

    public void ScaleUpButton()
    {
        transform.Find("Button").GetComponent<RectTransform>().sizeDelta = new Vector3(0.6f, 0.6f, 0.6f);
    }

    public void ScaleDownButton()
    {
        if (isPressed == false)
            transform.Find("Button").GetComponent<RectTransform>().sizeDelta = new Vector3(0.4f, 0.4f, 0.4f);
    }
    
}
