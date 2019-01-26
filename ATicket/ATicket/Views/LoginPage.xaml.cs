using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATicket.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        ServiceReference1.Service1 service1;
        public LoginPage()
        {
            InitializeComponent();
            service1 = new ServiceReference1.Service1();
        }

        private async void Login(object sender, EventArgs e)
        {
            string UserName = username.Text.Trim();
            string PassWord = password.Text.Trim();
            int LoginResult = 0;
            bool LoginState;
            if (UserName == "" || PassWord == "")
            {
                await DisplayAlert("提示", "账号密码不能为空", "确定");
            }
            else {
                try
                {
                   //List<ServiceReference1.showstarts> aa =  service1.GetShow().ToList();
                    service1.Login(UserName, PassWord, out LoginResult, out LoginState);
                    if (LoginResult == 1)
                    {
                        //登陆成功
                        await DisplayAlert("登陆成功", "登陆成功", "确定");
                        //ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
                        //ISharedPreferencesEditor editor = prefs.Edit();
                        //editor.PutBoolean("Ck_Status", true);
                        //editor.PutString("UserName", UserName);
                        //editor.Commit();
                        //editor.Apply();
                    }
                    else
                    {
                        await DisplayAlert("错误", "账号密码错误", "确定");
                    }
                }
                catch (Exception ee)
                {
                    await DisplayAlert("错误", "与服务器连接发生错误 ：" + ee.Message, "关闭");
                }                 
            }
        }
        private async void Register(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RegisterPage()));
        }
    }
}