using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public  class Element : Creature
{



    public bool isSelected = false;

    


    public void SelectItem() //�������� ��������� ������� �� �����
    {
 

      
            foreach (var elem in _elements)
            {
                elem.Value.isSelected = false;

                elem.Value.transform.localScale = Vector3.one;

                Debug.Log("����������");
            }


            isSelected = true;

            transform.localScale = Vector3.one * 2;




        Debug.Log("������ ���� ������!  ������ :"+isSelected+" "+_elements.Count());
      


    }


}
