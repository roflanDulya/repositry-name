using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MetroFramework.Components;
namespace ftp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("C:\\Users\\123\\Desktopftp://228.0.1.1/test.txt");//Создаём объект FtpWebRequest
            request.Method = WebRequestMethods.Ftp.DownloadFile; // Установка метода
            FtpWebResponse response = (FtpWebResponse)request.GetResponse(); // Ответ
            Stream responseStream = response.GetResponseStream(); // поток ответа
            FileStream fs = new FileStream("C:\\Users123\\Desktop\test.txt", FileMode.Create); // поток для сохранения файла
            byte[] buffer = new byte[64];
            int size = 0;
            while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, size);
            }
            fs.Close();
            response.Close();
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
