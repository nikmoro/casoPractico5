using Clases.ApiRest;
using System;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que consume la API del clima
        /// </summary>
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://goweather.herokuapp.com/weather/" + txtEmail.Text + "");
            txtNombreGET.Text = respuesta.forecast[0].temperature.ToString();
            txtApellidoGET.Text = respuesta.forecast[0].wind.ToString();
        }

        /// <summary>
        /// Método que consume la API de Pokémon
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox2.ImageLocation = respuesta.sprites.front_default.ToString();
            lblpokemon.Text = respuesta.forms[0].name.ToString();
            lblpoke.Text = respuesta.id.ToString();
        }

        /// <summary>
        /// Botón que anima el pokémon
        /// </summary>
        private void btnanimar_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox2.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-v/black-white/animated/" + lblpoke.Text + ".gif";
        }

        /// <summary>
        /// Método que consume la API de Rick y Morty
        /// </summary>
        private void btnJoke_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://rickandmortyapi.com/api/character/" + txtpoke.Text + "");
            pictureBox1.ImageLocation = respuesta.image.ToString();
            textBoxNombre.Text = respuesta.name.ToString();
            textBoxEstado.Text = respuesta.status.ToString();
            textBoxGenero.Text = respuesta.gender.ToString();
        }
    }
}