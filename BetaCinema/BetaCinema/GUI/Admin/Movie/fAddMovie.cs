using BetaCinema.DAO;
using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Movie
{
    public partial class fAddMovie : Form
    {
        public fAddMovie()
        {
            InitializeComponent();

            LoadGenre();
            LoadMovieRatingSystem();
        }

        void LoadGenre()
        {
            List<Genre> listGenre = GenreDAO.Instance.GetListGenre();
            foreach (Genre genre in listGenre)
            {
                clbGenre.Items.Add(genre.TenTheLoai);
            }
        }

        void LoadMovieRatingSystem()
        {
            List<MovieRatingSystem> listMovieRatingSystem = MovieRatingSystemDAO.Instance.GetListMovieRatingSystem();
            cboMovieRatingSystem.DataSource = listMovieRatingSystem;
            cboMovieRatingSystem.DisplayMember = "MaPl";
        }
    }
}
