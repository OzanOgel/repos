using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ImHateWinForm
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        List<Personeller> personellerList = new List<Personeller>();
        public Form1()
        {
            InitializeComponent();
         
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load("../../personeller.xml");
            XElement root = xDoc.Root;
            foreach (XElement item in root.Elements())
            {
                Personeller p = new Personeller();
                p.id = Convert.ToInt32(item.Attribute("id").Value);
                p.isim = item.Element("isim").Value;
            
                p.Telefon = item.Element("telefon").Value;
                p.Mail= item.Element("mail").Value;
                personellerList.Add(p);

               

            }

            cb_personel.DisplayMember = "isim";
            cb_personel.ValueMember = "id";
            cb_personel.DataSource = personellerList;
          

        }

        private void cb_personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_mail.Text = dm.MailGetir(Convert.ToInt32(cb_personel.SelectedValue));
            tb_telefon.Text = dm.TelGetir(Convert.ToInt32(cb_personel.SelectedValue));
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load("../../personeller.xml");
            XElement root = xDoc.Root;
            foreach (XElement item in root.Elements())
            {
                if (item.Attribute("id").Value == cb_personel.SelectedValue.ToString())
                {
                    item.Remove();
                    break;
                }
            }
            personellerList.RemoveAll(p => p.id == Convert.ToInt32(cb_personel.SelectedValue));
            xDoc.Save("../../personeller.xml");
            cb_personel.DataSource = null;

            cb_personel.DisplayMember ="isim";
            cb_personel.ValueMember = "id";
            cb_personel.DataSource = personellerList;
            MessageBox.Show("Başarıyla Silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load("../../personeller.xml");
            XElement root = xDoc.Root;
            foreach (XElement item in root.Elements())
            {
                if (item.Attribute("id").Value == cb_personel.SelectedValue.ToString())
                {
                    item.Element("isim").Value = cb_personel.Text;
                    item.Element("telefon").Value = tb_telefon.Text;
                    item.Element("mail").Value = tb_mail.Text;
                    Personeller p = personellerList.Find(pa => pa.id == Convert.ToInt32(cb_personel.SelectedValue));
                    if (p != null)
                    {
                        p.isim = cb_personel.Text;
                        p.Telefon = tb_telefon.Text;
                        p.Mail = tb_mail.Text;
                    }
                    break;
                }
            }
            xDoc.Save("../../personeller.xml");
            cb_personel.DataSource = null;

            cb_personel.DisplayMember = "isim";
            cb_personel.ValueMember = "id";
            cb_personel.DataSource = personellerList;
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int randomsayi = rndm.Next(6, 100000);



            XDocument xDoc = XDocument.Load("../../personeller.xml");
            XElement root = xDoc.Root;
            XElement newElement = new XElement("personel");
            XAttribute idAttribute = new XAttribute("id",randomsayi);
            XElement isimElement = new XElement("isim", cb_personel.Text);
           
            XElement telefonElement = new XElement("telefon", tb_telefon.Text);
            XElement mailElement = new XElement("mail", tb_mail.Text);
            newElement.Add(idAttribute, isimElement,  telefonElement, mailElement);
            root.Add(newElement);
            xDoc.Save("../../personeller.xml");
            Personeller p = new Personeller();
            p.id = randomsayi;
            p.Mail = tb_mail.Text;
            p.isim = cb_personel.Text;
            p.Telefon = tb_telefon.Text;
            personellerList.Add(p);

            cb_personel.DataSource = null;

            cb_personel.DisplayMember = "isim";
            cb_personel.ValueMember = "id";
            cb_personel.DataSource = personellerList;
            MessageBox.Show("ekleme başarılı");

        }

    }
}
