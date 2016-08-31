﻿//------------------------------------------------------------------------------
// 创建标识: 尹健
// 创建描述: 无人机监测方案数据访问类
// 创建时间:2013.11.11
// 文件版本:1.0
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using CoScheduling.Core.DBUtility;

namespace CoScheduling.Core.DAL
{
	/// <summary>
	/// 数据访问类 UAVPlan
	/// </summary>
	public class UAVPlan 
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.UAVPlan model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO UAVPlan(");
            strSql.Append("CID,CompName,PID,ExpTime,GeneTime,isSelected)");
			strSql.Append(" VALUES (");
            strSql.Append("@in_CID,@in_CompName,@in_PID,@in_ExpTime,@in_GeneTime,@in_isSelected)");
            SqlParameter[] cmdParms = new SqlParameter[]{
                new SqlParameter("@in_CID", SqlDbType.Int),
				new SqlParameter("@in_CompName", SqlDbType.NVarChar),
				new SqlParameter("@in_PID", SqlDbType.Int),
				new SqlParameter("@in_ExpTime", SqlDbType.Decimal),
				new SqlParameter("@in_GeneTime", SqlDbType.DateTime),
				new SqlParameter("@in_isSelected", SqlDbType.Int)};

            cmdParms[0].Value = model.CID;
            cmdParms[1].Value = model.CompName;
            cmdParms[2].Value = model.PID;
            cmdParms[3].Value = model.ExpTime;
            cmdParms[4].Value = model.GeneTime;
            cmdParms[5].Value = model.isSelected;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.UAVPlan model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE UAVPlan SET ");
			strSql.Append("CID=@in_CID,");
			strSql.Append("CompName=@in_CompName,");
			strSql.Append("PID=@in_PID,");
			strSql.Append("ExpTime=@in_ExpTime,");
			strSql.Append("GeneTime=@in_GeneTime,");
			strSql.Append("isSelected=@in_isSelected");
			strSql.Append(" WHERE ID=@in_ID");
            SqlParameter[] cmdParms = new SqlParameter[]{
                new SqlParameter("@in_CID", SqlDbType.Int),
				new SqlParameter("@in_CompName", SqlDbType.NVarChar),
				new SqlParameter("@in_PID", SqlDbType.Int),
				new SqlParameter("@in_ExpTime", SqlDbType.Decimal),
				new SqlParameter("@in_GeneTime", SqlDbType.DateTime),
				new SqlParameter("@in_isSelected", SqlDbType.Int),
				new SqlParameter("@in_ID", SqlDbType.Int)};
            cmdParms[0].Value = model.CID;
            cmdParms[1].Value = model.CompName;
            cmdParms[2].Value = model.PID;
            cmdParms[3].Value = model.ExpTime;
            cmdParms[4].Value = model.GeneTime;
            cmdParms[5].Value = model.isSelected;
            cmdParms[6].Value = model.ID;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM UAVPlan ");
			strSql.Append(" WHERE ID=@in_ID");
            SqlParameter[] cmdParms = {
				new SqlParameter("@in_ID",System.Data.SqlDbType.Int, ID)};
            cmdParms[0].Value = ID;
            return DbHelperSQL.ExecuteSql(strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return DbHelperSQL.GetMaxID("UAVPlan");
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM UAVPlan");
			strSql.Append(" WHERE ID="+ID.ToString());
            return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.UAVPlan GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT * FROM UAVPlan ");
			strSql.Append(" WHERE ID="+ID);
			Model.UAVPlan model = null;
            using (SqlDataReader dr = DbHelperSQL.ExecuteReader(strSql.ToString()))
            {
                while (dr.Read())
                {
                    model = GetModel(dr);
                }
                return model;
            }
		}

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		public List<Model.UAVPlan> GetList()
		{
			StringBuilder strSql = new StringBuilder("SELECT * FROM UAVPlan");
            using (SqlDataReader dr = DbHelperSQL.ExecuteReader(strSql.ToString()))
            {
				List<Model.UAVPlan> lst = GetList(dr);
				return lst;
			}
		}

        /// <summary>
        /// 获取页数
        /// </summary>
        public int GetPageNum(int PageSize, string WhereClause)
        {
            StringBuilder strSql = new StringBuilder("SELECT count(*) FROM UAVPlan");
            if (!string.IsNullOrEmpty(WhereClause))
                strSql.Append(" where " + WhereClause);
            using (SqlDataReader dr = DbHelperSQL.ExecuteReader(strSql.ToString(), null))
            {
                if (dr.Read())
                {
                    int cnt = int.Parse(dr[0].ToString());
                    return (int)Math.Ceiling((double)(Convert.ToDouble(cnt.ToString()) / Convert.ToDouble(PageSize.ToString())));
                }
                else return 0;
            }
        }


        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public List<Model.UAVPlan> GetPageList(int pageSize, int pageIndex, string WhereClause)
        {
            string strSql = "SELECT TOP " + pageSize.ToString() + " * " +
                             "    FROM " +
                                        " ( " +
                                        " SELECT ROW_NUMBER() OVER (ORDER BY BH) AS RowNumber,* FROM UAVPlan "
                                             + (!string.IsNullOrEmpty(WhereClause) ? " where " + WhereClause : "") +
                                         ") A " +
                                 "WHERE RowNumber > " + pageSize.ToString() + "*(" + pageIndex.ToString() + "-1)  ";
            using (SqlDataReader dr = DbHelperSQL.ExecuteReader(strSql.ToString(), null))
            {
                List<Model.UAVPlan> lst = GetList(dr);
                return lst;
            }
        }

		#region -------- 私有方法，通常情况下无需修改 --------

		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Model.UAVPlan GetModel(DbDataReader dr)
		{
			Model.UAVPlan model = new Model.UAVPlan();
            model.ID = DbHelperSQL.GetInt(dr["ID"]);
            model.CID = DbHelperSQL.GetInt(dr["CID"]);
            model.CompName = DbHelperSQL.GetString(dr["CompName"]);
            model.PID = DbHelperSQL.GetInt(dr["PID"]);
            model.ExpTime = DbHelperSQL.GetDouble(dr["ExpTime"]);
            model.GeneTime = DbHelperSQL.GetDateTime(dr["GeneTime"]);
            model.isSelected = DbHelperSQL.GetInt(dr["isSelected"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Model.UAVPlan> GetList(DbDataReader dr)
		{
			List<Model.UAVPlan> lst = new List<Model.UAVPlan>();
			while (dr.Read())
			{
				lst.Add(GetModel(dr));
			}
			return lst;
		}

		#endregion
	}
}
