using UnityEngine;
using UnityEngine.UI;
using TEngine;
using System;
using UnityEditor.VersionControl;
using Newtonsoft.Json;
using System.IO;
using UnityEditor;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UILoginPanelWindow : UIWindow
    {
        #region 脚本工具生成的代码
        private InputField m_inputUser;
        private InputField m_inputPassWord;
        private Button m_btnLogin;
        private Button m_btnRegister;
        private Button m_btnforget;
        private Toggle m_toggleRemember;
        private Dropdown m_droUser_Group;
        protected override void ScriptGenerator()
        {
            m_inputUser = FindChildComponent<InputField>("UILoginPanelWindow/m_inputUser");
            m_inputPassWord = FindChildComponent<InputField>("UILoginPanelWindow/m_inputPassWord");
            m_btnLogin = FindChildComponent<Button>("UILoginPanelWindow/m_btnLogin");
            m_btnRegister = FindChildComponent<Button>("UILoginPanelWindow/m_btnRegister");
            m_btnforget = FindChildComponent<Button>("UILoginPanelWindow/m_btnforget");
            m_toggleRemember = FindChildComponent<Toggle>("UILoginPanelWindow/m_toggRemember");
            m_droUser_Group = FindChildComponent<Dropdown>("UILoginPanelWindow/m_droUser_Group");

            m_droUser_Group.onValueChanged.AddListener(OnUserNameAndPaw);
            m_btnLogin.onClick.AddListener(OnClickLoginBtn);
            m_btnforget.onClick.AddListener(OnClickforgetBtn);
            m_inputUser.onEndEdit.AddListener(OnGettingUser);
            m_inputPassWord.onEndEdit.AddListener(OnGettingPassWord);
          
        }
        //下拉框监听事件
        private void OnUserNameAndPaw(int index)
        {
            m_inputUser.text = arr[index].Name;
            m_inputPassWord.text = arr[index].Password;
            _userTest.Password = arr[index].Name;
            _userTest.Name = arr[index].Password;
        }

        List<ReqLoginMessage> arr = new List<ReqLoginMessage>();
        List<string> userNames = new List<string>();
        //登录信息
        ReqLoginMessage _userTest = new ReqLoginMessage();
        protected override void OnCreate()
        {
            base.OnCreate();
            //注册消息
            var message = GameModule.NetWork.SetMessage<ResLoginResultMessage>(ResLoginResult);
            _userTest.GameVersion = 1092;//游戏版本号
            _userTest.ServerId = 10012;//服务器id
            //===============================================================
            if (!File.Exists(Application.dataPath + "/Resources/UserJson.json")) return;
            string json = Resources.Load<TextAsset>("UserJson").text;
            arr = JsonConvert.DeserializeObject<List<ReqLoginMessage>>(json);
            foreach (var item in arr)
            {
                userNames.Add(item.Name);
            }
            m_droUser_Group.ClearOptions();
            m_droUser_Group.AddOptions(userNames);
            m_droUser_Group.value = arr.Count - 1;
            //if (arr.Count > 0)
            //{
            //    m_inputUser.text = arr[arr.Count - 1].Name;
            //    m_inputPassWord.text = arr[arr.Count - 1].Password;
            //}
        }
        private void OnGettingPassWord(string pwd)
        {
            _userTest.Password = pwd;
        }

        private void OnGettingUser(string name)
        {
            _userTest.Name = name;
        }
        #endregion

        #region 事件


        private void OnClickLoginBtn()
        {
            if (_userTest.Name != null && _userTest.Password != null)
            {
                //发送登录请求
                GameModule.NetWork.SendMessage(_userTest);
            }
            else
            {
                Log.Error("账号密码不能为空！");
            }
            Log.Info("账号====》" + _userTest.Name + "密码=====》" + _userTest.Password);
            
           
        }
        /// <summary>
        /// 服务器返回请求
        /// </summary>
        /// <param name="message">请求的消息</param>
        private void ResLoginResult(Message message)
        {
            var loginResult = message as ResLoginResultMessage;
            //0-成功  1-服务器未开启 2-用户名密码错 等 3-在ip黑名单中  4-在玩家黑名单中 5-版本不匹配
            switch (loginResult.IsSuccess)
            {
                case 0:
                    Log.Info("成功");
                    if (m_toggleRemember.isOn)
                    {
                        if (IsJsonHave(_userTest))
                        {
                            string json = JsonConvert.SerializeObject(arr);
                            File.WriteAllText(Application.dataPath + "/Resources/UserJson.json", json);
                            AssetDatabase.Refresh();
                        }

                    }
                    ; break;
                case 1: Log.Info("服务器未开启"); ; break;
                case 2: Log.Info("用户名密码错"); ; break;
                case 3: Log.Info("在ip黑名单中"); ; break;
                case 4: Log.Info("在玩家黑名单中"); ; break;
                case 5: Log.Info("版本不匹配"); ; break;
            }
        }
        //该账号密码是否被记住
        private bool IsJsonHave(ReqLoginMessage userTest)
        {
            foreach (var item in arr)
            {
                if (item.Name == userTest.Name)
                {
                    return false;
                }
            }
            arr.Add(userTest);
            return true;
        }

        private void OnClickforgetBtn()
        {
            Log.Error("忘就忘了吧……那咋办嘛QAQ~~~~");

        }
        #endregion

    }

}
