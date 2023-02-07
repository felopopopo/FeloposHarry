using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_HARRY_POTTER
{
    public partial class Form1 : Form
    {
        public string Equipo1;
        public string Equipo2;
        public int Puntaje1 = 0;
        public int Puntaje2 = 0;
        public string EquipoG = "G";
        public string EquipoH = "H";
        public string EquipoR = "R";
        public string EquipoS = "S";
        public int PartidosGanadosG;
        public int PartidosGanadosH;
        public int PartidosGanadosR;
        public int PartidosGanadosS;
        public string GanadorP;
        public string GanadorT;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void BtnSnitch1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 150;
            if (Puntaje1 > Puntaje2)
            {
                    if (Equipo1 == "G")
                    {
                        MessageBox.Show("El ganador del partido es Griffindor");
                        PartidosGanadosG += 1;
                    }
                    else if (Equipo1 == "H")
                    {
                        MessageBox.Show("El ganador del partido es Hufflepuff");
                        PartidosGanadosH += 1;
                    }
                    else if (Equipo1 == "R")
                    {
                        MessageBox.Show("El ganador del partido es Ravenclaw");
                        PartidosGanadosR += 1;
                    }
                    else if (Equipo1 == "S")
                    {
                        MessageBox.Show("El ganador del partido es Slytherin");
                        PartidosGanadosS += 1;
                    }
            }
            else if (Puntaje1 < Puntaje2)
            {
                if (Equipo2 == "G")
                {
                    MessageBox.Show("El ganador del partido es Griffindor");
                    PartidosGanadosG += 1;
                }
                else if (Equipo2 == "H")
                {
                    MessageBox.Show("El ganador del partido es Hufflepuff");
                    PartidosGanadosH += 1;
                }
                else if (Equipo2 == "R")
                {
                    MessageBox.Show("El ganador del partido es Ravenclaw");
                    PartidosGanadosR += 1;
                }
                else if (Equipo2 == "S")
                {
                    MessageBox.Show("El ganador del partido es Slytherin");
                    PartidosGanadosS += 1;
                }
            }
            else
            {
                MessageBox.Show("El resultado del partido fue un empate");
            }
            Puntaje1 = 0;
            Puntaje2 = 0;
            lblPuntaje1.Text = "0";
            lblPuntaje2.Text = "0";
        }

        private void BtnSnitch2_Click(object sender, EventArgs e)
        {
            Puntaje2 += 150;
            if (Puntaje2 > Puntaje1)
            {
                if (Equipo2 == "G")
                {
                    MessageBox.Show("El ganador del partido es Griffindor");
                    PartidosGanadosG += 1;
                }
                else if (Equipo2 == "H")
                {
                    MessageBox.Show("El ganador del partido es Hufflepuff");
                    PartidosGanadosH += 1;
                }
                else if (Equipo2 == "R")
                {
                    MessageBox.Show("El ganador del partido es Ravenclaw");
                    PartidosGanadosR += 1;
                }
                else if (Equipo2 == "S")
                {
                    MessageBox.Show("El ganador del partido es Slytherin");
                    PartidosGanadosS += 1;
                }
            }
            else if (Puntaje2 < Puntaje1)
            {
                if (Equipo1 == "G")
                {
                    MessageBox.Show("El ganador del partido es Griffindor");
                    PartidosGanadosG += 1;
                }
                else if (Equipo1 == "H")
                {
                    MessageBox.Show("El ganador del partido es Hufflepuff");
                    PartidosGanadosH += 1;
                }
                else if (Equipo1 == "R")
                {
                    MessageBox.Show("El ganador del partido es Ravenclaw");
                    PartidosGanadosR += 1;
                }
                else if (Equipo1 == "S")
                {
                    MessageBox.Show("El ganador del partido es Slytherin");
                    PartidosGanadosS += 1;
                }
            }
            else
            {
                MessageBox.Show("El resultado del partido fue un empate");
            }
            Puntaje1 = 0;
            Puntaje2 = 0;
            lblPuntaje1.Text = "0";
            lblPuntaje2.Text = "0";

        }

        private void TxtEq1_TextChanged(object sender, EventArgs e)
        {

                Equipo1 = txtEq1.Text;
        }

        private void TxtEq2_TextChanged(object sender, EventArgs e)
        {
                Equipo2 = txtEq2.Text;
        }

        private void BtnAnotacion1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 10;
            lblPuntaje1.Text = Convert.ToString(Puntaje1);
        }

        private void BtnAnotacion2_Click(object sender, EventArgs e)
        {
            Puntaje2 += 10;
            lblPuntaje2.Text = Convert.ToString(Puntaje2);

        }

        private void BtnFinTorneo_Click(object sender, EventArgs e)
        {
            if (PartidosGanadosG > PartidosGanadosH && PartidosGanadosG > PartidosGanadosR && PartidosGanadosG > PartidosGanadosS)
            {
                MessageBox.Show("Griffindor es el campeon del torneo");
            }
            else if (PartidosGanadosH > PartidosGanadosG && PartidosGanadosH > PartidosGanadosR && PartidosGanadosH > PartidosGanadosS)
            {
                MessageBox.Show("Hufflepuff es el campeon del torneo");
            }
            else if (PartidosGanadosR > PartidosGanadosG && PartidosGanadosR > PartidosGanadosH && PartidosGanadosR > PartidosGanadosS)
            {
                MessageBox.Show("Ravenclaw es el campeon del torneo");
            }
            else if (PartidosGanadosS > PartidosGanadosG && PartidosGanadosS > PartidosGanadosH && PartidosGanadosS > PartidosGanadosR)
            {
                MessageBox.Show("Slytherin es el campeon del torneo");
            }
            else
            {

                    if (PartidosGanadosG == PartidosGanadosH || PartidosGanadosG == PartidosGanadosR || PartidosGanadosG == PartidosGanadosS || PartidosGanadosH == PartidosGanadosR || PartidosGanadosH == PartidosGanadosS || PartidosGanadosR == PartidosGanadosS)
                    {
                        MessageBox.Show("El resultado del torneo fue un empate");
                        
                    }
                    else
                    {
                        
                    }
                
            }

                    PartidosGanadosG = 0;
                    PartidosGanadosH = 0;
                    PartidosGanadosR = 0;
                    PartidosGanadosS = 0;
        }
    }
}
