using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAround : MonoBehaviour
{
    private UnitOccupation Occupation;
    private EdgeCollider2D Edge;

    void Start()
    {
        
        Occupation = FindObjectOfType<UnitOccupation>();
        Edge = GetComponent<EdgeCollider2D>();

        StartCoroutine(CheckTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "OccupationTile")
        {
            Debug.Log("Auto");
            Occupation.OccupationAround();
         
        }
    }

    IEnumerator CheckTile()
    {
        while (true)
        {
            OnTriggerStay2D(Edge);
            if (GetComponentInParent<SpriteRenderer>().tag == "Occupation")
            {
                Debug.Log("Á¡·ÉµÊ");
                yield break;
            }
            yield return null;
        }


    }

}
