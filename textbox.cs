using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class textbox : MonoBehaviour
{
    public GameObject textObject; // �ؽ�Ʈ ������Ʈ

    private bool isTextVisible = false; // �ؽ�Ʈ�� ���ü� ����

    // Collider�� �浹�� �� ȣ��Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // "Player" �±׸� ���� ��ü�� �浹�� ���
        {
            ShowText(); // �ؽ�Ʈ�� ������
        }
    }

    // Collider�� �浹�� ���� �� ȣ��Ǵ� �޼���
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // "Player" �±׸� ���� ��ü�� �浹�� ���� ���
        {
            HideText(); // �ؽ�Ʈ�� ����
        }
    }

    // �ؽ�Ʈ�� �����ִ� �޼���
    private void ShowText()
    {
        if (!isTextVisible) // �ؽ�Ʈ�� ������ �ʴ� ������ ��쿡�� ����
        {
            textObject.SetActive(true); // �ؽ�Ʈ ������Ʈ�� Ȱ��ȭ�Ͽ� ���̵��� ��
            isTextVisible = true; // �ؽ�Ʈ�� ���ü� ���θ� true�� ����
        }
    }

    // �ؽ�Ʈ�� ����� �޼���
    private void HideText()
    {
        if (isTextVisible) // �ؽ�Ʈ�� ���̴� ������ ��쿡�� ����
        {
            textObject.SetActive(false); // �ؽ�Ʈ ������Ʈ�� ��Ȱ��ȭ�Ͽ� ����
            isTextVisible = false; // �ؽ�Ʈ�� ���ü� ���θ� false�� ����
        }
    }
}
