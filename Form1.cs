namespace Private_SMS
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        string originalChars = "abcdefghijklmnopqrstuvwxyz ";
        string encryptedChars = "!@#$%^&*()_+{}|:<>?1234567";

        // تابع رمزنگاری
        private string Encrypt(string input)
        {
            string result = "";

            foreach (char c in input.ToLower())
            {
                int index = originalChars.IndexOf(c);
                if (index != -1 && index < encryptedChars.Length)
                    result += encryptedChars[index];
                else
                    result += c;
            }

            return result;
        }

        // تابع رمزگشایی
        private string Decrypt(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                int index = encryptedChars.IndexOf(c);
                if (index != -1 && index < originalChars.Length)
                    result += originalChars[index];
                else
                    result += c;
            }

            return result;
        }







        // دکمه رمزگشایی → textBox2 رو می‌خونه، نتیجه رو تو textBox3 می‌ذاره

        private void btn_2_Click_1(object sender, EventArgs e)
        {

            string input = textBox2.Text;
            textBox3.Text = Decrypt(input);
        }


        // دکمه رمزنگاری → textBox1 رو می‌خونه، نتیجه رو تو textBox3 می‌ذاره

        private void btn_1_Click_1(object sender, EventArgs e)
        {

            string input = textBox1.Text;
            textBox3.Text = Encrypt(input);
        }

    }
}
