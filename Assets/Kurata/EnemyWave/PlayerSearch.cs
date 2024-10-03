using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 targetPosition = other.transform.parent.position;// other�̐e�I�u�W�F�N�g�̈ʒu�̍��W���w��
            float speed = 0.5f; // �ړ��̑��x���w��

            Transform objectTransform = this.transform.parent;//gameObject.GetComponent<Transform>(); // �Q�[���I�u�W�F�N�g��Transform�R���|�[�l���g���擾
            objectTransform.position = Vector3.Lerp(objectTransform.position, targetPosition, speed * Time.deltaTime); // �ړI�̈ʒu�Ɉړ�

            Debug.Log("�������Ă���");

            transform.parent.LookAt(other.transform.parent);
            Debug.Log(other.transform.parent); 
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("������O�ꂽ");
        }
    }
}