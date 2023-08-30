using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    // ÍÓÇÓíÉ ÇáÏæÑÇä Íæá ÇáãÍæÑ ÇáÑÃÓí (y)
    public float sensitivity = 1.0f;

    void Update()
    {
        // ÇÍÕá Úáì ÇáÅÏÎÇá ãä ÇáãÍæÑ ÇáÃİŞí ááÊÍßã ÇááÇÚÈ
        float input = SimpleInput.GetAxis("Horizontal");

        // ÍÓÈ ÇáÅÏÎÇá æÇáÍÓÇÓíÉ ÇáãØáæÈÉ¡ Şã ÈÍÓÇÈ ßãíÉ ÇáÏæÑÇä
        float rotationAmount = input * sensitivity;

        // ÏæÑ ÇáÚÌáÊíä Íæá ãÍæÑ y ÇáãÍáí
        transform.Rotate(0, rotationAmount, 0);
    }
}
