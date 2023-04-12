using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Net.Http.Json;
using System.Data;
using WinFormsLetter;

namespace WinFormsLetter
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]

        static HttpClient client = new HttpClient();
        static DataBaseLetterInfo info = new DataBaseLetterInfo();
       
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }

        public static async Task RunAsync(DataBaseLetterInfo info)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:7056/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            await CheckData(info);

        }



        public static async Task CheckData(DataBaseLetterInfo info)
        {
            bool flag = false;
            string s = String.Empty;
            
            if ((info.Sender == "") || (info.Sender == null) || (!info.Sender.Contains("@")))
            {
                flag = true;
                s += "Почта отправителя некорректна. \n";
            }

            if ((info.To == "") || (info.To == null) || (!info.To.Contains("@")))
            {
                flag = true;
                s += "Почта получателя некорректна. \n";
            }

            if ((info.Subject  == "") || (info.Subject == null))
            {
                flag = true;
                s += "Тема письма не указана. \n";
            }

            if ((info.LetterBody == "") || (info.LetterBody == null))
            {
                flag = true;
                s += "Пустое сообщение. ";
            }

            if (flag)
            {
                MessageBox.Show(s, "Валидация", MessageBoxButtons.OK);
                
            }
            else
            {
                await UpdateSetStatusAsync(info);
            }

        }

        public static async Task UpdateSetStatusAsync(DataBaseLetterInfo info)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
               $"/database/setdata/", info);
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Письмо успешно отправлено!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}