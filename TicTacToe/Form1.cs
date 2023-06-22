using System.Media;

namespace TicTacToe
{
    public partial class TicTacToeLM : Form
    {
        public TicTacToeLM()
        {
            InitializeComponent();
        }

        public string player = "X";

        private void b11_Click(object sender, EventArgs e)
        {
            if (player == "X" && b11.Text == "Empty")
            {   
                b11.Text = "X";
                b11.Font = new Font("Segoe UI", 22);
                b11.ForeColor = Color.Red;
                player = "O";
                playerL.ForeColor= Color.Blue;
            }
            else if (player == "O" && b11.Text == "Empty")
            {
                b11.Text = "O";
                b11.Font = new Font("Segoe UI", 22);
                b11.ForeColor = Color.Blue;
                player = "X";
                playerL.ForeColor = Color.Red;
            }
            playerL.Text = player;
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (player == "X" && b12.Text == "Empty")
            {
                b12.Text = "X";
                b12.Font = new Font("Segoe UI", 22);
                b12.ForeColor = Color.Red;
                player = "O";
                playerL.ForeColor = Color.Blue;
            }
            else if (player == "O" && b12.Text == "Empty")
            {
                b12.Text = "O";
                b12.Font = new Font("Segoe UI", 22);
                b12.ForeColor = Color.Blue;
                player = "X";
                playerL.ForeColor = Color.Red;
            }
            playerL.Text = player;
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (player == "X" && b13.Text == "Empty")
            {
                b13.Text = "X";
                b13.Font = new Font("Segoe UI", 22);
                b13.ForeColor = Color.Red;
                player = "O";
                playerL.ForeColor = Color.Blue;
            }
            else if (player == "O" && b13.Text == "Empty")
            {
                b13.Text = "O";
                b13.Font = new Font("Segoe UI", 22);
                b13.ForeColor = Color.Blue;
                player = "X";
                playerL.ForeColor = Color.Red;
            }
            playerL.Text = player;
        }
    }
}