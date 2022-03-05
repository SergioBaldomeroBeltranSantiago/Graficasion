using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficasion
{
    public partial class Graficasionador : Form
    {
        public Graficasionador()
        {
            InitializeComponent();
        }

        private void Graficasionador_Paint(object sender, PaintEventArgs e)
        {
            Graphics objeto_grafico = e.Graphics;
            Font objeto_fuete = new Font("Arial", 16);
            Pen objeto_pluma = new Pen(Color.Green, 1);
            SolidBrush objeto_brocha = new SolidBrush(Color.Green);

            //Dibujo usando el algoritmo de lineas de Bresenham
            drawStardewValleyDinosaur(objeto_grafico);
            
        }

        public void lineaBresenham(Graphics objeto_grafico, Color c, int x1, int y1, int x2, int y2) {
            if (x1 > x2) {
                lineaBresenham(objeto_grafico, c, x2, y2, x1, y1);
                return;
            }
            int slope, d;
            int dx = x2 - x1, dy = y2 - y1, y = y1;
            if (dy < 0)
            {
                slope = -1;
                dy *= -1;
            }
            else {
                slope = 1;
            }
            int incE = 2 * dy;
            int incNE = (2 * dy) - (2 * dx);
            d = (2 * dy) - dx;

            for (int x = x1; x <= x2; x++) {
                putPixel(objeto_grafico, x, y, c);
                if (d <= 0)
                {
                    d += incE;
                }
                else {
                    d += incNE;
                    y += slope;
                }
            }
        }

        public void putPixel(Graphics objeto_grafico, int x, int y, Color c) {
            Bitmap objeto_bitmap = new Bitmap(1, 1);
            objeto_bitmap.SetPixel(0, 0, c);
            objeto_grafico.DrawImageUnscaled(objeto_bitmap, x, y);
        }

        public void bresenhamPorTres(Graphics objeto_grafico, Color c, int x1, int y1, int x2, int y2) {
            x1 *= 1;
            x2 = (x2 * 1) + 0;
            y1 *= 1;
            y2 *= 1;
            for (int i = 0; i < 1; i++) {
                lineaBresenham(objeto_grafico, c, x1, y1 + i, x2, y2 + i);
            }

        }

        public void drawStardewValleyDinosaur(Graphics objeto_grafico) {

            //(255, 32, 38, 6) Darkest Green
            Color DarkestGreen = Color.FromArgb(255, 32, 38, 6);
            //(255, 158,176, 9) Lightest Green
            Color LighestGreen = Color.FromArgb(255, 158, 176, 9);
            //(255, 84, 91, 4) Semi Dark Green
            Color SemiDarkGreen = Color.FromArgb(255, 84, 91, 4);
            //(255, 183, 67, 29) Orange
            Color Orangeish = Color.FromArgb(255, 183, 67, 29);
            //(255, 62, 31, 13) Brown
            Color Brownish = Color.FromArgb(255, 62, 31, 13);
            //(255, 204, 224, 132) Eye
            Color Eye = Color.FromArgb(255, 204, 224, 132);
            //(255, 193, 196, 47) Yellow-ish Green
            Color YellowishGreen = Color.FromArgb(255, 193, 196, 47);
            //(255, 255, 240, 56) Yellow
            Color Yellowish = Color.FromArgb(255, 255, 240, 56);
            //(255, 255, 131, 0) YellowOrange
            Color YellowOrange = Color.FromArgb(255, 255, 131, 0);

            //y=0
            bresenhamPorTres(objeto_grafico, Brownish, 6, 0, 6, 0);
            //y=1
            bresenhamPorTres(objeto_grafico, Brownish, 5, 1, 5, 1);
            bresenhamPorTres(objeto_grafico, Orangeish, 6, 1, 6, 1);
            bresenhamPorTres(objeto_grafico, Brownish, 7, 1, 7, 1);
            bresenhamPorTres(objeto_grafico, Brownish, 10, 1, 11, 1);
            //y=2
            bresenhamPorTres(objeto_grafico, Brownish, 1, 2, 2, 2);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 5, 2, 5, 2);
            bresenhamPorTres(objeto_grafico, LighestGreen, 6, 2, 6, 2);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 7, 2, 7, 2);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 9, 2, 9, 2);
            bresenhamPorTres(objeto_grafico, Orangeish, 10, 2, 10, 2);
            bresenhamPorTres(objeto_grafico, Brownish, 11, 2, 11, 2);
            //y=3
            bresenhamPorTres(objeto_grafico, Brownish, 1, 3, 1, 3);
            bresenhamPorTres(objeto_grafico, Orangeish, 2, 3, 2, 3);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 3, 3, 4, 3);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 5, 3, 5, 3);
            bresenhamPorTres(objeto_grafico, LighestGreen, 6, 3, 6, 3);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 7, 3, 7, 3);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 8, 3, 8, 3);
            bresenhamPorTres(objeto_grafico, LighestGreen, 9, 3, 9, 3);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 10, 3, 10, 3);
            bresenhamPorTres(objeto_grafico, Brownish, 12, 3, 13, 3);
            //y=4
            bresenhamPorTres(objeto_grafico, DarkestGreen, 2, 4, 2, 4);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 3, 4, 3, 4);
            bresenhamPorTres(objeto_grafico, LighestGreen, 4, 4, 7, 4);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 8, 4, 8, 4);
            bresenhamPorTres(objeto_grafico, LighestGreen, 9, 4, 9, 4);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 10, 4, 10, 4);
            bresenhamPorTres(objeto_grafico, Brownish, 11, 4, 11, 4);
            bresenhamPorTres(objeto_grafico, Orangeish, 12, 4, 12, 4);
            bresenhamPorTres(objeto_grafico, YellowOrange, 13, 4, 13, 4);
            bresenhamPorTres(objeto_grafico, Brownish, 14, 4, 14, 4);
            //y=5
            bresenhamPorTres(objeto_grafico, DarkestGreen, 1, 5, 1, 5);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 2, 5, 2, 5);
            bresenhamPorTres(objeto_grafico, LighestGreen, 3, 5, 4, 5);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 5, 5, 5, 5);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 6, 5, 6, 5);
            bresenhamPorTres(objeto_grafico, LighestGreen, 7, 5, 10, 5);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 11, 5, 11, 5);
            bresenhamPorTres(objeto_grafico, LighestGreen, 12, 5, 12, 5);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 13, 5, 13, 5);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 14, 5, 14, 5);
            //y=6
            bresenhamPorTres(objeto_grafico, DarkestGreen, 0, 6, 0, 6);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 1, 6, 2, 6);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 3, 6, 3, 6);
            bresenhamPorTres(objeto_grafico, LighestGreen, 4, 6, 7, 6);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 8, 6, 8, 6);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 9, 6, 9, 6);
            bresenhamPorTres(objeto_grafico, LighestGreen, 10, 6, 12, 6);
            bresenhamPorTres(objeto_grafico, Eye, 13, 6, 13, 6);
            bresenhamPorTres(objeto_grafico, LighestGreen, 14, 6, 14, 6);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 15, 6, 15, 6);
            //y=7
            bresenhamPorTres(objeto_grafico, DarkestGreen, 0, 7, 0, 7);
            bresenhamPorTres(objeto_grafico, LighestGreen, 1, 7, 1, 7);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 2, 7, 2, 7);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 3, 7, 3, 7);
            bresenhamPorTres(objeto_grafico, LighestGreen, 4, 7, 12, 7);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 13, 7, 13, 7);
            bresenhamPorTres(objeto_grafico, LighestGreen, 14, 7, 14, 7);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 15, 7, 15, 7);
            //y=8
            bresenhamPorTres(objeto_grafico, DarkestGreen, 0, 8, 0, 8);
            bresenhamPorTres(objeto_grafico, LighestGreen, 1, 8, 1, 8);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 2, 8, 2, 8);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 3, 8, 3, 8);
            bresenhamPorTres(objeto_grafico, LighestGreen, 4, 8, 5, 8);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 6, 8, 6, 8);
            bresenhamPorTres(objeto_grafico, LighestGreen, 7, 8, 7, 8);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 8, 8, 8, 8);
            bresenhamPorTres(objeto_grafico, LighestGreen, 9, 8, 10, 8);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 11, 8, 11, 8);
            bresenhamPorTres(objeto_grafico, LighestGreen, 12, 8, 14, 8);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 15, 8, 15, 8);
            //y=9
            bresenhamPorTres(objeto_grafico, DarkestGreen, 0, 9, 0, 9);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 1, 9, 1, 9);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 2, 9, 2, 9);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 3, 9, 4, 9);
            bresenhamPorTres(objeto_grafico, LighestGreen, 5, 9, 5, 9);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 6, 9, 6, 9);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 7, 9, 7, 9);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 8, 9, 8, 9);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 9, 9, 9, 9);
            bresenhamPorTres(objeto_grafico, LighestGreen, 10, 9, 10, 9);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 11, 9, 12, 9);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 13, 9, 14, 9);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 15, 9, 15, 9);
            //y=10
            bresenhamPorTres(objeto_grafico, DarkestGreen, 1, 10, 1, 10);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 3, 10, 3, 10);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 4, 10, 5, 10);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 6, 10, 8, 10);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 9, 10, 10, 10);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 11, 10, 11, 10);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 13, 10, 14, 10);
            //y=11
            bresenhamPorTres(objeto_grafico, DarkestGreen, 3, 11, 3, 11);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 4, 11, 4, 11);
            bresenhamPorTres(objeto_grafico, YellowishGreen, 5, 11, 5, 11);
            bresenhamPorTres(objeto_grafico, Yellowish, 6, 11, 6, 11);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 7, 11, 8, 11);
            bresenhamPorTres(objeto_grafico, SemiDarkGreen, 9, 11, 9, 11);
            bresenhamPorTres(objeto_grafico, YellowishGreen, 10, 11, 10, 11);
            bresenhamPorTres(objeto_grafico, Yellowish, 11, 11, 11, 11);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 12, 11, 12, 11);
            //y=12
            bresenhamPorTres(objeto_grafico, DarkestGreen, 4, 12, 6, 12);
            bresenhamPorTres(objeto_grafico, DarkestGreen, 9, 12, 11, 12);

        }

    }
}
