using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public float loding_Time = 4f; // �ε� �ð�
    [Header("Logo_Image")]
    public GameObject[] logo_Image = new GameObject[2];

    void Update()
    {
        Scene();
        scene_skip();
        Logo_ImageTiem();
        CheckAndActivate_lodingImage();
    }

    private void Logo_ImageTiem() // �ð� ó��
    {
        loding_Time -= Time.deltaTime;

    }

    private void CheckAndActivate_lodingImage() // Logo �̹��� �ε� ó��
    {
        if (loding_Time <= 3 && !logo_Image[0].activeSelf)
        {
            logo_Image[0].gameObject.SetActive(true);
        }
        if (loding_Time <= 2 && !logo_Image[1].activeSelf)
        {
            logo_Image[0].gameObject.SetActive(false);
            logo_Image[1].gameObject.SetActive(true);
        }

    }

    private void Scene() // MainScene���� �ѱ�� ó��
    {
        if (loding_Time <= 0)
        {
            SceneManager.LoadScene("MainScene");
        }
    }


    private void scene_skip() // Esc key�� �Է��� ������ start Scene�� ��ŵ �ϴ� ó��
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
