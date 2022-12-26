using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitOccupation : MonoBehaviour
{
    public bool FirstAccess;
    public bool Acess;

    GameObject Unit;

    private SpriteRenderer Tile;

    int OccupationLevel;

    float TileAlpha;
    float TileColor1;
    float TileColor2;
    float TileColor3;

   
   
    
    private void Start()
    {
        Tile = GetComponent<SpriteRenderer>();
        TileColor1 = 0f;
        TileColor2 = 0f;
        TileColor3 = 0f;

        TileAlpha = 1f;
        Acess = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Unit = collision.gameObject;
        Acess = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Acess = false;
    }


    public void TurnEnd()
    {
        Debug.Log("ео а╬╥А");

        if(Acess)
        {
            if (Unit.tag == "Player")
            {
                OccupationLevel += 1;
            }
            else if (Unit.tag == "Enemy")
            {
                OccupationLevel -= 1;
            }
        }

        switch (OccupationLevel)
        {
            case -4:
                Blue();
                TileAlpha = 1f;
                break;
            case -3:
                Blue(); 
                TileAlpha = 0.75f;
                break;
            case -2:
                Blue();
                TileAlpha = 0.5f;
                break;
            case -1:
                Blue();
                TileAlpha = 0.25f;
                break;
            case 0:
                TileColor1 = 0;
                TileColor2 = 0;
                TileColor3 = 0;
                TileAlpha = 0;
                break;
            case 1:
                Red();
                TileAlpha = 0.25f;
                break;
            case 2:
                Red();
                TileAlpha = 0.5f;
                break;
            case 3:
                Red();
                TileAlpha = 0.75f;
                break;
            case 4:
                Red();
                TileAlpha = 1f;
                break;
        }

        Tile.color = new Color(TileColor1, TileColor2, TileColor3, TileAlpha);
        
    }

    public void Red()
    {
        TileColor1 = 255f;
        TileColor2 = 0f;
        TileColor3 = 0f;
    }
    public void Blue()
    {
        TileColor1 = 0f;
        TileColor2 = 0f;
        TileColor3 = 255f;
    }

   

    private void Update()
    {
      

    }

    



    
}
