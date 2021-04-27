using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://goweather.herokuapp.com/weather/"+txtEmail.Text+"");
            //pictureBox1.ImageLocation = respuesta.data[1].avatar.ToString();
            txtNombreGET.Text = respuesta.forecast[0].temperature.ToString();
            txtApellidoGET.Text = respuesta.forecast[0].wind.ToString();
            //txtEmail.Text = respuesta.data[1].email.ToString();

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                job = txtTrabajador.Text,
                name = txtNombresPost.Text
            };

            string json = JsonConvert.SerializeObject(persona);

            dynamic respuesta = dBApi.Post("https://reqres.in/api/users",json);

            MessageBox.Show(respuesta.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox1.ImageLocation = respuesta.sprites.front_default.ToString();
            lblpokemon.Text = respuesta.forms[0].name.ToString();
            lblpoke.Text = respuesta.id.ToString();
            
        }

        private void btnJoke_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://rickandmortyapi.com/api/character/"+txtpoke.Text+"");
            pictureBox1.ImageLocation = respuesta.image.ToString();
            lblnombre.Text = respuesta.name.ToString();
            lblstatus.Text = respuesta.status.ToString();
            lblgenre.Text = respuesta.gender.ToString();
        }

        private void btnanimar_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox1.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-v/black-white/animated/"+lblpoke.Text+".gif";
        }
    }

    public class Persona
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}

