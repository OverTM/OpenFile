using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//打开外部程序用
using System.Configuration;//使用winform的配置文件app.config

namespace OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        /// <summary>
        /// 用于保存路径的变量
        /// </summary>
        string  path, path1, path2, path3, path4, path5, path6, path7, path8, path9, path10, path11, path12;

        #region 读取和保存配置文件
        private void Form1_Load()

        {
            path1 = Settings.Default.path1;
            path2 = Settings.Default.path2;
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)

        {
            Settings.Default.path1 = path1;
            Settings.Default.path2 = path2;
            Settings.Default.Save();
        }
        #endregion

        #region button事件设置（左键）
        private void button1_Click(object sender, EventArgs e)
        {
            path1=@path1.Replace(@"\","/"); //加@防止字符串中的转义字符被处理；替换字符串中的字符。
            Process.Start(path1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            path1 = @path2.Replace(@"\", "/"); 
            Process.Start(path2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            path1 = @path3.Replace(@"\", "/");
            Process.Start(path3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            path1 = @path4.Replace(@"\", "/");
            Process.Start(path4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            path1 = @path5.Replace(@"\", "/");
            Process.Start(path5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            path1 = @path6.Replace(@"\", "/");
            Process.Start(path6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            path1 = @path7.Replace(@"\", "/");
            Process.Start(path7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            path1 = @path8.Replace(@"\", "/");
            Process.Start(path8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            path1 = @path9.Replace(@"\", "/");
            Process.Start(path9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            path1 = @path10.Replace(@"\", "/");
            Process.Start(path10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            path1 = @path11.Replace(@"\", "/");
            Process.Start(path11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            path1 = @path12.Replace(@"\", "/");
            Process.Start(path12);
        }
        #endregion

        #region button绑定的contextMenuStrip事件设置（鼠标右键）
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            path1 = Selselection();
        }
        
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            path2 = Selselection();
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            path3 = Selselection();
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {
            path4 = Selselection();
        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {
            path5 = Selselection();
        }

        private void contextMenuStrip6_Opening(object sender, CancelEventArgs e)
        {
            path6 = Selselection();
        }

        private void contextMenuStrip7_Opening(object sender, CancelEventArgs e)
        {
            path7 = Selselection();
        }

        private void contextMenuStrip8_Opening(object sender, CancelEventArgs e)
        {
            path8 = Selselection();
        }

        private void contextMenuStrip9_Opening(object sender, CancelEventArgs e)
        {
            path9 = Selselection();
        }

        private void contextMenuStrip10_Opening(object sender, CancelEventArgs e)
        {
            path10 = Selselection();
        }

        private void contextMenuStrip11_Opening(object sender, CancelEventArgs e)
        {
            path11 = Selselection();
        }

        private void contextMenuStrip12_Opening(object sender, CancelEventArgs e)
        {
            path12 = Selselection();
        }
        #endregion

        #region 设置文件或文件夹路径
        private string Selselection()
        {
            //弹出消息框，并判断选择的是“是”还是“否”
            if (MessageBox.Show("是：设定文件路径\n否：设定文件夹路径", "请选择设定文件路径还是文件夹路径", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();//选择文件
                fileDialog.Multiselect = true; //该值确定是否可以选择多个文件
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有文件(*.*)|*.*";
                /*
                 * Filter 属性 赋值为一字符串 用于过滤文件类型;
                 *字符串说明如下：
                 *‘|’分割的两个，一个是注释，一个是真的Filter，显示出来的是那个注释。如果要一次显示多中类型的文件，用分号分开。
                 *如：
                 *Open1.Filter="图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
                 *则过滤的文件类型为 “|”号  右边的 *.jpg;*.gif;*.bmp 三种类型文件，在OpenDialog/SaveDialog中显示给用户看的文件类型字符串则是 ：“|”号  左边的 图片文件(*.jpg,*.gif,*.bmp)。
                 *再如：
                 *Open1.Filter="图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
                 */
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    path = file;
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();//选择文件夹
                dialog.Description = "请选择文件夹路径";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string foldPath = dialog.SelectedPath;
                    path = foldPath;
                    //MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return path;
        }
        #endregion
    }
}
