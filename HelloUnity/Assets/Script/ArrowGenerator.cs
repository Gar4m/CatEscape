using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // 프리팹 에셋을 가지고 프리팹 인스턴스를 만든다 
    [SerializeField] private GameObject arrowPrefab;
    private float delta; // 경과된 시간 변수 

    void Update()
    {
        delta += Time.deltaTime; // 이전 프레임과 현재 프레임 사이 시간 
        Debug.Log(delta);
        if (delta > 3) // 3초보다 크다면 
        {
            // 생성 
            GameObject go = Object.Instantiate(this.arrowPrefab);
            // 위치 재설정 
            float randX = Random.Range(-8, 9); // -8 ~ 8

            go.transform.position
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0; // 경과 시간을 초기화 
        }
    }
}