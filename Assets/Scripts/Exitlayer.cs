using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitlayer : MonoBehaviour
{
    public DailogBox dailogBox;
    public GameObject TextBox;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    

    public void DisableTrigger()
    {
        GetComponent<Collider2D>().isTrigger = false;
        GetComponent<Exitlayer>().enabled = false;
        TextBox.SetActive(false);


    }
  
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "player")
        {
            TextBox.SetActive(true);
            dailogBox.NoCoins();
        }
        return;
    }
}
