using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace MovieRecommendationApp
{
    public partial class MainForm : Form
    {
        private string ApiKey = "34d1a1bd431dc14e9243d534340f360b"; // Replace with your TMDb API key
        private const string BaseUrl = "https://api.themoviedb.org/3";

        public MainForm()
        {
            InitializeComponent();
            FetchAndDisplayTopMoviesAsync();
        }

        private async void FetchAndDisplayTopMoviesAsync()
        {
            string genre = GetGenreForCurrentMonth();

            string url = $"{BaseUrl}/discover/movie?api_key={ApiKey}&with_genres={genre}&sort_by=popularity.desc";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    dynamic data = JObject.Parse(jsonString);

                    if (data.results.Count > 0)
                    {
                        Random random = new Random();
                        int randomIndex = random.Next(0, data.results.Count);
                        double movieRating = data.results[randomIndex].vote_average;
                        btnrating.Text = $"{movieRating}/10";

                        string movieTitle = data.results[randomIndex].title;
                        string movieOverview = data.results[randomIndex].overview;
                        string posterPath = data.results[randomIndex].poster_path;

                        txtmovietitle.Text = movieTitle.ToUpper();
                        txtoverview.Text = movieOverview;

                        // Set genre text on the button
                        btngenre.Text = GetGenreForCurrentMonthName();

                        // Display movie poster
                        if (!string.IsNullOrEmpty(posterPath))
                        {
                            string imageUrl = $"https://image.tmdb.org/t/p/w500{posterPath}";
                            guna2PictureBox1.Load(imageUrl);
                        }
                        else
                        {
                            // Handle case when no poster is available
                            guna2PictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        txtmovietitle.Text = "No movies found for the selected genre this month.";
                    }
                }
                else
                {
                    txtmovietitle.Text = "Error fetching data.";
                }
            }
        }

        private string GetGenreForCurrentMonth()
        {
            int currentMonth = DateTime.Now.Month;

            switch (currentMonth)
            {
                case 1: return "12"; // January: Adventure
                case 2: return "14"; // February: Romance
                case 3: return "18"; // March: Drama
                case 4: return "35"; // April: Comedy
                case 5: return "10752"; // May: War
                case 6: return "80"; // June: Crime
                case 7: return "14"; // July: Fantasy
                case 8: return "36"; // August: History
                case 9: return "28"; // September: Action
                case 10: return "878"; // October: Sci-Fi
                case 11: return "27"; // November: Horror
                case 12: return "16"; // December: Animation
                default: return "18"; // Default to Drama for unknown months
            }
        }

        private string GetGenreForCurrentMonthName()
        {
            int currentMonth = DateTime.Now.Month;

            switch (currentMonth)
            {
                case 1: return "Adventure";
                case 2: return "Romance";
                case 3: return "Drama";
                case 4: return "Comedy";
                case 5: return "War";
                case 6: return "Crime";
                case 7: return "Fantasy";
                case 8: return "History";
                case 9: return "Action";
                case 10: return "Sci-Fi";
                case 11: return "Horror";
                case 12: return "Animation";
                default: return "Drama"; // Default to Drama for unknown months
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FetchAndDisplayTopMoviesAsync();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
