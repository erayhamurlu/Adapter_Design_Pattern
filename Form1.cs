using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] errorRepository = new string[400];
        int i = 0;
        IErrorModel errorModel;
        private void DbHataUret_Click(object sender, EventArgs e)
        {
            errorModel = new FaxAdapter{ ErrorNumber = 4000, ErrorDescription = " Veri tabanına bağlanılamadı." }; ;
            errorRepository[i] = errorModel.SendMail();
            listBox1.Items.Add(errorModel.SendMail());
            i++;
        }

        private void ServiceHataUret_Click(object sender, EventArgs e)
        {
            errorModel= new ServiceError { ErrorNumber = 4004, ErrorDescription = " Sunucuya bağlanılamadı." };
            listBox1.Items.Add(errorModel.SendMail());
            errorRepository[i] = errorModel.SendMail();
            i++;
        }

        private void FaxHataUret_Click(object sender, EventArgs e)
        {
            errorModel = new FaxAdapter {ErrorNumber = 8002, ErrorDescription = " Fax Adresi Bulunamadı." };
            listBox1.Items.Add(errorModel.SendMail());
            errorRepository[i] = errorModel.SendMail();
            i++;
        }

        private void HataListele_Click(object sender, EventArgs e)
        {
            
            int j = 0;
            if (errorRepository != null)
            {
                listBox1.Items.Add("---------------------------------");
                while (j <= i - 1)
                {
                    listBox1.Items.Add(errorRepository[j]);
                    j++;
                }
                listBox1.Items.Add("---------------------------------");
            }
            else
            {
                listBox1.Items.Add("---------------------------------Yazdırılacak Veri Yok.");
            }
            
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Clear(errorRepository, 0, i);
            i = 0;
            listBox1.Items.Add("---------------------------------Temizlendi");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
