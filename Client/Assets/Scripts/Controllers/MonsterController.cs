using Google.Protobuf.Protocol;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static Define;

public class MonsterController : CreatureController
{
    Coroutine _coSkill;

    protected override void Init()
    {
        //순서 유의!
        base.Init();
    }

    protected override void UpdateIdle()
    {
        base.UpdateIdle();
    }

    public override void OnDamaged()
    {
        //Managers.Object.Remove(Id);
       // Managers.Resource.Destroy(gameObject);
    }

    public override void UseSkill(int skillId)
    {
        if (skillId == 1)
        {
            State = CreatureState.Skill;
        }
    }

}
