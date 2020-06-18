using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuristDB_App
{
    public partial class Form1 : Form
    {
        TouristDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new TouristDbContext();
        }
        /// <summary>
        /// 1)	En çok gezilen yer/yerler neresidir?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSoru1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            dgvData.DataSource=(from en in (db.Plans.GroupBy(a => a.Location).Select(a => new { Yer = a.Key.LocationDescription, Sayisi = a.Count() }))
                                where en.Sayisi== (db.Plans.GroupBy(a => a.Location).Select(a => new { Yer = a.Key.LocationDescription, Sayisi = a.Count() })).Max(a=>a.Sayisi)
                                select en).ToList();
        }
        /// <summary>
        /// 2)	Ağustos ayında en çok çalışan rehber/rehberler kimdir/kimlerdir?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSoru2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvData.DataSource = (from f in (db.Plans.Where(a => SqlFunctions.DateName("Month", a.ArrivalDateInTurkey) == SqlFunctions.DateName("Month",new DateTime(1212,08,21))).GroupBy(a=>a.Guide).Select(a=>new { Calisan = a.Key.Name+" "+a.Key.Surname , Sayi=a.Count() }).OrderByDescending(a=>a.Sayi))
                                  where f.Sayi == (db.Plans.Where(a => SqlFunctions.DateName("Month", a.ArrivalDateInTurkey) == SqlFunctions.DateName("Month", new DateTime(1212, 08, 21))).GroupBy(a => a.Guide).Select(a => new { Calisan = a.Key.Name + " " + a.Key.Surname, Sayi = a.Count() }).OrderByDescending(a => a.Sayi)).Max(a=>a.Sayi)
                                  select f).ToList();
        }
        /// <summary>
        /// 9)	Linda Callahan’ın rehberlik ettiği turistler kimlerdir?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llSoru9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvData.DataSource = db.Plans.Where(a => a.Guide.Name == "Linda" && a.Guide.Surname == "Callahan").Select(a => new { a.Tourist.Name, a.Tourist.Surname }).ToList();
        }
    }
}
