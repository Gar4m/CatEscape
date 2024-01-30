using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // ������ ������ ������ ������ �ν��Ͻ��� ����� 
    [SerializeField] private GameObject arrowPrefab;
    private float delta; // ����� �ð� ���� 

    void Update()
    {
        delta += Time.deltaTime; // ���� �����Ӱ� ���� ������ ���� �ð� 
        Debug.Log(delta);
        if (delta > 3) // 3�ʺ��� ũ�ٸ� 
        {
            // ���� 
            GameObject go = Object.Instantiate(this.arrowPrefab);
            // ��ġ �缳�� 
            float randX = Random.Range(-8, 9); // -8 ~ 8

            go.transform.position
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0; // ��� �ð��� �ʱ�ȭ 
        }
    }
}