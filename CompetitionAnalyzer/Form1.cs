using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionAnalyzer
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Uri url = new Uri("https://www.akakce.com/kahvalti-takimi/en-ucuz-bambum-b2666-bouquet-22-parca-2-kisilik-fiyati,37886773.html");
            //Uri url = new Uri("https://www.akakce.com/ekmek-kutusu-sepeti/en-ucuz-bambum-solly-19-cm-ekmek-kutusu-fiyati,243110060.html");
            dt.Rows.Clear();
            if (tb_url.Text.Trim().Equals("")) return;
            Uri url = new Uri(tb_url.Text);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            var head = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/div/div[1]/h1")[0];
            label_product_name.Text = head.InnerHtml;

            var cal = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/p/i")[0];
            string numb = cal.InnerHtml;
            string a = string.Empty;
            int number;
            for (int i = 0; i < numb.Length; i++)
            {
                if (char.IsDigit(numb[i]))
                {
                    a += numb[i];
                }
            }
            number = Convert.ToInt32(a);
            if (number > 10) number = 10;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    var s = string.Empty;
                    var p = string.Empty;

                   
                
                    if (document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]") != null)
                    {
                        var cal1 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]/ul/li[{i}]/a/span[1]/span")[0];
                        s = cal1.InnerHtml;
                    }
                    else if (document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]")[0] != null)
                    {
                        var cal1 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]/ul/li[{i}]/a/span[1]/span")[0];
                        s = cal1.InnerHtml;
                    }

                    var n = 0;
                    for (int j = 0; j < s.Length; j++)
                    {


                        if (char.IsDigit(s[j]))
                        {

                            p += s[j];
                        }
                        else
                        {
                            if (n == 0) p += ",";

                            if (j == s.Length - 1) p += " TL";
                            n++;
                        }
                    }
                    if (p.Equals(", TL"))
                    {
                        p = string.Empty;
                        if (document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]") != null)
                        {
                            var cal2 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]/ul/li[{i}]/a/span[1]/span[2]")[0];
                            s = cal2.InnerHtml;
                        }
                        else if (document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]")[0] != null)
                        {
                            var cal2 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]/ul/li[{i}]/a/span[1]/span[2]")[0];
                            s = cal2.InnerHtml;
                        }
                        

                        var k = 0;
                        for (int j = 0; j < s.Length; j++)
                        {


                            if (char.IsDigit(s[j]))
                            {

                                p += s[j];
                            }
                            else
                            {
                                if (k == 0) p += ",";

                                if (j == s.Length - 1) p += " TL";
                                k++;
                            }
                        }
                    }

                    string st = string.Empty;
                    if (document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]") != null)
                    {
                        var cal3 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[3]/ul/li[{i}]/a/span[5]/span")[0];
                        st = cal3.InnerHtml;
                    }
                    else if(document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]")[0] != null)
                    {
                        var cal3 = document.DocumentNode.SelectNodes($"/html/body/main/div[1]/section/div[2]/ul/li[{i}]/a/span[5]/span")[0];
                        st = cal3.InnerHtml;
                    }
                    
                   

                    if (st.Contains("<img"))
                    {
                        var q = st.Length;
                        var stIndex = st.IndexOf("<span>") + 6;
                        var fnIndex = st.Substring(stIndex).IndexOf("</span>");
                        string company = st.Substring(stIndex, fnIndex);
                        var lastIndex = st.LastIndexOf("</span>") + 7;
                        company += st.Substring(lastIndex);
                        dt.Rows.Add(company, p);
                    }
                    else if (!st.Contains("<img") && st.Contains("<span"))
                    {
                        var stIndex = st.IndexOf("<span");
                        string company = st.Substring(0, stIndex);
                        dt.Rows.Add(company, p);
                    }
                    else
                    {
                        var company = st;
                        dt.Rows.Add(company, p);
                    }
  
                    dg_products.DataSource = dt;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("Satıcı Firma");
            dt.Columns.Add("Fiyat");
            dg_products.DataSource = dt;

        }
    }
}
