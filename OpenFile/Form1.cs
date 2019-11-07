using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region button事件设置（左键）
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("left");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region button绑定的contextMenuStrip事件设置（鼠标右键）
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("right");
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            string a = Selselection("");
            MessageBox.Show(a);
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip6_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip7_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip8_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip9_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip10_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip11_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip12_Opening(object sender, CancelEventArgs e)
        {

        }
        #endregion

        #region 设置文件或文件夹路径
        private string Selselection(string path)
        {
            //弹出消息框，并判断选择的是“是”还是“否”
            if (MessageBox.Show("是：设定文件路径\n否：设定文件夹路径", "请选择设定文件路径还是文件夹路径", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();//选择文件
                fileDialog.Multiselect = true; //该值确定是否可以选择多个文件
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有文件(*.txt)|*.*";
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
                dialog.Description = "请选择文件路径";
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
