namespace CoinRoller
{
    public partial class MainPage : ContentPage
    {
        int points = 0;      
        int maxscore = 0;

        public MainPage()
        {
            InitializeComponent();           
        }

        private void CaraButton_Clicked(object sender, EventArgs e)
        {
            //Escolher CaraButton           
            int spin = new Random().Next(0, 2);
            if (spin == 0)
            {
                CoinCaraImg.IsVisible = true;
                CoinCoroaImg.IsVisible = false;
                points += 1;
                if (points != 0 && points > maxscore)                   
                    maxscore = points;
                ResultLabel.Text = "Cara";
            }
            else
            {
                CoinCoroaImg.IsVisible = true;
                CoinCaraImg.IsVisible = false;
                points = 0;
                ResultLabel.Text = "Coroa";
            }
            ScoreLabel.Text = points.ToString();
            MaxScoreLabel.Text = maxscore.ToString();
        }

        private void CoroaButton_Clicked(object sender, EventArgs e)
        {
            //Escolher CoroaButton
            int spin = new Random().Next(0, 2);
            if (spin == 1)
            {
                CoinCoroaImg.IsVisible = true;
                CoinCaraImg.IsVisible = false;
                points += 1;
                if (points != 0 && points > maxscore)
                    maxscore = points;
                ResultLabel.Text = "Coroa";
            }
            else
            {
                CoinCaraImg.IsVisible = true;
                CoinCoroaImg.IsVisible = false;
                points = 0;
                ResultLabel.Text = "Cara";
            }
            ScoreLabel.Text = points.ToString();            
            MaxScoreLabel.Text = maxscore.ToString();
        }        
    }

}
