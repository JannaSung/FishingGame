using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 釣魚遊戲
{
    public partial class 釣魚遊戲 : Form
    {
        public 釣魚遊戲()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /* 釣魚遊戲 : 4*3張卡，翻到相同圖案會得分 */

            btnReset.Enabled = false;
            txtScore.Enabled = false;

            Label lab = new Label();
            lab.Text ="Let the game begin...";
            lab.Location = new Point(32 ,80);
            lab.AutoSize = true;
            lab.Font = new Font("Ravie", 25, FontStyle.Bold);
            lab.ForeColor = Color.Red;
            panel1.Controls.Add(lab);
        }

        private void btnStart_Click(object sender, EventArgs e) // 遊戲開始
        {
            panel1.Controls.Clear();
            btnReset.Enabled = true;
            txtScore.Enabled = true;

            for (int x = 0; x < 4; x++)  // 用迴圈製作按鈕
            {
                for (int y = 0; y < 2; y++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 150);
                    btn.Location = new Point(20 + 120 * x, 20 + 180 * y);
                    panel1.Controls.Add(btn);
                }
            }
            int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

            foreach (Button control in panel1.Controls) // 註冊翻牌區的按鈕事件
            {
                control.Click += Button_Click;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            //if () // 圖片相同，按鈕不可再按
            //{


            //}
            //else  // 圖片不同，回復初始圖
            //{

            //}
        }

        private void btnReset_Click(object sender, EventArgs e) // 重新遊戲
        {
            btnStart_Click(sender, e);
        }
        private void GameResult()
        {
            //if ()
            //{
            //    win newFrom = new win();
            //    newFrom.Show();
            //}
            //else
            //{
            //    lose newFrom = new lose();
            //    newFrom.Show();

            //}
        }

    }
}
