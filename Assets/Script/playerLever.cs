using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerLever : MonoBehaviour
{
    public float playerLever_count = 1;
    public Text playerLever_text;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            playerLever_count += 1;

            if (playerLever_count >= 60)
            {
                print("�����մϴ�. �ִ� 60������ �޼� �ϼŽ��ϴ�.");

               if (playerLever_count > 60)
                {
                    print("�� �̻��� ������ �ø��� �����ϴ�.");

                    playerLever_count = 60;
                }
            }
        }
        playerLever_text.text = "Lever " + playerLever_count;
    }
}
