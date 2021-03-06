using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using CoScheduling.Main;

namespace CP.FrameWork
{
    public partial class FormMain : RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();            
        }
        
        /// <summary>
        /// 主窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //向接口DLL中传递当前窗口控件
            CP.Interface.Globe.SetFrameworkControl(this,
                                                    Program.gFormSplash,
                                                    this.statusStrip1,
                                                    this.tslMain,
                                                    this.tslProgress,
                                                    this.DockPanel,
                                                    this.tslCoor);

            this.ribbonControl.SelectedPage.Name = "resourceManage";//设置主页

            //加载控件
            CP.Interface.Subsys1.MainInterface.AddFrameworkControl();      //此函数加载初始化地图等     

        }
        
        private static int op = 1;//当前控件；1-resourceManage，2-OptimalAllocation，3-taskManage，4-CoScheduling
        /// <summary>
        /// 当切换页面时加载控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {            
            //为观测资源管理页面时，加载相应控件
            if (this.ribbonControl.SelectedPage.Name == "resourceManage" && op != 1)
            {
                CP.Interface.Subsys1.MainInterface.AddFrameworkControl();//根据管理内容修改控件
                op = 1;
            }
            //加载观测资源优化配置控件
            else if (this.ribbonControl.SelectedPage.Name == "OptimalAllocation")
            {
                CP.Interface.Subsys2.MainInterface.AddFrameworkControl2();//根据管理内容修改控件
                op = 2;
            }
            //加载任务管理控件
            else if (this.ribbonControl.SelectedPage.Name == "taskManage")
            {
                CP.Interface.Subsys3.MainInterface.AddFrameworkControl3();//根据管理内容修改控件
                op = 3;
            }
            //加载任务规划与调度控件
            else if (this.ribbonControl.SelectedPage.Name == "PlanCoScheduling")
            {
                CP.Interface.Subsys4.MainInterface.AddFrameworkControl4();//根据管理内容修改控件
                op = 4;
            }
            else if (this.ribbonControl.SelectedPage.Name == "ribbonPage1")
            {
                CP.Interface.Subsys5.MainInterface.AddFrameworkControl5();//根据管理内容修改控件
                op = 5;
            }
            
        }

        #region 观测资源管理模块

        #region  无人机管理

        /// <summary>
        /// 无人机列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UAVlist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.UAVlist();

        }

      

        //按照以上格式通过CP.Interface接口在CoScheduling.Main中完成核心程序

        #endregion

        #region  卫星资源管理

      


        #endregion

        #region  地面监控资源管理




        #endregion

      

        #endregion

        #region  观测资源优化配置

        #region  历史事件分析




        #endregion

        #region  观测资源优化配置




        #endregion


        #endregion


        #region  任务管理

        #region  应急事件管理




        #endregion

        #region  任务分析




        #endregion


        #endregion

        #region  任务规划与调度
        internal static CoScheduling.Main.Map.taskDis formTaskDis;
        #region  任务规划
        /// <summary>
        /// 任务分解 即子任务生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskDisButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            //taskDisPanel.Visible = true;//打开控制面板
           // CoScheduling.Main.Map.taskDis taskdisBut = new CoScheduling.Main.Map.taskDis();
            if (formTaskDis == null) formTaskDis = new CoScheduling.Main.Map.taskDis();
            else if (formTaskDis.IsDisposed) formTaskDis = new CoScheduling.Main.Map.taskDis();         
           formTaskDis.Show(this.DockPanel,WinFormsUI.Docking.DockState.DockRight);  
            formTaskDis.IsHidden = false;
            formTaskDis.Text = "任务分解";
            

        }
        /// <summary>
        /// 冲突判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conflictButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       
        #endregion

        private void barButtonItem62_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys5.MainInterface.ShowScen11();
        }

        private void buttonPosition_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys5.MainInterface.GainScen();
        }

        private void barButtonItem70_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new CoScheduling.Main.Coverage.SatelliteCompute();
            f.Show();
            this.Visible = false;
        }

        private void barButtonManageTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys3.MainInterface.TaskManage();
        }

        private void barButtonQueryTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys3.MainInterface.TaskQuery();
        }

        private void barButtonGenerateTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys3.MainInterface.TaskGenerate();
        }

        private void barButtonTaskResMatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys3.MainInterface.TaskResMatch();
        }

        private void barButtonUAVManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.UAVManage();
        }

        private void barButtonUAVQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.UAVQuery();
        }

        private void barButtonSensor1Query_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.Sensor1Query();
        }

        private void barButtonBandQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.BandQuery();
        }

        private void barButtonSatManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.SatelliteManage();
        }

        private void barButtonSatQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.SatQuery();
        }

        private void barButtonAEROSHIPManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.AEROSHIPManage();
        }

        private void barButtonAEROSHIPQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.AEROSHIPQuery();
        }

        private void barButtonILLCARManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.ILLUSTRATEDCARManage();
        }

        private void barButtonILLCARQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.ILLUSTRATEDCARQuery();
        }

        private void barButtonSPYCAMManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.SPYCAMManage();
        }

        private void barButtonSPYCAMQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.SPYCAMQuery();
        }

        private void barButtonHUMDETManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.HUMDETManage();
        }

        private void barButtonHUMDETQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.HUMDETQuery();
        }



        private void bbiSatOrbit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CP.Interface.Subsys1.MainInterface.SatOrbit();
        }

       
        
     
    

     

        #region  动态资源规划




        #endregion

        #region  综合管理
        /// <summary>
        /// 实现panel拖动
        /// </summary>
        //Point pt;
        //private void taskDisPanel_MouseDown(object sender, MouseEventArgs e)
        //{
        //    pt = Cursor.Position;
        //}

        //private void taskDisPanel_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        int px = Cursor.Position.X - pt.X;
        //        int py = Cursor.Position.Y - pt.Y;
        //        //taskDisPanel.Location = new Point(taskDisPanel.Location.X + px, taskDisPanel.Location.Y + py);


        //        pt = Cursor.Position;
        //    }
        //}



        #endregion

        #endregion



    }
}