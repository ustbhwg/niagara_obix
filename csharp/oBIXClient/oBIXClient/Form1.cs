using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RestSharp;
using RestSharp.Authenticators;

/// <summary>
/// 注意，代码仅为示例，原则上需要异步操作
/// </summary>
namespace oBIXClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 用于未签名的 SSL 验证
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {
            var client = new RestClient();
            client.Authenticator = new HttpBasicAuthenticator("obix", "Admin12345");

            var request = new RestRequest(txtURI.Text, DataFormat.Xml);

            var response = client.Get(request);
            String sXml = response.Content;
            //Console.WriteLine(sXml);
            txtResult.Text = sXml;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(sXml);
            String sVal = xmlDoc.DocumentElement.GetAttribute("val");
            lblValue.Text = sVal;
        }

        private void btnHisQuery_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();

            var client = new RestClient();
            client.Authenticator = new HttpBasicAuthenticator("obix", "Admin12345");

            var request = new RestRequest(txtHisURI.Text,Method.POST, DataFormat.Xml);
            String sXml =@"
<obj is='obix:HistoryFilter'>
  <abstime name='start' val='2021-01-01T00:00:00.000+08:00' tz='Asia/Shanghai'/>
  <abstime name='end' val='2021-02-01T00:00:00.000+08:00' tz='Asia/Shanghai'/>
  <reltime name='interval' val='PT1D'/>
</obj>";

            request.AddParameter("text/plain", sXml, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            //            var response = client.Post(request);
            sXml = response.Content;
            //Console.WriteLine(sXml);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(sXml);
            XmlNode list = xmlDoc.DocumentElement.ChildNodes[0];
            foreach(XmlNode node in list.ChildNodes)
            {
                ListViewItem listViewItem = new ListViewItem(new String[] {
                    ((XmlElement)node.ChildNodes[0]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[1]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[2]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[3]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[4]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[5]).GetAttribute("val"),
                    ((XmlElement)node.ChildNodes[6]).GetAttribute("val"),
                });
                lstHistory.Items.Add(listViewItem);
            }
        }
    }
}
