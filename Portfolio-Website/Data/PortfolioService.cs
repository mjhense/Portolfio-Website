using Portfolio_Website.Models;

namespace Portfolio_Website.Data
{
    public class PortfolioService
    {
        private List<PortfolioPiece> portfolioPieces;

        public PortfolioService()
        {
            portfolioPieces = new List<PortfolioPiece>();

            // Load sample data for demonstration purposes
            // Remove this in production and implement proper data loading/saving logic
            LoadSampleData();
        }

        #region Portfolio Management Methods
        public List<PortfolioPiece> GetPortfolio()
        {
            return portfolioPieces;
        }

        public void AddPortfolioPiece(PortfolioPiece piece)
        {
            portfolioPieces.Add(piece);
        }

        public void RemovePortfolioPiece(PortfolioPiece piece)
        {
            portfolioPieces.Remove(piece);
        }

        public void UpdatePortfolioPiece(PortfolioPiece oldPiece, PortfolioPiece newPiece)
        {
            int index = portfolioPieces.IndexOf(oldPiece);
            if (index != -1)
            {
                portfolioPieces[index] = newPiece;
            }
        }

        public void ClearPortfolio()
        {
            portfolioPieces.Clear();
        }
        #endregion

        public void LoadSampleData()
        {
            portfolioPieces = new List<PortfolioPiece>
            {
                new PortfolioPiece
                {
                    Title = "Cyberpunk Character",
                    Category = "Character Art",
                    Image = "icon-192.png"
                },

                new PortfolioPiece
                {
                    Title = "Abandoned Facility",
                    Category = "Environment",
                    Image = "images/work2.jpg"
                },

                new PortfolioPiece
                {
                    Title = "Sci-Fi Weapon",
                    Category = "Game Asset",
                    Image = "images/work3.jpg"
                },

                new PortfolioPiece
                {
                    Title = "Creature Sculpt",
                    Category = "ZBrush Sculpt",
                    Image = "images/work4.jpg"
                }
            };
        }

        #region Loading and Saving Methods
        public void SavePortfolio()
        {
            // Implement logic to save portfolio data to a file or database
        }

        public void LoadPortfolio()
        {
            // Implement logic to load portfolio data from a file or database
        }
        #endregion
    }
}