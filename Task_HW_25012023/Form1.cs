using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RestSharp;
using System.Timers;
using System.Windows.Forms;


namespace Task_HW_25012023
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer  = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();
           
            
        }



        //ex01
        private void ex01_Click(object sender, EventArgs e)
        {
            Task.Run(WriteToFile);
        }

        public void WriteToFile()
        {
            string FileName = "file.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine("hello");

                    }

                }
                
            }
            catch (Exception)
            {

                throw;
            }
            Thread.Sleep(1000);
        }
        //ex02
        private async void ex02_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                label1.Text = await ShowNumbers(i);
            }
        }
        public Task<string> ShowNumbers(int num)
        {
           
            return Task.Run(() =>
            {
                Thread.Sleep(1000);
                return num.ToString();

            });
        }

        //ex 05
        private async void ex05_Click(object sender, EventArgs e)
        {
            var t = await GetDataAsync();
            int sizeInBytes = Encoding.UTF8.GetByteCount(t.ToString());
            label2.Text= sizeInBytes.ToString();
        }

        public async Task<string> GetDataAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://www.ynet.co.il/home/0,7340,L-8,00.html");
                response.EnsureSuccessStatusCode(); // Throw an exception if the request failed
                var jsonString = await response.Content.ReadAsStringAsync();
                return jsonString;
            }
        }


        //ex06
        private async void ex06_Click(object sender, EventArgs e)
        {

            var ct = new CancellationTokenSource(TimeSpan.FromHours(1)).Token;
            while (stopLoop)
            {
                richTextBox1.Text = await loop();
                if (ct.IsCancellationRequested)
                {
                    stopLoop = false;
                    Application.Exit();
                }
            }

        }
       
        public bool stopLoop { get; set; } = true;
        public async Task<string> loop()
        {
           
            string result = null;
            result = await FetchXML();
           
            
            return result;
        }

        private Task<string> FetchXML()
        {
            string lastItem = "";
            return Task.Run(() =>
            {
                Thread.Sleep(120000);
                try
                {
                    // Fetch XML file
                    WebClient client = new WebClient(); //מוריד את הקובץ מכתובת האתר
                    string xmlString = client.DownloadString("http://www.ynet.co.il/Integration/StoryRss2.xml");

                    // Load XML string into XmlDocument
                    XmlDocument doc = new XmlDocument(); //יוצר אובייקט חדש לעבודה עם xml
                    doc.LoadXml(xmlString);// טוען מהמחרוזת ומקבל את כל הפרמטרים 

                    // Get first new item
                    XmlNodeList items = doc.GetElementsByTagName("item");
                    foreach (XmlNode item in items)
                    {
                        XmlNode titleNode = item.SelectSingleNode("title");
                        string title = titleNode.InnerText;
                        if (title != lastItem)
                        {
                            lastItem = title;
                            return title;

                        }

                    }
                }
                catch (WebException)
                {
                    Console.WriteLine("Error fetching XML file.");
                }
                return "Error fetching XML file.";

            });
        }
           
   
    }
}