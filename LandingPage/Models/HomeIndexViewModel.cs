namespace LandingPage.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Project>? Projects { get; set; }
        public int? number { get; set; }

        public void addNumber()
        {
            this.number += 1;
        }
        public void subtractNumber()
        {
            this.number -= 1;
        }
    }
};
