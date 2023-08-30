using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public Texture2D myTexture;
    public InputField inputField;
    public GameObject image;
    public static MeshRenderer sr;
    public string url;
    // Start is called before the first frame update
    void Start()
    {
       sr = image.GetComponent<MeshRenderer>();      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnChangeButtonClick()
    {
        url = inputField.text;
        StartCoroutine(Test.GetImage(url));
    }

}
