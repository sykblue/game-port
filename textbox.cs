using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class textbox : MonoBehaviour
{
    public GameObject textObject; // 텍스트 오브젝트

    private bool isTextVisible = false; // 텍스트의 가시성 여부

    // Collider와 충돌할 때 호출되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // "Player" 태그를 가진 물체와 충돌할 경우
        {
            ShowText(); // 텍스트를 보여줌
        }
    }

    // Collider와 충돌이 끝날 때 호출되는 메서드
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // "Player" 태그를 가진 물체와 충돌이 끝날 경우
        {
            HideText(); // 텍스트를 숨김
        }
    }

    // 텍스트를 보여주는 메서드
    private void ShowText()
    {
        if (!isTextVisible) // 텍스트가 보이지 않는 상태일 경우에만 실행
        {
            textObject.SetActive(true); // 텍스트 오브젝트를 활성화하여 보이도록 함
            isTextVisible = true; // 텍스트의 가시성 여부를 true로 설정
        }
    }

    // 텍스트를 숨기는 메서드
    private void HideText()
    {
        if (isTextVisible) // 텍스트가 보이는 상태일 경우에만 실행
        {
            textObject.SetActive(false); // 텍스트 오브젝트를 비활성화하여 숨김
            isTextVisible = false; // 텍스트의 가시성 여부를 false로 설정
        }
    }
}
