using MusicStore.Logics;
using MusicStore.Models;

namespace MusicStore
{
    public partial class MainGUI : Form
    {
        
        
        ToolStripMenuItem albumsToolStripMenuItem;
        DataGridView grv;
        public MainGUI()
        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text.StartsWith("Login"))
            {
                LoginGUI login = new LoginGUI();
                DialogResult dialog = login.ShowDialog();
            }
            else
            {
                Account.UserName = "";
                MessageBox.Show("Logged out");
                albumsToolStripMenuItem.Visible = false;
                

            }
        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            if (Account.UserName == "")
            {
                loginToolStripMenuItem.Text = "Login";
            }
            else
            {
                loginToolStripMenuItem.Text = $"Logout({Account.UserName})";
                Users user = new Users();
                if(Account.Role == 1)
                {
                    albumsToolStripMenuItem = new ToolStripMenuItem();
                    albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
                    albumsToolStripMenuItem.Size = new Size(60, 24);
                    albumsToolStripMenuItem.Text = "Albums";
                    menuStrip1.Items.AddRange(new ToolStripItem[]
                    {
                        albumsToolStripMenuItem
                    });
                    albumsToolStripMenuItem.Click += new System.EventHandler(this.albums_click);
                }
                
                   
                
            }

        }
         private void albums_click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            
            albumsload();

        }
        void albumsload()
        {

            Label lbTitle = new Label();
            lbTitle.Text = "Genre:";
            lbTitle.Location = new Point(29, 16);
            lbTitle.Size = new Size(50, 20);
            panel2.Controls.Add(lbTitle);

            ComboBox cb1 = new ComboBox();
            cb1.Location = new Point(95, 13);
            cb1.Size = new Size(151, 28);
            panel2.Controls.Add(cb1);
            cb1.DataSource = GenreManager.GetAllGenresFromDB();
            cb1.DisplayMember = "genreName";
            cb1.ValueMember = "genredId";

            Label lbTitle2 = new Label();
            lbTitle2.Text = "Tilte:";
            lbTitle2.Location = new Point(354, 16);
            lbTitle2.Size = new Size(50, 20);
            panel2.Controls.Add(lbTitle2);

            TextBox tb = new TextBox();
            tb.Location = new Point(410, 15);
            tb.Size = new Size(235, 27);
            panel2.Controls.Add(tb);



            Button btn = new Button();
            btn.Text = "Search";
            btn.Location = new Point(679, 12);
            btn.Size = new Size(94, 29);
            panel2.Controls.Add(btn);

            grv = new DataGridView();
            grv.Location = new Point(0, 116);
            grv.Size = new Size(800, 253);
            panel2.Controls.Add(grv);
            grv.DataSource = AlbumsManager.GetAllAlbumsFromDB();
            grv.Columns["albumId"].Visible = false;
            grv.Columns["genreId"].Visible = false;
            int count = 0;
            for (int i = 0; i< grv.Rows.Count; i++)
            {
                count++;
            }
            Label lb = new Label();
            lb.Location = new Point(39, 95);
            lb.Size = new Size(Width,Height);
            panel2.Controls.Add(lb);
            lb.Text = "The number of albums: " + count;

            int put = grv.Columns.Count;
            if (grv.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn btEdit = new DataGridViewButtonColumn
                {
                    Text = "Edit",
                    Name = "Edit",
                    UseColumnTextForButtonValue = true
                };
                grv.Columns.Insert(put, btEdit);
            }
            if (grv.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn btDelete = new DataGridViewButtonColumn
                {
                    Text = "Delte",
                    Name = "Delete",
                    UseColumnTextForButtonValue = true
                };
                grv.Columns.Insert(put+1, btDelete);
            }

            



        }


        private void grv_cellclick(object sender, EventArgs e)
        {

        }

        //private void Prev_click(object sender, EventArgs e)
        //{
        //     page = 1;

        //    shoppingload();
        //    TextBox tb = new TextBox();
        //    tb.Location = new Point(410, 15);
        //    tb.Size = new Size(235, 27);
        //    panel1.Controls.Add(tb);
        //    tb.Text = page.ToString();

        //}


        private void Next_click(object sender, EventArgs e)
        {
            //page = page + 1;
            Account.nextPag();
            shoppingload();
            TextBox tb = new TextBox();
            tb.Location = new Point(410, 15);
            tb.Size = new Size(235, 27);
            panel1.Controls.Add(tb);
            

        }
      

        void shoppingload()
        {

            Label lbTitle = new Label();
            lbTitle.Text = "Genre:";
            lbTitle.Location = new Point(29, 16);
            lbTitle.Size = new Size(50, 20);
            panel1.Controls.Add(lbTitle);

            ComboBox cb1 = new ComboBox();
            cb1.Location = new Point(95, 13);
            cb1.Size = new Size(151, 28);
            panel1.Controls.Add(cb1);
            cb1.DataSource = GenreManager.GetAllGenresFromDB();
            cb1.DisplayMember = "genreName";
            cb1.ValueMember = "genredId";

            Label lbTitle2 = new Label();
            lbTitle2.Text = "Tilte:";
            lbTitle2.Location = new Point(354, 16);
            lbTitle2.Size = new Size(50, 20);
            panel1.Controls.Add(lbTitle2);

            TextBox tb = new TextBox();
            tb.Location = new Point(410, 15);
            tb.Size = new Size(235, 27);
            panel1.Controls.Add(tb);



            Button btn = new Button();
            btn.Text = "Search";
            btn.Location = new Point(679, 12);
            btn.Size = new Size(94, 29);
            panel1.Controls.Add(btn);
            
           
                Button btprev = new Button();
                btprev.Text = "Prev";
                btprev.Location = new Point(33, 327);
                btprev.Size = new Size(81, 29);
                panel1.Controls.Add(btprev);
         //   btprev.Click += new EventHandler(this.Prev_click);

                Button btnext = new Button();
                btnext.Text = "Next" ;
                btnext.Location = new Point(137, 327);
                btnext.Size = new Size(81, 29);
                panel1.Controls.Add(btnext);
                btnext.Click += new EventHandler(this.Next_click);
                 int o = Account.Pagging();
                int j = 3 * o;

            List<Albums> list= AlbumsManager.GetAllAlbumsFromDB();
            for (int i = j; i <= j+2; i++)
                {
                Albums a = list[i];
                    
                    string title = a.title.ToString();
                    string text = a.price.ToString();
                    string artist = ArtistsManager.GetArtistByIdFromDB(a.artistId);

                    int k = i + 1;
                GroupBox grb = new GroupBox();
                if (k % 3 == 1) grb.Location = new Point(3, 68);
                else if (k % 3 == 2) grb.Location = new Point(272, 68);
                else if (k % 3 == 0) grb.Location = new Point(534, 68);
                grb.Size = new Size(263, 264);
                panel1.Controls.Add(grb);
                grb.Text = title;
                PictureBox ptb = new PictureBox();
                ptb.SizeMode = PictureBoxSizeMode.Zoom;
                ptb.Location = new Point(55, 48);
                ptb.Size = new Size(125, 62);
                grb.Controls.Add(ptb);


                Label lb1 = new Label();
                lb1.Location = new Point(102, 114);
                lb1.Size = new Size(80, 18);
                grb.Controls.Add(lb1);
                lb1.Text = text;

                Label lb2 = new Label();
                lb2.Location = new Point(102, 146);
                lb2.Size = new Size(80, 18);

                grb.Controls.Add(lb2);
                lb2.Text = artist;

                Button bt = new Button();
                bt.Location = new Point(80, 189);
                bt.Size = new Size(100, 29);
                bt.BackColor = Color.Blue;
                grb.Controls.Add(bt);
                bt.Text = "Add to Cart";
                try
                {
                    ptb.Image = Image.FromFile("..\\..\\..\\..\\" + a.albumUrl ?? "");
                }
                catch (Exception)
                {

                }
                
            }
          
        }
        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            shoppingload();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account.nextPag();
            shoppingload();
        }
    }
}

