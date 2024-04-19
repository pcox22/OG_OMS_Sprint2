namespace OGOMS_Sprint2 {
    public partial class _2FA : Form {
        public _2FA() {
            InitializeComponent();
        }

        private void btn2FAContinue_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }
    }
}
