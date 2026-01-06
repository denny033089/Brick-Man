using UnityEngine;

/// <summary>
/// 스테이지의 기본 데이터(이름, 인덱스, 게임 규칙, 배치 정보 등) 보관
/// </summary>
[CreateAssetMenu(fileName = "New Stage Data", menuName = "BrickMan/Stage Data")]
public class StageData : ScriptableObject
{
    // 정의 필요

    [Header("기본 정보")]
    public string stageName;   // 예: "Tutorial Level"
    public int stageIndex;     // 예: 1
}