using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailogBox : MonoBehaviour
{
    public Text Dtext;
    public Image image;
    public Color newColor;
    public Color TextColor;
    public Color newColor1;
    public Color TextColor1;
    public float fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NoCoins()
    {
        //Color alph = Dtext.color;
        //alph.a = 1f;
        //Dtext.color = alph;
        
        StartCoroutine("fadeText");
        return;
    }

    public void OnclickFadeOut()
    {
        //Color alph = Dtext.color;
        //alph.a = 1f;
        //Dtext.color = alph;
        StopCoroutine("fadeIn");
        StartCoroutine("fadeOut");
        return;
    }

    IEnumerator fadeText()
    {
        StartCoroutine("fadeIn");
        yield return new WaitForSeconds(3f);
        StopCoroutine("fadeIn");
        Debug.Log("fading out");
        StartCoroutine("fadeOut");

    }

    IEnumerator fadeIn()
    {
        StopCoroutine("fadeOut");
        Color alph = Dtext.color;
        Color alphImage = image.color;

        while (image.color.a > 0)
        {
            image.color = Color.Lerp(image.color, newColor, fadeTime * Time.deltaTime);
            Dtext.color = Color.Lerp(Dtext.color, TextColor, fadeTime * Time.deltaTime);
            yield return null;
        }
        //image.color = Color.Lerp(newColor, image.color, fadeTime * Time.deltaTime);
        //Dtext.color = Color.Lerp(TextColor, Dtext.color, fadeTime * Time.deltaTime);
        // yield return new WaitForSeconds(2f);

        //alph.a = 1f;
        //Dtext.color = alph;

        //alphImage.a = 1f;
        //image.color = alphImage;

        //yield return new WaitForSeconds(2f);


        //alph.a = 0f;
        //Dtext.color = alph;

        //alphImage.a = 0f;
        //image.color = alphImage;
    }

    IEnumerator fadeOut()
    {

        Color alph = Dtext.color;
        Color alphImage = image.color;

        while (image.color.a < 1)
        {
           
            image.color = Color.Lerp(image.color, newColor1, fadeTime * Time.deltaTime);
            Dtext.color = Color.Lerp(Dtext.color, TextColor1, fadeTime * Time.deltaTime);
            //image.color = Color.Lerp(newColor, image.color, fadeTime * Time.deltaTime);
            //Dtext.color = Color.Lerp(TextColor, Dtext.color, fadeTime * Time.deltaTime);
            yield return null;
        }
        
     
    }
}
