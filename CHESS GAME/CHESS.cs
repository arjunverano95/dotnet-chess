using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHESS_GAME
{
    public partial class CHESS : Form
    {
        public CHESS()
        {
            InitializeComponent();
        }
        Colors colorEffects = new Colors();
        bool globalcheck = false;
        PictureBox checkpiece;
        string checkpiecelocation = "";
        string checkon = "";
        string w_kinglocation = "E1";
        string b_kinglocation = "E8";

        bool select = false;
        PictureBox selected;
        char selectedcolor;
        ListBox regular = new ListBox();
        ListBox special = new ListBox();
        ListBox checkmovesfilter = new ListBox();
        ListBox devour = new ListBox();
        ListBox w_kingmoves = new ListBox();
        ListBox b_kingmoves = new ListBox();
        private string getLocationName(Point location) // will return the name of chess locations ie: a4,b2; of specified coords
        {
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') != 1)
                {
                    if (CTRL.Location == location)
                    {
                        return CTRL.Name;
                    }
                }
            }
            return "";
        }
        private Point getLocationCoord(string location) // will return the coord of chess locations ie: a4,b2; of given location
        {
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') != 1)
                {
                    if (CTRL.Name == location)
                    {
                        return CTRL.Location;
                    }
                }
            }
            return new Point(0,0);
        }
        private Control getControl(Point location) // will return the chess piece ie: pawn,queen; of given coords
        {
            Control c = new Control();
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') == 1)
                {
                    if (CTRL.Location == location)
                    {
                        return CTRL;
                    }
                }
            }
            return c;
        }
        private Control getControl(string location)// will return the chess piece ie: pawn,queen; of given location
        {
            Control c = new Control();
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') == 1)
                {
                    if (CTRL.Name == location)
                    {
                        return CTRL;
                    }
                }
            }
            return c;
        }
        private bool checkifavailable(string name) // will check if location ie: a4,b2; is available
        {
            Point location = new Point(0,0);
            int count = 0;
            location = getLocationCoord(name);
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Location == location)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return false;
            }
            return true;

        }
        private string checkcolor(string name) // will return the color of the piece at the given location ie: a4,b2
        {
            Point location = new Point(0, 0);
            location = getLocationCoord(name);
           
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') == 1)
                {
                    if (CTRL.Location == location)
                    {
                        return CTRL.Name[0].ToString();
                    }
                }
            }
            return "-";
        }
        private void checkmovesonly(int colorval)//move available if under check
        {
            
            string checkpiecetype = checkpiece.Name.Substring(2, checkpiece.Name.Length - 3);
            if (checkpiecetype == "pawn" || checkpiecetype == "knight")
                checkmovesfilter.Items.Add(checkpiecelocation);
            else 
            {
                if (checkon[0] == checkpiecelocation[0]) //vertical
                {
                    int i=Convert.ToInt32(checkpiecelocation[1].ToString());
                    while(i != Convert.ToInt32(checkon[1].ToString()))
                    {
                        checkmovesfilter.Items.Add(checkon[0].ToString() + i.ToString());
                        i -= colorval;
                    }
                }
                else if (checkon[1] == checkpiecelocation[1]) //horizontal
                {
                    int i = Convert.ToInt32(checkpiecelocation[1].ToString());
                    int c = 0;
                    int s = (int)checkpiecelocation[0];
                    if ((int)checkon[0] > (int)checkpiecelocation[0]) c = -1;
                    else c = 1;
                    while (s != (int)checkon[0])
                    {
                        checkmovesfilter.Items.Add(((char)s).ToString() + i.ToString());
                        s -= c;
                    }

                }
                else //diagonal
                {
                    int i = Convert.ToInt32(checkpiecelocation[1].ToString());
                    int c = 0;
                    int s = (int)checkpiecelocation[0];
                    if ((int)checkon[0] > (int)checkpiecelocation[0]) c = -1;
                    else c = 1;
                    while (i != Convert.ToInt32(checkon[1].ToString()))
                    {
                        checkmovesfilter.Items.Add(((char)s).ToString() + i.ToString());
                        i -= colorval;
                        s -= c;
                    }
                }
            }
        }
        private bool isincheckmovesfilter(string location)
        {
            for (int i = 0; i < checkmovesfilter.Items.Count; i++)
            {
                if (location == checkmovesfilter.Items[i].ToString()) return true;
            }
            return false;
        }
        private void checkmovesgo(string type, string location) //moves, if under check
        {
            switch (type)
            {
                case "regular" :
                    if (isincheckmovesfilter(location) == true) regular.Items.Add(location);
                    break;
                case "devour":
                    if (isincheckmovesfilter(location) == true) devour.Items.Add(location);
                    break;
                default :
                    break;
            }
        }
        private void moves(PictureBox pbx, string piece, string location, string color,bool check) //will identify the possible moves available per piece
        {
            int colorval = 0; //increment value
            int colorloc = 0; //first piece of pawn
            if (color == "white")
            {
                colorval = 1;
                colorloc = 2;
            }
            else
            {
                colorval = -1;
                colorloc = 7;
            }
            regular.Items.Clear();//regular
            devour.Items.Clear();//devour
            checkmovesfilter.Items.Clear();//moves available if under check
            if (globalcheck == true) checkmovesonly(colorval);
            if (piece == "pawn")
            {
                bool corner = false;
                string s = "";

                int i = Convert.ToInt32(location[1].ToString()) + colorval; //+1
                if (i > 8 && i<1)
                {
                    corner = true;
                }
                if (corner == false)
                {
                    s = location[0].ToString() + i.ToString();
                    if (checkifavailable(s) == true)
                    {
                        if (globalcheck == true) checkmovesgo("regular",s);
                        else regular.Items.Add(s); 

                        if (location[1].ToString() == colorloc.ToString()) //if first piece, +2
                        {
                            i = i + colorval;
                            s = location[0].ToString() + i.ToString();
                            if (checkifavailable(s) == true)
                            {
                                if (globalcheck == true) checkmovesgo("regular", s);
                                else regular.Items.Add(s);
                            }
                        }
                    }
                    int i2 = Convert.ToInt32(location[1].ToString()) + colorval; //if pawn can eat
                    int[] charcast = { (int)location[0] - 1, (int)location[0] + 1 };
                    string[] sd = { ((char)charcast[0]).ToString() + i2.ToString(), ((char)charcast[1]).ToString() + i2.ToString() };


                    for (int count = 0; count < charcast.Length; count++)
                    {
                        if ((char)charcast[count] >= 'A' && (char)charcast[count] <= 'H')
                        {
                            if (checkcolor(sd[count]) != color[0].ToString() && checkcolor(sd[count]) != "-")
                            {
                                if (globalcheck == true) checkmovesgo("devour", sd[count]);
                                else devour.Items.Add(sd[count]);
                            }
                        }
                    }
                }
            }

            else if (piece == "rook")
            {
                straight(location, colorval, color);
            }
            else if (piece == "knight")
            {
                char l = (char)((int)location[0]);
                int r = Convert.ToInt32(location[1].ToString());
                    
                int x = 4;
                int y = 0;
                for (int i = 0; i < 2; i++)
                {
                    string s1 = ((char)((int)l + (x -(2 - i)))).ToString() + (r + (1 + i)).ToString();
                    if (((s1[0] < 'A' || s1[0] > 'H') || ((r + (1 + i)) > 8 ||
                        (r + (1 + i)) < 1)) == false) 
                        checkandgo(s1, color,false);

                    string s2 = ((char)((int)l + (2 - i))).ToString() + (r - ((1 + i) - y)).ToString();
                    if (((s2[0] < 'A' || s2[0] > 'H') || ((r - ((1 + i) - y)) > 8 ||
                        (r - ((1 + i) - y)) < 1)) == false)
                        checkandgo(s2, color, false);

                    string s3 = ((char)((int)l - (x - (2 - i)))).ToString() + (r - (1 + i)).ToString();
                    if (((s3[0] < 'A' || s3[0] > 'H') || ((r - (1 + i)) > 8 ||
                        (r - (1 + i)) < 1)) == false)
                        checkandgo(s3, color, false);

                    string s4 = ((char)((int)l - (2 - i))).ToString() + (r + ((1 + i) - y)).ToString();
                    if (((s4[0] < 'A' || s4[0] > 'H') || ((r + ((1 + i) - y)) > 8 ||
                        (r + ((1 + i) - y)) < 1)) == false)
                        checkandgo(s4, color, false);

                    x = 0;
                    y = 4;
                }
            }
            else if (piece == "bishop")
            {
                diagonal(location, color);
            }
            else if (piece == "queen")
            {
                straight(location, colorval, color);
                diagonal(location, color);
            }
            else if (piece == "king")
            {
                int x = 0;
                for (int i = 0; i < 2; i++)
                {
                    kingparade((char)((int)location[0] + (1 - x)), Convert.ToInt32(location[1].ToString()) + 1, color);
                    kingparade((char)((int)location[0] + (1 - x)), Convert.ToInt32(location[1].ToString()) - 1, color);

                    kingparade((char)((int)location[0]), Convert.ToInt32(location[1].ToString()) + (1 - x), color);
                    kingparade((char)((int)location[0] + (1 - x)), Convert.ToInt32(location[1].ToString()), color);
                    x = 2;
                }
            }
            if (check == false)
                dothecolors(pbx);
            else
            {
                kingcheck(color,pbx,location);
            }
        }
        private void kingcheck(string color,PictureBox pbx,string coord)//will fire if check
        {
            string initial = "";
            if(color == "white")
                initial = "b";
            else
                initial = "w";
                
            for (int devourcount = 0; devourcount < devour.Items.Count; devourcount++)
            {
                Point location = new Point(0, 0);
                location = getLocationCoord(devour.Items[devourcount].ToString());
                foreach (Control CTRL in board.Controls)
                {
                    if (CTRL.Name.IndexOf('_') == 1)
                    {
                        if ((CTRL.Location == location) && (CTRL.Name.Substring(0, CTRL.Name.Length - 1) == initial + "_king"))
                        {
                            CTRL.BackgroundImage = colorEffects.devour.Image;
                            CTRL.BackgroundImageLayout = ImageLayout.Stretch;
                            CTRL.BackColor = Color.Transparent;

                            checkpiece = pbx; //the threat
                            checkon = devour.Items[devourcount].ToString(); //king location
                            checkpiecelocation = coord;//threat location
                            globalcheck = true;
                            return;
                        }
                    }
                }
            }
        }
        private void kingparade(char l, int r,string color) //king moves
        {
            if (((l < 'A' || l > 'H') || (r > 8 || r < 1)) == false)
                checkandgo(l.ToString() + r.ToString(), color, true);
        }
        private bool checkandgo(string s, string color, bool king) //wiill fire func checkifavailable();  will check if location ie: a4,b2; is available
        {
            if (checkifavailable(s) == true)
            {
                if (king == false)
                {
                    if (globalcheck == true) checkmovesgo("regular", s);
                    else regular.Items.Add(s);
                }
                else
                {
                    if (isincheckmovesfilter(s) == false) regular.Items.Add(s);
                }

            }
            else
            {
                if (checkcolor(s) != color[0].ToString() && checkcolor(s) != "-")
                {
                    if (globalcheck == true) checkmovesgo("devour", s);
                    else devour.Items.Add(s);
                }
                return false;
            }
            return true;
        }
        private void diagonal(string location, string color) //diagonal moves
        {
            char l = (char)((int)location[0] - 1);
            int r = Convert.ToInt32(location[1].ToString()) + 1;
            while (true)
            {
                if ((l < 'A' || l > 'H') || (r > 8 || r < 1)) break;
                if (checkandgo(l.ToString() + r.ToString(), color, false) == false) break;

                l--;
                r++;
            }
            l = (char)((int)location[0] + 1);
            r = Convert.ToInt32(location[1].ToString()) - 1;
            while (true)
            {
                if ((l < 'A' || l > 'H') || (r > 8 || r < 1)) break;
                if (checkandgo(l.ToString() + r.ToString(), color, false) == false) break;

                l++;
                r--;
            }
            l = (char)((int)location[0] + 1);
            r = Convert.ToInt32(location[1].ToString()) + 1;
            while (true)
            {
                if ((l < 'A' || l > 'H') || (r > 8 || r < 1)) break;
                if (checkandgo(l.ToString() + r.ToString(), color, false) == false) break;

                l++;
                r++;
            }
            l = (char)((int)location[0] - 1);
            r = Convert.ToInt32(location[1].ToString()) - 1;
            while (true)
            {
                if ((l < 'A' || l > 'H') || (r > 8 || r < 1)) break;
                if (checkandgo(l.ToString() + r.ToString(), color, false) == false) break;

                l--;
                r--;
            }
        }
        private void straight(string location, int colorval, string color) // straight moves
        {
            for (int i = Convert.ToInt32(location[1].ToString()) + colorval; i <= 8 && i >= 1; i += colorval)
            {
                if (checkandgo(location[0].ToString() + i.ToString(), color, false) == false)
                    break;
            }
            for (int i = Convert.ToInt32(location[1].ToString()) - colorval; i <= 8 && i >= 1; i -= colorval)
            {
                if (checkandgo(location[0].ToString() + i.ToString(), color, false) == false)
                    break;
            }

            for (int i = (int)location[0] + colorval; i <= (int)'H' && i >= (int)'A'; i += colorval)
            {
                if (checkandgo(((char)i).ToString() + location[1].ToString(), color, false) == false)
                    break;
            }
            for (int i = (int)location[0] - colorval; i <= (int)'H' && i >= (int)'A'; i -= colorval)
            {
                if (checkandgo(((char)i).ToString() + location[1].ToString(), color, false) == false)
                    break;
            }
        }
        private void pcs_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            select = true;
            selected = pbx;
            string color = "";
            string piece = "";
            string location = "";
            if (pbx.Name[0] == 'w')
            {
                color = "white";
            }
            else if (pbx.Name[0] == 'b')
            {
                color = "black";
            }
            foreach (Control CTRL in board.Controls) //will ensure that no other piece can be selected
            {
                if (CTRL.Name.IndexOf('_') == 1)
                {
                    CTRL.Enabled = false;
                }
            }
            location = getLocationName(pbx.Location);

            piece = pbx.Name.Substring(2, pbx.Name.Length - 3);
            moves(pbx, piece, location, color,false);

        }
        private void dothecolors(PictureBox pbx) //color effecks
        {
            foreach (Control CTRL in board.Controls)
            {
                CTRL.BackgroundImage = null;
                CTRL.BackgroundImageLayout = ImageLayout.Stretch;
                CTRL.BackColor = Color.Transparent;
            }
            pbx.BackgroundImage = colorEffects.selected.Image;
            pbx.BackgroundImageLayout = ImageLayout.Stretch;
            pbx.BackColor = Color.Transparent;
            for (int regularcount = 0; regularcount < regular.Items.Count; regularcount++)
            {
                string location = regular.Items[regularcount].ToString();
                foreach (Control CTRL in board.Controls)
                {
                    if (CTRL.Name.IndexOf('_') != 1)
                    {
                        if (CTRL.Name == location)
                        {
                            CTRL.BackgroundImage = colorEffects.regular.Image;
                            CTRL.BackgroundImageLayout = ImageLayout.Stretch;
                            CTRL.BackColor = Color.Transparent;
                            break;
                        }
                    }
                }
                
            }
            for (int devourcount = 0; devourcount < devour.Items.Count; devourcount++)
            {
                string name = devour.Items[devourcount].ToString();
                Point location = new Point(0, 0);
                location = getLocationCoord(name);
                getControl(location).BackgroundImage = colorEffects.devour.Image;
                getControl(location).BackgroundImageLayout = ImageLayout.Stretch;
                getControl(location).BackColor = Color.Transparent;
            }
        }
       
        private void location_Click(object sender, EventArgs e)
        {
            foreach (Control CTRL in board.Controls)
            {
                CTRL.BackgroundImage = null;
                CTRL.BackgroundImageLayout = ImageLayout.Stretch;
                CTRL.BackColor = Color.Transparent;
            }
            if (globalcheck == true)
            {
                getControl(getLocationCoord(checkon)).BackgroundImage = colorEffects.devour.Image;
                getControl(getLocationCoord(checkon)).BackgroundImageLayout = ImageLayout.Stretch;
                getControl(getLocationCoord(checkon)).BackColor = Color.Transparent;
                        
            }
            bool moved = false;
            Panel location = (Panel)sender;
            if (select == true)
            {
                for (int regularcount = 0; regularcount < regular.Items.Count; regularcount++)
                {
                    if (location.Name == regular.Items[regularcount].ToString())
                    {
                        selected.Location = location.Location;
                        selectedcolor = selected.Name[0];
                        moved = true;
                        break;
                    }
                }
                for (int devourcount = 0; devourcount < devour.Items.Count; devourcount++)
                {
                    if (location.Name == devour.Items[devourcount].ToString())
                    {

                        getControl(location.Location).Dispose();
                        selected.Location = location.Location;
                        selectedcolor = selected.Name[0];
                        moved = true;
                        break;
                    }
                }

                if (moved == true)
                {
                    if (selected.Name == "w_king1")
                        w_kinglocation = location.Name;
                    else if (selected.Name == "b_king1")
                        b_kinglocation = location.Name;
                    string color = "";
                    string piece = "";
                    if (selected.Name[0] == 'w')
                    {
                        color = "white";
                    }
                    else if (selected.Name[0] == 'b')
                    {
                        color = "black";
                    }
                    piece = selected.Name.Substring(2, selected.Name.Length - 3);

                    

                    if (globalcheck == true)
                    {
                        //getControl(getLocationCoord(location.Name)).BackgroundImage = null;
                        //getControl(getLocationCoord(location.Name)).BackgroundImageLayout = ImageLayout.Stretch;
                        //getControl(getLocationCoord(location.Name)).BackColor = Color.Transparent;
                        foreach (Control CTRL in board.Controls)
                        {
                            CTRL.BackgroundImage = null;
                            CTRL.BackgroundImageLayout = ImageLayout.Stretch;
                            CTRL.BackColor = Color.Transparent;
                        }
                    }
                    globalcheck = false;
                    moves(selected, piece, location.Name, color, true);
                    moved = false;
                    
                }
            }
            turn(selectedcolor);
            select = false;
        }
        private void turn(char color) //exchange of turns
        {
            foreach (Control CTRL in board.Controls)
            {
                if (CTRL.Name.IndexOf('_') == 1)
                {
                    if (CTRL.Name[0] != color)
                    {
                        CTRL.Enabled = true;
                    }
                    else
                    {
                        CTRL.Enabled = false;
                    }
                }
            }
        }

        private void CHESS_Load(object sender, EventArgs e)
        {
            selectedcolor = 'b';
            turn(selectedcolor);
        }
        private void promotion(string color,PictureBox pbx,char no) //promotion of pawn
        {
            if (pbx.Name.Substring(0, pbx.Name.Length - 1) == color[0].ToString() + "_pawn")
            {
                foreach (Control CTRL in board.Controls)
                {
                    if ((CTRL.Name.IndexOf('_') != 1) && (pbx.Location == CTRL.Location))
                    {
                        if (CTRL.Name[1] == no)
                        {
                            Promotion p = new Promotion();
                            p.color = color;
                            p.ShowDialog();
                            pbx.Image = Promote.icon;
                            if (Promote.name == "w_queen")
                            {
                                pbx.Name = Promote.name + Promote.w_queencount.ToString();
                                Promote.w_queencount++;
                            }
                            else if (Promote.name == "w_bishop")
                            {
                                pbx.Name = Promote.name + Promote.w_bishopcount.ToString();
                                Promote.w_bishopcount++;
                            }
                            else if (Promote.name == "w_knight")
                            {
                                pbx.Name = Promote.name + Promote.w_knightcount.ToString();
                                Promote.w_knightcount++;
                            }
                            else if (Promote.name == "w_rook")
                            {
                                pbx.Name = Promote.name + Promote.w_rookcount.ToString();
                                Promote.w_rookcount++;
                            }
                            else if (Promote.name == "b_queen")
                            {
                                pbx.Name = Promote.name + Promote.b_queencount.ToString();
                                Promote.b_queencount++;
                            }
                            else if (Promote.name == "b_bishop")
                            {
                                pbx.Name = Promote.name + Promote.b_bishopcount.ToString();
                                Promote.b_bishopcount++;
                            }
                            else if (Promote.name == "b_knight")
                            {
                                pbx.Name = Promote.name + Promote.b_knightcount.ToString();
                                Promote.b_knightcount++;
                            }
                            else if (Promote.name == "b_rook")
                            {
                                pbx.Name = Promote.name + Promote.b_rookcount.ToString();
                                Promote.b_rookcount++;
                            }
                        }
                    }
                }
            }
        }
        private void w_pawn8_LocationChanged(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            promotion("white", pbx,'8');
        }

        private void b_pawn8_LocationChanged(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            promotion("black", pbx, '1');
        }
    }
}
