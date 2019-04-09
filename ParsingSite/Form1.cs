using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using Core;

namespace ParsingSite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetInfoSiteButton_Click(object sender, EventArgs e)
        {
            if (!InternetCheck.CheckForInternetConnection())
            {
                outputText.Text = "You haven't internet connection";
                return;
            }
            var html = siteAdress.Text;

            HtmlWeb web = new HtmlWeb();

            try
            {
                var htmlDoc = web.Load(html);

                var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

                outputText.Text = node.InnerHtml;
            }
            catch (Exception exc)
            {
#if DEBUG
                outputText.Text = exc.Data.ToString();
#else
                outputText.Text = "Invalid site adress";
#endif
            }
        }
    }
}
