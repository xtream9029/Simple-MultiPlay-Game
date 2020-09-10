﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Game;
        Managers.Map.LoadMap(1);

        Screen.SetResolution(640, 480, false);

        /*GameObject player = Managers.Resource.Instantiate("Creature/Player");
        //PlayerController pc = player.GetComponent<PlayerController>();
        player.name = "Player";
        Managers.Object.Add(player);

        for(int i = 0; i < 20; i++)
        {
            GameObject monster = Managers.Resource.Instantiate("Creature/Monster");
            monster.name = $"Monster_{i+1}";


            //랜덤 위치 스폰 (일단 겹쳐도 OK)
            Vector3Int pos = new Vector3Int()
            {
                x = Random.Range(-20, 20),
                y = Random.Range(-10, 10),
            };

            //좌표를 추출하기 위해서
            MonsterController mc = monster.GetComponent<MonsterController>();
            mc.CellPos = pos;

            Managers.Object.Add(monster);
        }*/

        //Managers.UI.ShowSceneUI<UI_Inven>();
        //Dictionary<int, Data.Stat> dict = Managers.Data.StatDict;
        //gameObject.GetOrAddComponent<CursorController>();

        //GameObject player = Managers.Game.Spawn(Define.WorldObject.Player, "UnityChan");
        //Camera.main.gameObject.GetOrAddComponent<CameraController>().SetPlayer(player);

        ////Managers.Game.Spawn(Define.WorldObject.Monster, "Knight");
        //GameObject go = new GameObject { name = "SpawningPool" };
        //SpawningPool pool = go.GetOrAddComponent<SpawningPool>();
        //pool.SetKeepMonsterCount(2);
    }

    public override void Clear()
    {
        
    }
}
