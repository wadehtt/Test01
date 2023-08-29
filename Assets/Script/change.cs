using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{

    public Texture myTexture;
    public InputField inputField;
    public GameObject image;
    public MeshRenderer sr;
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
        StartCoroutine(GetImage(url));
    }
    IEnumerator GetImage(string url)
    {
        WWW GetImage = new WWW(url);
        yield return GetImage;
        myTexture = GetImage.texture;
        sr.materials[0].SetTexture("_MainTex",myTexture);

    }
}
