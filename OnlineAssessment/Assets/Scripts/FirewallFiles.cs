using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallFiles : MonoBehaviour
{
    public bool codeClicked;
    Vector2 mousePos;
    SpriteRenderer iconSprite;
    public Transform targetPos;
    GameManager GM;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        iconSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (codeClicked)
        {
            transform.position = mousePos;
        }

        else
        {
            if (Vector2.Distance(transform.position, targetPos.position) < 0.25)
            {
                //GM.codeFound++;
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }

            else
            {
                transform.position = startPos;
                iconSprite.color = new Color(1, 1, 1, 1);
            }
        }
    }

    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        codeClicked = true;
        iconSprite.color = new Color(1, 1, 1, 0.5f);

    }

    private void OnMouseUp()
    {
        codeClicked = false;
    }
}
