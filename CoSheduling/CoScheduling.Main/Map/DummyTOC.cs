﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoScheduling.Main.Map
{
    public partial class DummyTOC : CP.WinFormsUI.Docking.DockContent
    {
        #region 自定义属性
        /// <summary>
        /// 图层控件
        /// </summary>
        public ESRI.ArcGIS.Controls.AxTOCControl AxTOCControl
        {
            get { return this.axTOCControl1; }
        }
        #endregion

        public DummyTOC()
        {
            InitializeComponent();
        }
    }
}
