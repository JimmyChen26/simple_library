using System;
using System.Windows.Forms;

namespace 圖書管理程式
{
    public partial class frmBooks : Form
    {
        // 書籍資料
        string[] b_name = { "三國演義", "西遊記", "唐詩三百首", "楚辭",
                            "西廂記", "水滸傳", "紅樓夢", "牡丹亭" };

        string[] author = { "羅貫中", "吳承恩", "孫洙", "劉向",
                            "王實甫", "施耐庵", "曹雪芹", "湯顯祖" };

        string[] kind = { "章回小說", "章回小說", "詩選", "詩歌",
                          "戲曲", "章回小說", "章回小說", "戲曲" };

        public frmBooks()
        {
            InitializeComponent();

            // 連接事件
            this.Load += frmBooks_Load;
            this.KeyPreview = true;
            this.KeyDown += frmBooks_KeyDown;

            cmbView.SelectedIndexChanged += cmbView_SelectedIndexChanged;
            lvwBooks.ItemActivate += lvwBooks_ItemActivate;
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            // 設定表單標題
            this.Text = "圖書管理程式";

            // 設定 ListView 基本屬性
            lvwBooks.View = View.LargeIcon;
            lvwBooks.Activation = ItemActivation.TwoClick;
            lvwBooks.FullRowSelect = true;
            lvwBooks.GridLines = true;

            // 加入檢視方式選項
            cmbView.Items.Clear();
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");

            // 建立欄位
            lvwBooks.Columns.Clear();
            lvwBooks.Columns.Add("書名", 100);
            lvwBooks.Columns.Add("作者", 80);
            lvwBooks.Columns.Add("類別", 80);

            // 加入書籍資料
            lvwBooks.Items.Clear();
            lvwBooks.BeginUpdate();

            for (int i = 0; i < b_name.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(b_name[i]);

                lvi.SubItems.Add(author[i]);
                lvi.SubItems.Add(kind[i]);

                // 如果有設定 ImageList，才指定圖片索引
                if ((lvwBooks.LargeImageList != null && i < lvwBooks.LargeImageList.Images.Count) ||
                    (lvwBooks.SmallImageList != null && i < lvwBooks.SmallImageList.Images.Count))
                {
                    lvi.ImageIndex = i;
                }

                lvwBooks.Items.Add(lvi);
            }

            lvwBooks.EndUpdate();

            // 預設選擇大圖示
            cmbView.SelectedIndex = 0;

            // 顯示使用說明
            ShowUsage();
        }

        private void ShowUsage()
        {
            MessageBox.Show(
                "使用說明：\n\n" +
                "1. 左邊區域會顯示所有書籍。\n\n" +
                "2. 右上方的「檢視方式」可以切換顯示模式：\n" +
                "   大圖示、詳細資料、小圖示、清單、大圖示加詳細資料。\n\n" +
                "3. 想借書時，請在左邊書籍上按兩下。\n\n" +
                "4. 系統會詢問是否確定借閱。\n\n" +
                "5. 按下「是」後，書名會加入右邊的借書清單。\n\n" +
                "6. 同一本書不能重複借閱。\n\n" +
                "7. 之後如果想再次查看使用說明，可以按鍵盤 F1。",
                "使用說明",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void frmBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowUsage();
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbView.SelectedIndex)
            {
                case 0: // 大圖示
                    lvwBooks.View = View.LargeIcon;
                    break;

                case 1: // 詳細資料
                    lvwBooks.View = View.Details;
                    break;

                case 2: // 小圖示
                    lvwBooks.View = View.SmallIcon;
                    break;

                case 3: // 清單
                    lvwBooks.View = View.List;
                    break;

                case 4: // 大圖示加詳細資料
                    lvwBooks.View = View.Tile;
                    break;
            }
        }

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count == 0)
                return;

            // 取得目前選到的書名
            string strBookname = lvwBooks.SelectedItems[0].Text;

            // 檢查是否已經借過
            bool exist = lstBorrow.Items.Contains(strBookname);

            if (exist == false)
            {
                DialogResult dr = MessageBox.Show(
                    "確定要借閱嗎?",
                    strBookname,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    lstBorrow.Items.Add(strBookname);
                }
            }
            else
            {
                MessageBox.Show(
                    "這本書已經在借書清單中。",
                    "提醒",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void lvwBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 這個事件目前不用寫程式
        }
    }
}