using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable,CreateAssetMenu(fileName ="New Car",menuName ="Create New Car")]
public class CarInfo : ScriptableObject
{
    public enum CarId {red,green,greenSuv }
    public CarId carId;
    public GameObject CarObject;
    public int CarPrice;
}
