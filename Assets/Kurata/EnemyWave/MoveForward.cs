using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;  // �ړ����x

    void Update()
    {
        // �I�u�W�F�N�g��O�Ɉړ�������iZ�������j
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
