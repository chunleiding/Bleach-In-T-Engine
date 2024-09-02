using UnityEngine;
using UnityEngine.UI;
using TEngine;
using System.IO;
using System;
using static UnityEditorInternal.VersionControl.ListControl;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UILoginWindow : UIWindow
    {
        #region 脚本工具生成的代码
        private Button m_btnLogin;
        private Button m_btnRegister;
        private InputField m_inputAdmin;
        private InputField m_inputPassword;
        private Button m_btnSelectServer;
        private GameObject m_go_Items;
        private GameObject m_goServerList;
        private Button m_btnCloseServerPanelBtn;

        public Action<ResServerInfoMessage> onServerInfo;


        protected override void ScriptGenerator()
        {
            m_btnLogin = FindChildComponent<Button>("m_btnLogin");
            m_btnRegister = FindChildComponent<Button>("m_btnRegister");
            m_inputAdmin = FindChildComponent<InputField>("m_inputAdmin");
            m_inputPassword = FindChildComponent<InputField>("m_inputPassword");
            m_btnSelectServer = FindChildComponent<Button>("m_btnSelectServer");
            m_go_Items = FindChild("m_go_Items").gameObject;
            m_goServerList = FindChild("m_go_Items/m_goServerList").gameObject;
            m_btnCloseServerPanelBtn = FindChildComponent<Button>("m_go_Items/m_btnCloseServerPanelBtn");
            m_btnLogin.onClick.AddListener(OnClickLoginBtn);
            m_btnRegister.onClick.AddListener(OnClickRegisterBtn);
            m_btnSelectServer.onClick.AddListener(OnClickSelectServerBtn);
            m_btnCloseServerPanelBtn.onClick.AddListener(OnClickCloseServerPanelBtnBtn);
            m_inputAdmin.onEndEdit.AddListener(OnGettingLoginAdmin);
            m_inputPassword.onEndEdit.AddListener(OnGettingLoginPassword);
        }
        #endregion

        protected override void OnCreate()
        {
            base.OnCreate();
            //注册要发送的网络消息;
            var message = GameModule.NetWork.SetMessage<ResLoginResultMessage>(ResLoginResult);
        }

        #region 事件
        void OnGetServerInfo(Message message)
        {
            var mesg = message as ResServerInfoMessage;
            if (mesg != null)
            {
                Log.Info("服务器开服时间" + mesg.ServerOpenTime);
            }
        }

        void ResLoginResult(Message msg)
        {
            var loginResult = msg as ResLoginResultMessage;
            Log.Info("是否成功" + loginResult.IsSuccess);
        }


        ReqLoginMessage message = new ReqLoginMessage();

        private void OnClickLoginBtn()
        {

            message.ServerId = 10012;
            message.GameVersion = 1092;
            message.PhoneInfo = "\"uniqueIdentifier\":\"63b4796204288b3fe99b810588ea94e1c760c57c\",\"deviceModel\":\"System Product Name (ASUS)\",\"operatingSystem\":\"Windows 10  (10.0.0) 64bit\",\"systemMemorySize\":15662";
            message.MsgCount = -1;

            if (message.Name == null || message.Name == null)
            {
                Log.Error("请输入用户名称和姓名");
            }
            else
            {
                GameModule.NetWork.SendMessage(message);
            }
        }
        private void OnClickRegisterBtn()
        {

        }
        private void OnClickSelectServerBtn()
        {

        }
        void OnDestory()
        {
            GameModule.NetWork.StopNetWork();
        }
        private void OnClickCloseServerPanelBtnBtn()
        {

        }

        private void OnGettingLoginAdmin(string words)
        {
            message.Name = words;
        }
        private void OnGettingLoginPassword(string words)
        {
            message.Password = words;
        }

        #endregion

    }
}
