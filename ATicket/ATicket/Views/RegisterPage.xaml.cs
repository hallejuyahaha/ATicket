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
    public partial class RegisterPage : ContentPage
    {
        ServiceReference1.Service1 service1;
        public RegisterPage()
        {
            InitializeComponent();
            service1 = new ServiceReference1.Service1();
        }
        

        private async void Register_Click(object sender, EventArgs e)
        {
            int RegisterRusult = 0;
            bool RegisterRusultSpecified;
            string username = userName.Text.Trim();
            string password = passWord.Text.Trim();
            string passwordagin = passWordAgin.Text.Trim();
            string email = Email.Text.Trim();
            string phonenumber = phoneNumber.Text.Trim();
            string accountname = accountName.Text.Trim();
            if (username == "" || password == "" || passwordagin == "")
            {
                await DisplayAlert("提示", "用户名密码不能为空 ：", "确定");
            }
            else if (password != passwordagin)
            {
                await DisplayAlert("提示", "两次密码不一致 ：", "确定");
            }
            else
            {
                try
                {
                    service1.Register(username, password, email, phonenumber, "boy", accountname, out RegisterRusult, out RegisterRusultSpecified);
                    switch (RegisterRusult)
                    {
                        case 0:
                            await DisplayAlert("错误", "注册失败", "确定");
                            break;
                        case 1:
                            await DisplayAlert("错误", "与服务器连接失败", "确定");
                            break;
                        case 2:
                            await DisplayAlert("提示", "用户名已存在", "确定");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ea)
                {
                    await DisplayAlert("错误", "与服务器连接失败 ：" + ea.Message, "确定");
                }
            }
        }
    }
}