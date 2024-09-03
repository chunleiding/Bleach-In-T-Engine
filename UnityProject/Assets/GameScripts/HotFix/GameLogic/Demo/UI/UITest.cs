using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TEngine;
using System;
using static UnityEditor.FilePathAttribute;
using System.Threading;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UITest : UIWindow
    {
        public static int a = 1;
        #region 脚本工具生成的代码
        private Image m_imgHead;
        private Button m_btnTestButton;
        protected override void ScriptGenerator()
        {
            m_imgHead = FindChildComponent<Image>("m_imgHead");
            m_btnTestButton = FindChildComponent<Button>("m_btnTestButton");
            m_btnTestButton.onClick.AddListener(UniTask.UnityAction(OnClickTestButtonBtn));
        }
        #endregion

        #region 事件
        private async UniTaskVoid OnClickTestButtonBtn()
        {
            //展示前前场景里面的UI
            // GameModule.UI.CloseUI<UITest>();
            // SaySomeThings();
            //根据配置表获取;
<<<<<<< HEAD
            GameModule.NetWork.StartNetWork("127.0.0.1", 7718);
            GameModule.Procedure.RestartProcedure(new OnEnterLoginSceneProcedure());

            //int a = 1;
            //int c=GameModule.Timer.AddTimer((x) =>
            //{
            //    a++;
            //    if (a == 10)
            //    {
            //    }
            //    Log.Info($"事件{a}");
            //},4,false);
            //await UniTask.Yield();
=======
            GameModule.NetWork.StartNetWork("10.161.16.110", 7718);
            GameModule.Procedure.RestartProcedure(new OnEnterLoginSceneProcedure());

            int a = 1;
            int c=GameModule.Timer.AddTimer((x) =>
            {
                a++;
                if (a == 10)
                {
                }
                Log.Info($"事件{a}");
            },4,false);
            await UniTask.Yield();
>>>>>>> 48404c380af1e28512fcf9aac0dd3a7e38b16c8d
        }
        #endregion

        void LoadAsset()
        {
            ////同步加载。
            //GameModule.Resource.LoadAsset<SkillDisplayData>(location);

            ////异步加载。
            //GameModule.Resource.LoadAssetAsync<SkillDisplayData>(location, OnLoadSuccess);
            //private void OnLoadSuccess(AssetOperationHandle assetOperationHandle) { }

            ////使用UniTask异步加载。
            //await GameModule.Resource.LoadAssetAsync<SkillDisplayData>(location, CancellationToken.None);
        }


        void TestEvent1()
        {
            Log.Info($"这是一个通过String 类型做消息号的事件");
        }

        void TestEvent2(int a)
        {
            Log.Info($"{a}这是一个通过Int 类型做消息号的事件");
        }

        private void SaySomeThings()
        {
            //发送事件流
            GameEvent.Send("TEngine很好用");
            GameEvent.Send(a, 1444);
        }

        protected override void RegisterEvent()
        {
            base.RegisterEvent();

            //字符串转换为int 类型的变量;
            a = RuntimeId.ToRuntimeId("第一个");


            //添加事件监听string
            GameEvent.AddEventListener("TEngine很好用", TestEvent1);
            //添加事件监听int 事件ID
            GameEvent.AddEventListener<int>(a, TestEvent2);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}
