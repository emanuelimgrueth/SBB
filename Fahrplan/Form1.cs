using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    public partial class Fahrplan : Form
    {
        public ITransport t = new Transport();
        public Fahrplan()
        {
            InitializeComponent();
        }

        private void bSuche_Click(object sender, EventArgs e)
        {
            dGResultate.Rows.Clear();

            List<Connection> cList = t.GetConnections(cVon.Text, cNach.Text).ConnectionList;

            cList.ForEach(delegate (Connection c)
            {
                DateTime abfahrt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime ankunft = new DateTime(1970, 1, 1, 0, 0, 0, 0);


                abfahrt = abfahrt.AddSeconds(Double.Parse(c.From.DepartureTimestamp));
                ankunft = ankunft.AddSeconds(Double.Parse(c.To.ArrivalTimestamp));

                if (c.From.Platform == null) { c.From.Platform = ""; } 
                if (c.To.Platform == null) { c.To.Platform = ""; } 

                dGResultate.Rows.Add(abfahrt.Hour.ToString() + ":" + abfahrt.Minute.ToString(), c.From.Platform.ToString(), ankunft.Hour.ToString() + ":" + ankunft.Minute.ToString(), c.To.Platform.ToString());

            });
        }

     private void cVon_DropDown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cVon.Text))
            {
                List<Station> station = t.GetStations(cVon.Text).StationList;
                if (station.Count > 0)
                {
                    cVon.DataSource = null;
                    cVon.DataSource = station;
                    cVon.DisplayMember = "Name";
                }
            }
        }

        private void cNach_DropDown(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cNach.Text))
            {
                List<Station> station = t.GetStations(cNach.Text).StationList;
                if (station.Count > 0)
                {
                    cNach.DataSource = null;
                    cNach.DataSource = station;
                    cNach.DisplayMember = "Name";
                }
            }
        }

        private void bAbfahrtsTafel_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
        }
    }
}
