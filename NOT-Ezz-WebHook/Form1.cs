using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using JNogueira.Discord.Webhook.Client;

namespace NOT_Ezz_WebHook
{
    public partial class Form1 : Form
    {
        String TITLE = "NOT Ezz Webhook";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            String path;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
            openFileDialog.Title = TITLE;

            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = openFileDialog.FileName;
                ImagePath.Text = path;
            }
        }

        private void ColorEmbedButton_Click(object sender, EventArgs e)
        {
            if (ColorEmbed.ShowDialog() == DialogResult.OK)
            {
                String colorcode = string.Format(
                    "#{0:X2}{1:X2}{2:X2}",
                    ColorEmbed.Color.R,
                    ColorEmbed.Color.G,
                    ColorEmbed.Color.B);
                ColorEmbedText.Text = int.Parse(colorcode.Substring(1), System.Globalization.NumberStyles.HexNumber).ToString();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String URL = WebhookUrl.Text;
            String Name = name.Text;
            String ImageUrl = ImagePath.Text;
            String Message = message.Text;

            if (URL == "")
            {
                ShowMessageBox("URLが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Name == "")
            {
                ShowMessageBox("Nameが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DiscordWebhookClient client = new DiscordWebhookClient(URL);
            DiscordMessage DiscordMessage;

            if (!EmbedCheckbox.Checked)
            {
                if (Message == "")
                {
                    ShowMessageBox("Messageが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DiscordMessage = new DiscordMessage(
                    Message,
                    username: Name,
                    avatarUrl: ImageUrl,
                    tts: false
                );
            }
            else
            {
                if (ColorEmbedText.Text == "")
                {
                    ShowMessageBox("Colorが設定されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string Title = EmbedTitle.Text;
                string Description = DescriptionEmbed.Text;
                string Footer = FooterEmbed.Text;
                int color = Int32.Parse(ColorEmbedText.Text);

                if (Title == "")
                {
                    ShowMessageBox("Titleが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Description == "")
                {
                    ShowMessageBox("Descriptionが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Footer == "")
                {
                    ShowMessageBox("Footerが入力されていません。", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DiscordMessageEmbed MessageEmbed = new DiscordMessageEmbed(
                    Title,
                    color: color,
                    description: Description,
                    footer: new DiscordMessageEmbedFooter(Footer)
                );
                DiscordMessage = new DiscordMessage(
                    Message,
                    username: Name,
                    avatarUrl: ImageUrl,
                    tts: false,
                    embeds: new[]
                    {
                        MessageEmbed
                    }
                );
            }
            try
            {
                await client.SendToDiscord(DiscordMessage);
                ShowMessageBox("正常に送信成功しました。", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception _)
            {
                ShowMessageBox("送信に失敗しました。", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ShowMessageBox(string text, MessageBoxButtons button, MessageBoxIcon icon)
        {
            MessageBox.Show(text, "NOT-Ezz-WebHook", button, icon);
        }

        private String toUnicode(String text)
        {
            String Unicode = "";

            byte[] b1 = Encoding.GetEncoding("utf-16").GetBytes(text);

            foreach (byte b in b1)
            {
                if (string.Format("{0:X2}", b).Length == 1)
                {
                    Unicode += "\\u000" + (string.Format("{0:X2}", b));
                }
                else if (string.Format("{0:X2}", b).Length == 2)
                {
                    Unicode += "\\u00" + (string.Format("{0:X2}", b));
                }
                else if (string.Format("{0:X2}", b).Length == 3)
                {
                    Unicode += "\\u0" + (string.Format("{0:X2}", b));
                }
            }
            //Console.WriteLine(Unicode);
            return Unicode;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
