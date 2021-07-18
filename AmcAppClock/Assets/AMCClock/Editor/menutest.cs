using UnityEngine;
using System.Collections;
using UnityEditor;
//引入UnityEditor編輯器類

public class MenuItem_Top
{

    //製作Unity頂部選單欄
    [MenuItem("MyMenu/批量修改角色模型")]
    [MenuItem("MyMenu/批量修改角色模型/Role ")]
    static void T1Menu_child1()
    {
        Debug.Log("批量修改角色模型-Role 被執行了！");
    }

    [MenuItem("MyMenu/批量修改角色模型/NPC ")]
    static void T1Menu_child2()
    {
        Debug.Log("批量修改角色模型-NPC 被執行了！");
    }



    [MenuItem("MyMenu/批量修改場景模型")]
    [MenuItem("MyMenu/批量修改場景模型/Scene ")]
    static void T1Menu_child3()
    {
        Debug.Log("批量修改場景-Scene 被執行了！");
    }

    [MenuItem("MyMenu/批量修改場景模型/Scene_1 ")]
    static void T1Menu_child4()
    {
        Debug.Log("批量修改場景模型-Scene_1 被執行了！");
    }

    [MenuItem("Assets/美術工具/批量修改Prefab")]
    static void Batchart()
    {
        
    }

    [MenuItem("Component/美術工具/批量修改Prefab")]
    static void bbb()
    {

    }

    //[AddComponentMenu("blanttcom/com1/sub1")]
    //static void aaa()
    //{

    //}

}