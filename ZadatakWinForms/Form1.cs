using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakWinForms
{
    public partial class Form1 : Form
    {
        private readonly StudentService _service;

        public Form1()
        {
            InitializeComponent();
            _service = new StudentService();

            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cmbJmbag.Items.Clear();

            cmbJmbag.Items.Add("Choose");

            var jmbags = await _service.GetJmbags();

            foreach (var item in jmbags)
            {
                cmbJmbag.Items.Add(item);
            }

            cmbJmbag.SelectedIndex = 0;
        }
        private async void buttonGet_Click(object sender, EventArgs e)
        {
            var jmbags = await _service.GetJmbags();

            textRésultat.Text = string.Join(Environment.NewLine, jmbags);
        }
        private async void buttonPost_Click(object sender, EventArgs e)
        {
            if (cmbJmbag.SelectedIndex <= 0)
            {
                MessageBox.Show("Choose a JMBAG.");
                return;
            }

            string jmbag = cmbJmbag.SelectedItem.ToString();

            string result = await _service.SendPost(jmbag);

            textRésultat.Text = result;
        }
        public class StudentService
        {
            private readonly HttpClient _client;

            public StudentService()
            {
                _client = new HttpClient();
                _client.BaseAddress = new Uri("https://localhost:5225/");
            }

            public async Task<List<string>> GetJmbags()
            {
                return await _client.GetFromJsonAsync<List<string>>
                    ("api/students/jmbags");
            }

            public async Task<string> SendPost(string jmbag)
            {
                var response = await _client.PostAsJsonAsync(
                    "api/students",
                    new { Jmbag = jmbag });

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
