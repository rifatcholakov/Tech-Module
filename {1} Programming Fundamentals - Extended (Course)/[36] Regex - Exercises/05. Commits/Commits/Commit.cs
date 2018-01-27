namespace Commits
{
    public class Commit
    {
        public string hash { get; set; }

        public string message { get; set; }

        public decimal additions { get; set; }

        public decimal deletions { get; set; }
    }
}
