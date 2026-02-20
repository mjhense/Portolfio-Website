using Portfolio_Website.Models;

namespace Portfolio_Website.Data
{
    public class PortfolioService
    {
        private List<PortfolioPiece> portfolioPieces;
        private List<PortfolioPiece> highlightPieces;

        public PortfolioService()
        {
            portfolioPieces = new List<PortfolioPiece>();
            highlightPieces = new List<PortfolioPiece>();

            // Load sample data for demonstration purposes
            // Remove this in production and implement proper data loading/saving logic
            LoadSampleData();
            foreach (var piece in portfolioPieces)
            {
                piece.Images.Add("images/render.png");
            }
            foreach (var piece in highlightPieces)
            {
                for (int i = 0; i < 3; i++)
                {
                    piece.Images.Add("images/cake_render.png");
                }
                piece.Images.Add("images/render.png");
            }
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

        public PortfolioPiece? GetPortfolioPieceById(string id)
        {
            return portfolioPieces.FirstOrDefault(p => p.ID == id);
        }

        public void ClearPortfolio()
        {
            portfolioPieces.Clear();
        }
        #endregion
        #region Highlight Management Methods
        public List<PortfolioPiece> GetHighlightPieces()
        {
            return highlightPieces;
        }

        public void AddHighlightPiece(PortfolioPiece piece)
        {
            portfolioPieces.Add(piece);
        }

        public void RemoveHighlightPiece(PortfolioPiece piece)
        {
            portfolioPieces.Remove(piece);
        }

        public void UpdateHighlightPiece(PortfolioPiece oldPiece, PortfolioPiece newPiece)
        {
            int index = portfolioPieces.IndexOf(oldPiece);
            if (index != -1)
            {
                portfolioPieces[index] = newPiece;
            }
        }

        public void ClearHighlights()
        {
            portfolioPieces.Clear();
        }

        public PortfolioPiece? GetHighlightPieceById(string id)
        {
            return highlightPieces.FirstOrDefault(p => p.ID == id);
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
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet,dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd "
                },

                new PortfolioPiece
                {
                    Title = "Abandoned Facility",
                    Category = "Environment",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Sci-Fi Weapon",
                    Category = "Game Asset",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Creature Sculpt",
                    Category = "ZBrush Sculpt",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Cyberpunk Character",
                    Category = "Character Art",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Abandoned Facility",
                    Category = "Environment",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Sci-Fi Weapon",
                    Category = "Game Asset",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Creature Sculpt",
                    Category = "ZBrush Sculpt",
                    ID = "this.Title",
                    Description = "Lorem ipsum dolor sit amet, "
                }
            };
            highlightPieces = new List<PortfolioPiece>
            {
                new PortfolioPiece
                {
                    Title = "Kaprosuchus",
                    Category = "Model & Rig",
                    ID = "Kaprosuchus",
                    Description = "Lorem ipsum dolor sit amet, dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"
                },

                new PortfolioPiece
                {
                    Title = "Ocean Environment",
                    Category = "Environment",
                    ID = "Ocean-Environment",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Pastel Cake",
                    Category = "Game Asset",
                    ID = "Patel Cake",
                    Description = "Lorem ipsum dolor sit amet, "
                },

                new PortfolioPiece
                {
                    Title = "Creature Sculpt",
                    Category = "ZBrush Sculpt",
                    ID = "Creature Sculpt",
                    Description = "Lorem ipsum dolor sit amet, "
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