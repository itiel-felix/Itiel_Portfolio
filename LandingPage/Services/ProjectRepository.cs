using LandingPage.Models;

namespace LandingPage.Services
{
    public interface IProjectRepository
    {
        List<Project> generateProjects();
    }
    public class ProjectRepository : IProjectRepository
    {
        public List<Project> generateProjects()
        {
            return new List<Project>()
            {
                new Project()
                {
                    title = "21 Blackjack",
                    description = "Android application of a 21 Blackjack game using Jetpack Compose in Android Studio. Implement" +
                    "SQLite Dtabase to generate persistant data about played games. Compatible with Android 7.0+.",
                    imageLocation="/images/blackjack.png",
                    projectUrl= "https://github.com/itiel-felix/21-blackjack-kotlin-compose"
                },
                new Project()
                {
                    title = "Periodic Table",
                    description = "Android application with the first 50 elements in the periodic table"+
                    " using Jetpack Compose in Android Studio. Compatible with Android 7.0+.",
                    imageLocation="/images/periodic.png",
                    projectUrl="https://github.com/itiel-felix/Periodic-table-Android"

                },

                new Project()
                {
                    title = "Game List with API Consume",
                    description = "Android application with Retrofit implementation to consume freeToGames API. Compatible with Android 7.0+.",
                    imageLocation="/images/games.png",
                    projectUrl="https://github.com/itiel-felix/Game-List-Retrofit"

                },
            };
        }
    }
}
