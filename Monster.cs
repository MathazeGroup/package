using UnityEngine;
using System.Collections;

[System.Serializable]
public class MonsterInfo
{
    [Header("怪物名字")]
    public string Name;
    [Header("怪物等级")]
    public int Level;


}
public class Monster : MonoBehaviour 
{
    public MonsterInfo[] MonsterData;
   
 
}
