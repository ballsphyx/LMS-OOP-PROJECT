using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioLibrarySystem.Views
{
    public partial class adminDashpan : Form
    {
        public adminDashpan()
        {
            InitializeComponent();
        }
        private void RoundPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, pnl.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, pnl.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            pnl.Region = new Region(path);
        }

        private void adminDashpan_Load(object sender, EventArgs e)
        {
            RoundPanel(panel1, 50);
            RoundPanel(panel2, 50);
            RoundPanel(panel3, 50);
        }

        private void dgvRcntRtrnsAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
