using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{

    public Texture2D myTexture;
    public InputField inputField;
    public Image image;
    public string url;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Sprite sprite = Sprite.Create(myTexture, new Rect(0, 0, myTexture.width, myTexture.height), new Vector2(0, 0));
        image.sprite = sprite;


    }
}
