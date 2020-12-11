using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace RandomNameSelecter
{
    public partial class FormSettings : Form
    {
        
        public FormSettings()
        {
            InitializeComponent();

        }


        public int i = 1;
        string Mode;
            
        public static int[] WeightData = new int[32];

        public void WeightDataUpdate()
        {
           

             }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WeightDataUpdate();
        }

        //WeightDataUpdate();




        private void PasswordCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateToDataBase();
            DataUpdate();
            WeightDataUpdate();
        }

        private void RbtModeCommon_CheckedChanged(object sender, EventArgs e)
        {
            //Form1.UpDateModeSituation();
        }

        private void PasswordCheck_Load(object sender, EventArgs e)
        {

            //下载数据库中数据值
            string dataSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseClassMember.accdb";
            //取第一张表
            OleDbConnection connection;
            connection = new OleDbConnection(dataSource);

            string sql = "SELECT * FROM SystemValues";

            OleDbDataAdapter adapter;
            adapter = new OleDbDataAdapter(sql, connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
                return;
            // 赋值  问题：Rows的代替方法
            Mode = ds.Tables[0].Rows[0]["StringValue"].ToString();
            //更新控件
            if(Mode=="common")
            {
                rbtModeCommon.Checked = true;
            }
            else if(Mode =="weight")
            {
                rbtModeWeight.Checked = true;
            }
            else if(Mode == "motation")
            {
                rbtModeMotation.Checked = true;
            }


            PPT_Mode = ds.Tables[0].Rows[1]["StringValue"].ToString();
            if(PPT_Mode =="FormOpacity")
            {
                rbtFormOpacity.Checked = true;
            }
            else if(PPT_Mode=="FormMini")
            {
                rbtFormMini.Checked = true;
            }

        }

        //
        //
        //写数据库
        private void DataUpdate()
        {

        }
        public bool clearHistory = false;

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            btnClearHistory.Text = "已清空";
            clearHistory = true;
        }

        public bool clearRotation = false;
        private void btnClearMotationData_Click(object sender, EventArgs e)
        {
            btnClearMotationData.Text = "已清空";
            clearRotation = true;
        }

        public bool clearAll = false;
        private void btnOneTabClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已清空");
            clearAll = true;
        }

        public string PPT_Mode;
        private void UpdatePPTMethod()
        {
            if (rbtFormOpacity.Checked)
                PPT_Mode = "FormOpacity";

            if (rbtFormMini.Checked)
                PPT_Mode = "FormMini";
        }
        private void rbtFormMini_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePPTMethod();
        }

        private void rbtFormOpacity_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePPTMethod();
        }

        private void rbtModeWeight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtModeMotation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateToDataBase()
        {
            if(rbtModeCommon.Checked)
            {
                Mode = "common";
            }
            else if(rbtModeMotation.Checked)
            {
                Mode = "motation";
            }
            else if(rbtModeWeight.Checked)
            {
                Mode = "weight";
            }

            //更新数据
            string sql1 = string.Format(" UPDATE SystemValues SET StringValue='{0}' WHERE Name='{1}' "
                                , Mode.ToString()
                                , "Mode".ToString());

            string sql2 = string.Format(" UPDATE SystemValues SET StringValue='{0}' WHERE Name='{1}' "
                    , PPT_Mode.ToString()
                    , "PPT_Mode".ToString());

            OleDbConnection connection = new OleDbConnection(dataSource);

            OleDbCommand command1 = new OleDbCommand(sql1, connection);
            OleDbCommand command2 = new OleDbCommand(sql2, connection);
            connection.Open();
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }
    string dataSource = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DatabaseClassMember.accdb";

    }
}
