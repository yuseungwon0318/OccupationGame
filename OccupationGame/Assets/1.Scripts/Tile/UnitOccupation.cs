using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitOccupation : MonoBehaviour
{
    public bool FirstAccess;
    private SpriteRenderer Tile;
   

    private EdgeCollider2D Edge;
    private PolygonCollider2D Polygon;


    private float TileGap;
    private LayerMask LayerMask;

    private void Start()
    {
        Edge = GetComponent<EdgeCollider2D>();
        Polygon = GetComponent<PolygonCollider2D>();

        
    }

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
    }
        

        
        
    
  
    public void TurnEnd()
    {
        Debug.Log("ео а╬╥А");
        float TileA = gameObject.GetComponent<SpriteRenderer>().color.a;
        TileA += 0.25f;
    }

   

    private void Update()
    {
      

    }

    public void OccupationAround()
    {
        Tile.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 1f);

        this.tag = "Occupation";
    }



    
}
