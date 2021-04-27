﻿using Clases.ApiRest;
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

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://goweather.herokuapp.com/weather/"+txtEmail.Text+"");
            txtNombreGET.Text = respuesta.forecast[0].temperature.ToString();
            txtApellidoGET.Text = respuesta.forecast[0].wind.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox2.ImageLocation = respuesta.sprites.front_default.ToString();
            lblpokemon.Text = respuesta.forms[0].name.ToString();
            lblpoke.Text = respuesta.id.ToString();
            
        }

        private void btnJoke_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://rickandmortyapi.com/api/character/"+txtpoke.Text+"");
            pictureBox1.ImageLocation = respuesta.image.ToString();
            textBoxNombre.Text = respuesta.name.ToString();
            textBoxEstado.Text = respuesta.status.ToString();
            textBoxGenero.Text = respuesta.gender.ToString();
        }

        private void btnanimar_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://pokeapi.co/api/v2/pokemon/" + txtpokemon.Text + "");
            pictureBox2.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-v/black-white/animated/"+lblpoke.Text+".gif";
        }
    }

    public class Persona
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}

