using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImHateWinForm
{
    public class DataModel
    {
    public string MailGetir(int id)
        {
            try
            {
                string mail = "";
                XDocument xDoc = XDocument.Load("../../personeller.xml");
                XElement root = xDoc.Root;
                foreach (XElement item in root.Elements())
                {
                    Personeller p = new Personeller();
                    p.id = Convert.ToInt32(item.Attribute("id").Value);
                    p.isim = item.Element("isim").Value;
                  
                    p.Telefon = item.Element("telefon").Value;
                    p.Mail = item.Element("mail").Value;
                    if(p.id == id)
                    {
                        mail += p.Mail;
                    }
 



                }
                return mail;
            }
            catch
            {
                return null;
            }
           
        }
        public string TelGetir(int id)
        {
            try
            {
                string tel = "";
                XDocument xDoc = XDocument.Load("../../personeller.xml");
                XElement root = xDoc.Root;
                foreach (XElement item in root.Elements())
                {
                    Personeller p = new Personeller();
                    p.id = Convert.ToInt32(item.Attribute("id").Value);
                    p.isim = item.Element("isim").Value;
                  
                    p.Telefon = item.Element("telefon").Value;
                    p.Mail = item.Element("mail").Value;
                    if (p.id == id)
                    {
                        tel += p.Telefon;
                    }




                }
                return tel;
            }
            catch
            {
                return null;
            }

        }
    }

}
