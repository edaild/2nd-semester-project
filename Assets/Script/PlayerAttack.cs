using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{ 
    private void Update()
    {
        HandleAttackInput();
    }


    // �Է¿� ���� �÷��̾��� ���� ó��
    private void HandleAttackInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PerformBasicAttack();
        }
    }
    private void PerformBasicAttack()
    {
        Debug.Log("�Ϲݰ���");
    }


    private void PerformSkillAttack()
    {
        Debug.Log("��ų ����");
    }

 
    private void PerformUltimateAttack()
    {
        Debug.Log("�ñر�");
    }
}
