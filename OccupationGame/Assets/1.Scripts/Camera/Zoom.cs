using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float speed = 10.0f;
    private float temp_value;
    Camera Camera;

    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel") * speed;

        // scroll < 0 : scroll down�ϸ� ����
        if (Camera.orthographicSize <= 1.5f && scroll > 0)
        {
            temp_value = Camera.orthographicSize;
            Camera.orthographicSize = temp_value; // maximize zoom in

            // �ִ�� Zoom in ���� �� Ư�� ���� �������� ��

            // �ִ� �� �� ������ ��� �� ���� ���߷��� �ѹ� �� �ƿ� �Ǵ� ������ ����
        }

        // scroll > 0 : scroll up�ϸ� �ܾƿ�
        else if (Camera.orthographicSize >= 10f && scroll < 0)
        {
            temp_value = Camera.orthographicSize;
            Camera.orthographicSize = temp_value; // maximize zoom out
        }
        else
            Camera.orthographicSize -= scroll * 0.5f;
    }
}
