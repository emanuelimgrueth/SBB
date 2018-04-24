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
    public partial class Form2 : Form
    {
        public ITransport t = new Transport();
        public Form2()
        {
            InitializeComponent();
        }


        private void bSuchen_Click(object sender, EventArgs e)
        {
            dGResultate.Rows.Clear();

            List<StationBoard> stationBoard = t.GetStationBoard(cVon.Text, "10").Entries;

            stationBoard.ForEach(delegate (StationBoard s)
            {
                dGResultate.Rows.Add
                (s.To.ToString(), s.Stop.Departure.Hour.ToString() + ":" + s.Stop.Departure.Minute.ToString());

            });

        }
   

       

        private void cVon_DropDown_1(object sender, EventArgs e)
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
    }
}
