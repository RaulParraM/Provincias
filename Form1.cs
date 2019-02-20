using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Provncias
{
    public partial class Form1 : Form
    {
        private XmlDocument doc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Provincias.xml";
            doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList ProvinciasList = doc.SelectNodes("Provincias/Provincia");
            XmlNode provincia;
            for(int i = 0; i < ProvinciasList.Count; ++i)
            {
                provincia = ProvinciasList.Item(i);
                string provinciaLeida = provincia.SelectSingleNode("Nombre").InnerText;
                CBProvincias.Items.Add(provinciaLeida);
            }
        }
    }
}
