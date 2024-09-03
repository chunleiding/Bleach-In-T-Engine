using TEngine;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace GameLogic
{
    public class OnEnterTestSceneProcedure : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("OnEnter My GameApp Procedure");
            GameModule.Scene.LoadScene("LoginScene", LoadSceneMode.Single);//框架加载场景方法，通过YooAsset加载场景
                                                                           //todo

            //展示前前场景里面的UI
            GameModule.UI.ShowUIAsync<UITest>();
        }

        protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            //todo
        }

        protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameModule.UI.CloseUI<UITest>();
            //todo
        }
    }

    public class OnEnterLoginSceneProcedure:ProcedureBase
    {

        protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnInit(procedureOwner);
        }
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

          //GameModule.UI.ShowUI<UILoginWindow>();
           GameModule.UI.ShowUI<UILoginPanelWindow>();
        }

        protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
          //  GameModule.UI.CloseUI<UILoginWindow>();
            GameModule.UI.CloseUI<UILoginPanelWindow>();
        }
    }


}