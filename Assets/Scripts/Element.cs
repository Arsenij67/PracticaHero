using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public  class Element : Creature
{


    protected virtual bool isSelected { get; set; } = false;

    


    public void SelectItem() //�������� ��������� ������� �� �����
    {

        isSelected = true;

        Debug.Log("������ ���� ������!");


    }


}
