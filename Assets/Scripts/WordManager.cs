using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{

    public string wordState = "word";

    private float timeOut = 0f;

    public bool beenTyped;
    public GameObject word;

    public Sprite START;
    public Sprite TART;
    public Sprite ART;
    public Sprite RT;
    public Sprite T;
    public Sprite END;

    private SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = START;
    }

    // Update is called once per frame
    void Update()
    {
        if (wordState == "start")
        {
            spriteRenderer.sprite = START;
        }

        if (wordState == "tart")
        {
            spriteRenderer.sprite = TART;
        }

        if (wordState == "art")
        {
            spriteRenderer.sprite = ART;
        }

        if (wordState == "rt")
        {
            spriteRenderer.sprite = RT;
        }

        if (wordState == "t")
        {
            spriteRenderer.sprite = T;
        }

        if (wordState == "end")
        {
            if (timeOut >= 0)
            {
                spriteRenderer.sprite = END;
                timeOut -= Time.deltaTime; // shorthand for: timeOut = timeOut - Time.deltaTime
            }
            else
            {
                timeOut = 5f;
                Destroy(gameObject);
                SceneManager.LoadScene("Game_Screen");
            }

        }



        if (Input.GetKeyDown(KeyCode.S) && wordState == "word")
        {
            wordState = "tart";
        }

        //(GameObject.activeInHierarchy === true)
        //or 
        // if (GameObject.FindWithTag("s") != null && wordState == "word")
       // {
       //     wordState = "tart";
        //}
        else if (Input.GetKeyDown(KeyCode.T) && wordState == "tart")
        {
            wordState = "art";
            }
        else if (Input.GetKeyDown(KeyCode.A) && wordState == "art")
        {
            wordState = "rt";
        }
        else if (Input.GetKeyDown(KeyCode.R) && wordState == "rt")
        {
            wordState = "t";
        }
        else if (Input.GetKeyDown(KeyCode.T) && wordState == "t")
        {
            wordState = "end";
        }

    }


}
