using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{ 
    void Update()
    {
        // Player �Ϲݰ���

        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("�Ϲݰ���");
        }

        // ��ų ����

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("�Ϲݰ���");
        }

        // �ñر�

        if (Input.GetKeyDown(KeyCode.R))
        {
            print("��ر�");
        }
    }
}
