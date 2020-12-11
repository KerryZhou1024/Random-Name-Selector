using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;


namespace RandomNameSelecter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }





        private void UpdateSystemValues()
        { 
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
            Mode= ds.Tables[0].Rows[0]["StringValue"].ToString();

            PPT_Mode = ds.Tables[0].Rows[1]["StringValue"].ToString();

            //取第二张表
            OleDbConnection connection2;
            connection2 = new OleDbConnection(dataSource);

            string sql2 = "SELECT * FROM Class17StudentName";

            OleDbDataAdapter adapter2;
            adapter2 = new OleDbDataAdapter(sql2, connection2);

            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);

            if (ds2 == null || ds2.Tables[0].Rows.Count == 0)
                return;

            //赋值
            StuNumber = ds2.Tables[0].Rows.Count;
            for(int i=0;i<StuNumber;i++)
            {
                IDList.Add(ds2.Tables[0].Rows[i]["StuName"]);
            }

            for (int i=0; i < StuNumber;i++)
            {
                StuWeightList.Add(ds2.Tables[0].Rows[i]["StuWeight"]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            ClearRotationData();
            ClearHistory();

            UpdateSystemValues();

            //先测试当所有人加权全部为1的时候
            for(int i=0;i<32;i++)
            {
                additionalWeight[i] = 1;
            }


        }



        //private变量区
        int[] rdata = new int[32];
        int[] additionalWeight = new int[32];
        double[] finalWeight = new double[32];
        int[] history = new int[32];
        string TemName;
        bool MutiSelectFirstTime;
        int MutiNumber;
        bool HistoryIsFirstTime;
        bool rdataNeedClean;
        int historyAll;
        //ArrayList
        ArrayList IDList = new ArrayList();
        int StuNumber;
        ArrayList StuWeightList = new ArrayList();

        string Mode;

        string version = "3.1 特别不稳定的beta版本";

        public void ClearRotationData()
        {
            for(int i=0;i<32;i++)
            {
                rdata[i] = 0;
            }

        }

        public void ClearHistory()
        {
            HistoryIsFirstTime = true;
            tbHistoryName.Text = "";

            for (int i=0;i<32;i++)
            {
                history[i] = 1;
            }
            historyAll = 0;
        }

        private void AddToHistory()
        {
            if(HistoryIsFirstTime)
            {
                tbHistoryName.Text = tbName.Text;
                HistoryIsFirstTime = false;
            }
            else
            {
                tbHistoryName.Text = tbHistoryName.Text + "," + tbName.Text;
            }
            this.tbHistoryName .Focus();//获取焦点
            this.tbHistoryName .Select(this.tbHistoryName .TextLength, 0);//光标定位到文本最后
            this.tbHistoryName .ScrollToCaret();//滚动到光标处
        }

        


        //private string ModeUpdate()
        //{
        //    if (rbtModeCommon.Checked)
        //    {
        //        return "common";
        //    }
        //    if (rbtModeWeight.Checked)
        //    {
        //        return "weight";
        //    }
        //    if (rbtModeMotation.Checked)
        //    {
        //        return "motation";
        //    }
        //    return "";
        //}

        private string NameProcesser()
        {
            switch (Mode)
            {
                case "weight":
                    return ModeWeightSelecter();

                case "motation":
                    return ModeRotationSelecter();

                case "common":
                    return ModeCommonSelecter();

                default:
                    return "我去又有bug";
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            TemName = NameProcesser();
            tbName.Font = new Font(tbName.Font.FontFamily, 72, tbName.Font.Style);
            tbName.Text = TemName;
            AddToHistory();

        }
        
        private void BtnSelectMuti_Click(object sender, EventArgs e)
        {
            int.TryParse(tbMutiNumber.Text,out int num);
            MutiNumber = num-1;
            MutiSelectFirstTime = true;

            if (MutiNumber>0&&MutiNumber<=9)
            {
                string TemNameBefore = "";
                tbName.Font = new Font(tbName.Font.FontFamily, 31, tbName.Font.Style);
                for (int i = 0; i < MutiNumber; i++)
                {
                    while (true)
                    {
                        if (MutiSelectFirstTime)
                        {
                            TemName = NameProcesser();
                            tbName.Text = TemName;
                            TemNameBefore = TemName;
                            MutiSelectFirstTime = false;
                            continue;
                        }
                        else
                        {
                            TemName = NameProcesser();
                            if (TemName == TemNameBefore)
                            {
                                continue;
                            }
                            else
                            {
                                tbName.Text = tbName.Text + "," + TemName;
                                TemNameBefore = TemName;
                                break;
                            }
                        }

                    }

                }
                AddToHistory();

            }
            else if(MutiNumber==0)
            {
                TemName = NameProcesser();
                tbName.Font = new Font(tbName.Font.FontFamily, 72, tbName.Font.Style);
                tbName.Text = TemName;
                AddToHistory();
            }
            else if(MutiNumber>9)
            {
                MessageBox.Show("一次性点名数量不能超过10个呦");

            }
            else
            {
                MessageBox.Show("你好皮呀");
            }
        }

        private string ModeCommonSelecter()
        {
            Random randome = new Random();
            int r = randome.Next(0, StuNumber);
            return id(r);
        }

        private string ModeWeightSelecter()
        {
            Random randome = new Random();
            ////string returner = "";
            double weightSum = 0.0;
            //计算每个元素的总权重



            //此处应调用数据库
            for(int i=0;i<StuNumber;i++)
            {
                additionalWeight[i] = FormSettings.WeightData[i];
            }
            for(int i=0;i<StuNumber ;i++)
            {
                finalWeight[i] = (additionalWeight[i]);
                weightSum = weightSum + finalWeight[i];
            }
            double random1 = randome.NextDouble();
            double random2 = random1 * weightSum;

            double[] PreWeightAdd = new double[33];
            PreWeightAdd[0] = 0;
            PreWeightAdd[StuNumber] = weightSum;
            for (int i = 0; i < StuNumber -1; i++)
            {
                PreWeightAdd[i+1] = 0;
                for (int j = 0; j <= i; j++)
                {
                    PreWeightAdd [i+1] = PreWeightAdd [i+1] +finalWeight[j];
                }
            }

            for(int i=0;i<StuNumber ;i++)
            {
                if(random2>=PreWeightAdd[i]&&random2<PreWeightAdd[i+1])
                {
                    return id(i);
                }
            }

            return "我去有Bug";




            /*
            double unit = 1 / weightSum;

            double whole1 = unit * weightSum;
            double random = randome.NextDouble();

            double[] WeightComparedWith1 = new double[32];
            double[] unitAdd = new double[32];

            //加权
            for (int i = 0; i < 32; i++)
            {
                WeightComparedWith1[i] = unit * finalWeight[i];
            }


            for(int i=1;i<32;i++)
            {
                unitAdd[i] = 0;
                for(int j=0;j<i;j++)
                {
                    unitAdd[i] = unitAdd[i] + WeightComparedWith1[j];
                }
            }
            //最终与单位一比较
            if(random<WeightComparedWith1[0])
            {
                return id(0);
            }
            else if(random>unitAdd[31])
            {
                return id(31);
            }
            else
            {
                for(int i=1;i<31;i++)
                {
                    if(random>unitAdd[i]&&random<unitAdd[i+1])
                    {
                        return id(i);
                        break;
                    }
                }
                
            }

            return "有bug!!!!!!!!";



            /* while (true)
            {
                int r = randome.Next(0, 32);
                int weight = randome.Next(1, (int)Math.Pow(3,wdata[r])+1);
                if(weight==1)
                {
                    wdata[r]++;
                    return id(r);
                    break;
                }
            }
            */

        }

        private string ModeRotationSelecter()
        {
            Random randome = new Random();


            //检验周期已满，并归零

            for (int i=0;i<StuNumber ;i++)
            {
                rdataNeedClean = true;
                if(rdata[i]==0)
                {
                    rdataNeedClean = false;
                    break;
                }
            }
            if(rdataNeedClean)
            {
                ClearRotationData();
            }

            while(true)
            {
                int r = randome.Next(0, StuNumber );
                if(rdata[r]==0)
                {
                    rdata[r]++;
                    return id(r);

                }
            }

        }

        private string id(int r)
        {
            history[r]++;
            historyAll++;

            return IDList[r].ToString();
            //switch (r)
            //{
            //    case 1:
            //        return "张智恒";


            //    case 2:
            //        return "刘芷瑜";


            //    case 3:
            //        return "刘章艺";

            //    case 4:
            //        return "崔楮焓";

            //    case 5:
            //        return "郭虹睿";

            //    case 6:
            //        return "江一舟";

            //    case 7:
            //        return "江依阁";

            //    case 8:
            //        return "李颜屹";

            //    case 9:
            //        return "罗添元";

            //    case 10:
            //        return "孙亦轩";

            //    case 11:
            //        return "张景颐";

            //    case 12:
            //        return "龚毅博";

            //    case 13:
            //        return "李思娴";

            //    case 14:
            //        return "李效恒";

            //    case 15:
            //        return "刘昕雨";

            //    case 16:
            //        return "王思雨";

            //    case 17:
            //        return "杨  舟";
                    
            //    case 18:
            //        return "张伊頔";

            //    case 19:
            //        return "赵霄宇";

            //    case 20:
            //        return "崔铭雁";

            //    case 21:
            //        return "周凯瑞";

            //    case 22:
            //        return "常  宽";

            //    case 23:
            //        return "纪佳彤";

            //    case 24:
            //        return "李悦蕾";

            //    case 25:
            //        return "刘雨晗";

            //    case 26:
            //        return "马子铉";

            //    case 27:
            //        return "阴德明";

            //    case 28:
            //        return "陈青阳";

            //    case 29:
            //        return "童思齐";

            //    case 30:
            //        return "王奕柠";
            //    case 31:
            //        return "姚涵清";

            //    case 0:
            //        return "周润桂";


            //    default:

            //        return "哎呀我去有bug";

            //}
        }


        private void BtnClearMotationData_Click(object sender, EventArgs e)
        {
            ClearRotationData();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version"+version +"   Programed by 周凯瑞\n\n"
                + "V1.1更新内容\n调整了切换速度,优化了软件体验\nV1.2更新内容\n新增了姓名记录功能\n\n"
                +"V2.0更新内容\n新增了加权与轮替模式\n新增了批量点名功能\n调整了点名方式与姓名记录功能\n修复了一些已知bug"
                +"\nV2.1更新内容\n新增了历史记录功能\n修复了一些已知bug"
                +"\nV2.2更新内容\n修复了一些已知“bug”" +
                 "\nV2.3&V2.4更新内容\n修复了一些已知bug\n简化了操作页面\n\n"+
                 "V3.0更新内容\n新增PPT模式，调整了加权算法");
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("普通模式：完全随机生成人名\n加权模式：随机生成人名且已经被点到的同学之后只有更小概率被点到\n"
                + "轮替模式：随机生成人名且在一个周期内，被点到的同学将不会再次被点到");
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void BtnOneTabClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            ClearHistory();
            ClearRotationData();

        }

        string PPT_Mode;

        bool IsPPTMode = false;
        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            if(PPT_Mode=="FormOpacity")
            {
                if(IsPPTMode)
                {
                    this.Height =337;
                    this.Width =428;
                    IsPPTMode = false;
                }
                else
                {
                    this.Height = 172;
                    this.Width = 428;
                    IsPPTMode = true;

                }
            }

            if(PPT_Mode=="FormMini")
            {
                //需要帮助！！
                FormBtnMini formBtnMini = new FormBtnMini();
                formBtnMini.Show();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPPTMode&& PPT_Mode == "FormOpacity")
            {
                this.Opacity = 1;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (IsPPTMode&& PPT_Mode == "FormOpacity")
            {
                this.Opacity = 0.04;
            }
        }

        private void btnWeightSetting_Click(object sender, EventArgs e)
        {
        FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();



            formSettings.ShowDialog();


            //麻烦的clear history方法如下
            //附窗口传值
            if(formSettings.clearHistory)
            {
                ClearHistory();

            }

            if(formSettings.clearRotation)
            {
                ClearRotationData();

            }

            if(formSettings.clearAll)
            {
                tbName.Text = "";
                ClearHistory();
                ClearRotationData();
            }


            
        }

        private void btnSelect_MouseEnter(object sender, EventArgs e)
        {
            //btnSelect.BackgroundImage= image 
        }
    }
}
