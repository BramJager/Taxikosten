using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxikosten
{
    public partial class Taxikosten : Form
    {
        public Taxikosten()
        {
            InitializeComponent();
        }

        TimeSpan Timepassed;
        decimal Minutes;
        decimal tempPrice;
        decimal Price;
        decimal ritafstand;
        decimal a = 0.25m;
        decimal b = 0.45m;
        DateTime dag;
        DateTime Begin;
        DateTime Eind;
        DateTime A = new DateTime(2000, 1, 1, 8, 0, 0);
        DateTime B = new DateTime(2000, 1, 1, 18, 0, 0);
        DateTime C = new DateTime(2000, 1, 1, 7, 0, 0);
        DateTime D = new DateTime(2000, 1, 1, 22, 0, 0);
        bool time;
        bool weekend;

        private void Beginstand_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Eindstand_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ritafstand_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Begintijd_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Eindtijd_ValueChanged(object sender, EventArgs e)
        {

        }        
        private void Ritduur_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Dag_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBeginstand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEindstand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRitafstand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBegintijd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEindtijd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDag_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ritprijs_Click(object sender, EventArgs e)
        {
                if (Ritafstand.Value == 0)
                { 
                    Ritafstand.Value = Eindstand.Value - Beginstand.Value; 
                }

            Timepassed = Eindtijd.Value - Begintijd.Value;
            Minutes = Convert.ToDecimal(Timepassed.TotalMinutes);
            Ritduur.Value = Minutes;
            ritafstand = Convert.ToDecimal(Ritafstand.Value);
            Begin = Begintijd.Value;
            dag = Dag.Value;

            if (Begin.TimeOfDay >= A.TimeOfDay && Begin.TimeOfDay <= B.TimeOfDay)
            {
                time = true;
            }

            else
            {
                time = false;
            }

                if (time == true)
                {
                    tempPrice = Decimal.Multiply(a, Minutes);
                }

                else
                {
                    tempPrice = Decimal.Multiply(b, Minutes);
                }

            tempPrice = tempPrice + ritafstand;

            if (dag.DayOfWeek ==  DayOfWeek.Saturday || dag.DayOfWeek == DayOfWeek.Sunday)
            {
                weekend = true;
            }

            else if ((dag.DayOfWeek == DayOfWeek.Friday) && (Begin.TimeOfDay >= D.TimeOfDay))
            {
                weekend = true;
            }

            else if ((dag.DayOfWeek == DayOfWeek.Monday) && (Begin.TimeOfDay <= C.TimeOfDay))
            {
                weekend = true;
            }

            else
            {
                weekend = false;
            }


                if (weekend == true)
                {
                    Price = Decimal.Multiply(1.15m, tempPrice);
                }

                else
                {
                    Price = tempPrice;
                }

            string endPrice = Price.ToString("C");
            textboxRitprijs.Text = endPrice;
        }

        private void textboxRitprijs_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRitduur_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
