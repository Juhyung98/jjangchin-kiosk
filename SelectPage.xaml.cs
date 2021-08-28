﻿using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace jjangchin_kiosk
{
	public partial class SelectPage : View
    {
        int a=0;
        public SelectPage(string data, int a1)
        {
            InitializeComponent();
            a = a1;
            this.orderText.Text = $"[{data}]를 주문하시겠습니까?";
        }
        public SelectPage(string data)
        {
            InitializeComponent();

            this.orderText.Text = $"[{data}]를 주문하시겠습니까?";
        }
        private void No_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            if(a==1)
                Window.Instance.Add(new EasySelectPage());
            else
                Window.Instance.Add(new KioskPage1());
        }
        private void Yes_Button_ClickEvent(object sender, Tizen.NUI.Components.Button e)
        {
            Window.Instance.Add(new CompletePage());
        }
    }
}