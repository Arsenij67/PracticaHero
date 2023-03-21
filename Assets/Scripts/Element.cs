using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public  class Element : Creature
{


    protected virtual bool isSelected { get; set; } = false;

    


    public void SelectItem() //�������� ��������� ������� �� �����
    {

       
        if (_elements.Any((elem) => {  return elem.isSelected == true; }) == true) // ����  ������ ����������� ��������, ����� �������� ���,������� �����
        {

            foreach (var elem in _elements)
            {
                elem.isSelected = false;
            }


            isSelected = true;

        }
 

      

        Debug.Log("������ ���� ������!");
      


    }


}
