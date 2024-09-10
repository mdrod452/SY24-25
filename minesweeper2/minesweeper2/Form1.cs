namespace minesweeper2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                btnGrid[i].BackColor = Color.Green;
            }
        }
    }
}
