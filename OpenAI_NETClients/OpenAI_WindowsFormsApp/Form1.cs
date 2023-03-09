using OpenAI_HttpClient;

namespace OpenAI_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        byte loadingCounter;
        Task loadingTask;
        bool loadingStatus;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            StartLoading();
            var responseBody = await Http_Client.Post(textBox1.Text);
            StopLoading();
            listBox1.Items.Add("Q: " + textBox1.Text);
            var lines = SplitStrings(maxLength: 90, responseBody.Response);
            listBox1.Items.Add("Chat GPT: " + lines.First());
            foreach (var item in lines.Skip(1))
            {
                listBox1.Items.Add(item);
            }
            textBox1.Clear();
        }

        private void StartLoading()
        {
            loadingStatus = true;
            loadingCounter = 1;
            var label7_Text = "Obteniendo respuesta de OpenAI API";
            label7.Text = label7_Text;
            loadingTask = Task.Run(delegate
            {
                while (loadingStatus)
                {
                    Thread.Sleep(500);
                    this.Invoke(new Action(() =>
                    {
                        label7.Text = $"{label7_Text}{string.Join("", Enumerable.Range(0, loadingCounter).Select(i => "."))}";
                    }));
                    if (loadingCounter % 3 == 0)
                    {
                        loadingCounter = 1;
                    }
                    else
                    {
                        loadingCounter++;
                    }
                }

                this.Invoke(new Action(() =>
                {
                    label7.Text = string.Empty;
                }));
            });
        }

        private void StopLoading()
        {
            loadingStatus = false;
        }

        private List<string> SplitStrings(short maxLength, string _string)
        {
            var words = _string.Split(' ');
            List<string> line = new List<string>();
            List<string> lines = new List<string>();
            line.Add(words.First());
            for (int i = 1; i < words.Length; i++)
            {
                if (line.Sum(w => w.Length) + words[i].Length <= maxLength)
                {
                    line.Add(words[i]);
                }
                else
                {
                    lines.Add(string.Join(" ", line));
                    line.Clear();
                    line.Add(words[i]);
                }
            }
            if (line.Any())
            {
                lines.Add(string.Join(" ", line));
                line.Clear();
            }

            return lines;
        }
    }
}