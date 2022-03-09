namespace APL_V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string visitor = tbxVisitor.Text;
            string date = dateTimePicker1.Text;
        }
        /*String in/utloggad = tbxVisitor.text;
         * Messagebox.show("..is" + in/utlogga*/

        /*string users() eller "Logga In" som funktion?
         * string user = tbxUsername.text;
         * string password = tbxpassword.text;
         * if(user.Equals("Bertil" && password.Equals("Balle Baloo"))
         * >åtkomst beviljad??
         *else messageBox.show("Felaktigt namn eller lösenord.")*/
    }
}