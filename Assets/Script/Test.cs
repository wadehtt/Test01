using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public static Texture myTexture;
    public static string url;
    public static int value;

    public static IEnumerator GetImage(string url)
    {
        WWW GetImage = new WWW(url);
        yield return GetImage;
        myTexture = GetImage.texture;
        if (myTexture == null)
        {
            value = 1;
            print("网址无效！错误码：" + value);
        }
        else
        {
            value = 0;
            change.sr.materials[0].SetTexture("_MainTex", myTexture);
            print("更换图片成功！");
        }  
    }

}
