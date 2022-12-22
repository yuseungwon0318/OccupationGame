using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitOccupation : MonoBehaviour
{
    public GameObject TilePrefab;
    public bool FirstAccess;
    private SpriteRenderer Tile;
    private PolygonCollider2D PolygonColider;

    

    private float TileGap;
    private LayerMask LayerMask;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (FirstAccess)
        {

            //GameObject Prefabtile = GameObject.Instantiate(TilePrefab);
            //Prefabtile.transform.position = this.transform.position;



            Tile = this.GetComponent<SpriteRenderer>();
            Tile.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 0.25f);



            FirstAccess = false;
        }
        else
        {
           
        }
    }
  
    public void TurnEnd()
    {
        Debug.Log("ео а╬╥А");
        float TileA = gameObject.GetComponent<SpriteRenderer>().color.a;
        TileA += 0.25f;
       
        
    }

    public void CheckTile()
    {
        RaycastHit2D leftHit = Physics2D.Raycast(PolygonColider.bounds.center, Vector2.left);
    }

    private void Update()
    {
       

    }



}
