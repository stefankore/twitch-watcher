using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Twitch_Watcher
{
     

    public partial class Hauptfenster : Form
    {
        int count = 0;
        
        public Hauptfenster()
        {
            InitializeComponent();
        }
        public void Testbutton_Click(object sender, EventArgs e)
        {
           if(Username_textbox.Text != "")
           {   
       
               string sUsername = Username_textbox.Text;
               string UsernameSafe = sUsername;
               string weburlvideo, weburlchat;
               string url = "https://api.twitch.tv/kraken/streams/" + UsernameSafe;
               var TwitchData = _download_serialized_json_data<TwitchData>(url);

               string sUrl = "https://api.twitch.tv/kraken/streams/" + sUsername;
               HttpWebRequest wRequest = (HttpWebRequest)HttpWebRequest.Create(sUrl);
               wRequest.ContentType = "application/json";
               wRequest.Accept = "application/vnd.twitchtv.v3+json";
               wRequest.Method = "GET";

               dynamic wResponse = wRequest.GetResponse().GetResponseStream();
               StreamReader reader = new StreamReader(wResponse);
               dynamic res = reader.ReadToEnd();
               reader.Close();
               wResponse.Close();

               if (res.Contains("display_name"))
               {
                   //user is live
                   Username_textbox.Text = UsernameSafe + " is streaming right now!";
                   Testbutton.BackColor = Color.Green;

                   weburlvideo = "http://twitch.tv/" + UsernameSafe + "/popout";
                   Videofenster.Navigate(new Uri(weburlvideo));

                   weburlchat = "http://www.twitch.tv/" + UsernameSafe + "/chat?popout=";
                   Chatfenster.Navigate(new Uri(weburlchat));

                   Viewercounter.Text = "";
               } 
               else
               {
                   //user is not live
                   Username_textbox.Text = UsernameSafe + " isn't streaming right now!";
                   Testbutton.BackColor = Color.Red;
               }
           }
           else
           {
               Username_textbox.Text = "Pleeeeeeeeeaaaassssse GIVE me a NAME :)";
           }

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Videofenster.ScriptErrorsSuppressed = false;
            Chatfenster.ScriptErrorsSuppressed = false;
            Videofenster.ScrollBarsEnabled = false;
            Chatfenster.ScrollBarsEnabled = false;
            hidechatbt.BackColor = Color.Red;
        }
        public void hidechatbt_Click(object sender, EventArgs e)
        {
            count++;

            if (count % 2 == 0)
            {
                Chatfenster.Visible = true;
                hidechatbt.BackColor = Color.Red;
                this.Size = new Size(1200, 665);
                hidechatbt.Text = "HIDE CHAT!";
            }
            else
            {
                Chatfenster.Visible = false;
                hidechatbt.BackColor = Color.Green;
                this.Size = new Size(900, 665);
                hidechatbt.Text = "SHOW CHAT!";
            }
        }
        public void Username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
            //Testbutton_Click();            
            }
        }
        public static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
    public class TwitchData
    {
        public string game { get; set; }
        public string viewers { get; set; }
        public string broadcaster_language { get; set; }
        public string status { get; set; }
        public string display_name { get; set; }
    } 
}
