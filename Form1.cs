using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace howto_draw_normal_distribution
{
    public partial class Form1 : Form
    {
        Random ras = new Random(1);
        int[] results = new int[2];


        public Form1()
        {
            InitializeComponent();
            results = new int[tam];
            reset();
            // vlcControl1.Play(new Uri(@"E:\series\english\Family Comedy\The Big Bang Theory\The Big Bang Theory Season 1\The Big Bang Theory S01E01.mkv"));
        }
        public double calcula_gauss()
        {
            int iterations = 3,
            total = 0;
            for (int i = 0; i < iterations; i += 1)
            {
                total += ras.Next(0, tam);
            }
            double a = (total / iterations);
            int result = int.Parse(Math.Floor(a) + "");
            if (results[result] < 3)
                results[result] += 1;
            return result;
        }
        public void calcula_precent(float[] percent_)//arreglo ordenado de mayor a menor, contiene el porcentaje
        {
            double rand = rass.NextDouble();
            for (int i = 0; i < percent_.Length; i += 1)
            {
                if (rand < percent_[i])
                {
                    results[i] += 1;
                    return;
                    //return percent_[i];
                }
                rand -= percent_[i];
            }
            //return percent_[percent_.Length-1];
        }
        public double calcula_()
        {
            int iterations = 3,
            total = 0;
            for (int i = 0; i < iterations; i += 1)
            {
                total += ras.Next(0, tam);
            }
            double a = (total / iterations);
            int result = int.Parse(Math.Floor(a) + "");
            if (results[result] < 3)
                results[result] += 1;
            return result;
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            se();
            draww();
        }
        public void draw()
        {
            Bitmap bm = new Bitmap(picGraph.ClientSize.Width, picGraph.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Red, 0))
                {
                    using (Font font = new Font("Arial", 8))
                    {
                        pen.Color = Color.Black;
                        var w = this.Width / tam;
                        for (var i = 0; i < tam; i += 1)
                        {
                            var h = results[i] * 10;
                            if (h != 0)
                                gr.DrawRectangle(pen, i * 7, 0, 2, float.Parse(h + ""));
                        }
                    } // Font
                } // Pen

                picGraph.Image = bm;
            }
        }
        // The normal distribution function.
        private float F(float x, float one_over_2pi, float mean, float stddev, float var)
        {
            return (float)(one_over_2pi * Math.Exp(-(x - mean) * (x - mean) / (2 * var)));
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //calcula_gauss();
            //draw();
            se();
            draww();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //calcula_gauss();
            //draw();
        }


        int tam = 7;

        float[] results_chance = new float[] { 0.23f, 0.57f, 0.51f, 0.33f, 0.80f, 0.14f, 0.70f };
        Random rass = new Random();
        List<List<int>> series = new List<List<int>>();
        float duracion = 0;
        int limit = 2;//del arlgoritmo recursivo
        int vc = 8;//numero de veces que se puede repetir una serie antes de ser eleiminada o marcada como reproducida //si ya fue completamente reproducida
        float id_s = 0;
        public void se()
        {
            lserie.Text = "Serie";//
            double rand = rass.NextDouble();
            if (rand < 0.021573)
            {
                results[0] += 1;//
                lserie.Text = "Serie - pelicula";//
            }
            else
                calcular_siguiente_serie();
        }
        public void calcular_siguiente_serie()
        {
            if (series.Count == 0)
                reset();
            float duracion_total = 0;
            float duracion_mayor = 0;

            foreach (List<int> ls in series)
            {
                duracion_total += ls[1];
                if (ls[1] > duracion_mayor)
                    duracion_mayor = ls[1];
            }
            sm.Text = "Mayor duracion S " + duracion_mayor;//
            st.Text = "Total duracion: " + duracion_total;//
            ns.Text = "N: " + series.Count;//
            //primera busqueda con filtro de 2 para que exista dispercion
            double rand = rass.NextDouble();
            tbrandom.Text = rand + "";//
            for (var i = 0; i < series.Count; i += 1)
            {
                List<int> ls = series[i];
                if (ls[2] < limit)
                {
                    float p = (ls[1] / (duracion_mayor + (duracion_total / series.Count)));
                    if (rand < p)
                    {
                        lserie.Text = "Serie - Se calculo otra " + ls[0];//
                        id_s = ls[0];
                        duracion = ls[1];
                        ls[2] += 1;
                        int b = (int)Math.Floor(10-(duracion_mayor_absoluto / ls[1]));
                        label1.Text = b + " - " + ls[2];
                        if (ls[2] > b) {
                            series.Remove(ls);
                            label1.Text = "E"+ ls[0];
                        }
                           
                        return;
                    }
                    rand -= p;
                }
            }
            limit = limit + 2;
            calcular_siguiente_serie();
        }


        public void reset()
        {
            series.Add(new List<int>() { 36, 199419, 0 });
            series.Add(new List<int>() { 28, 157841, 0 });
            series.Add(new List<int>() { 27, 142412, 0 });
            series.Add(new List<int>() { 29, 91381, 0 });
            series.Add(new List<int>() { 37, 90968, 0 });
            series.Add(new List<int>() { 30, 90321, 0 });
            series.Add(new List<int>() { 26, 80842, 0 });
            series.Add(new List<int>() { 35, 75497, 0 });
            series.Add(new List<int>() { 32, 74867, 0 });
            series.Add(new List<int>() { 34, 55090, 0 });
            series.Add(new List<int>() { 31, 32089, 0 });
            series.Add(new List<int>() { 33, 12105, 0 });
            limit = 2;
            duracion_mayor_absoluto = 0;
            series_draw.Clear();
            foreach (List<int> ls in series)
            {
                series_draw.Add(new List<int>() { ls[0],0 });
                if (ls[1] > duracion_mayor_absoluto)
                    duracion_mayor_absoluto = ls[1];
            }
        }
        List<List<int>> series_draw = new List<List<int>>();
        float duracion_mayor_absoluto;
        public void draww()
        {
            {
                //Pelicula
                Bitmap bm = new Bitmap(picGraph.ClientSize.Width, picGraph.ClientSize.Height);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.Red, 0))
                    {
                        using (Font font = new Font("Arial", 8))
                        {
                            pen.Color = Color.Black;
                            var w = this.Width / tam;

                            for (var i = 0; i < tam; i += 1)
                            {
                                var h = results[i] * 10;
                                if (h != 0)
                                {
                                    id_s = 0;
                                    gr.DrawRectangle(pen, i * 7, 0, 2, float.Parse(h + ""));
                                }

                            }
                        } // Font
                    } // Pen
                    picGraph.Image = bm;
                }
            }
            {
                //serie
                Bitmap bm = new Bitmap(picGraph.ClientSize.Width, picGraph.ClientSize.Height);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.Red, 0))
                    {
                        using (Font font = new Font("Arial", 8))
                        {
                            pen.Color = Color.Black;
                            var w = this.Width / tam;

                            for (var i = 0; i < series.Count; i += 1)
                                foreach (List<int> ls in series_draw)
                                {
                                    if (ls[0] == series[i][0]) {
                                        ls[1] = series[i][2];
                                    }
                                }

                            for (var i = 0; i < series_draw.Count; i += 1)
                            {
                                List<int> ls = series_draw[i];
                                var h = ls[1] * 10;
                                if (h != 0)
                                    gr.DrawRectangle(pen, i * 7, 0, 2, float.Parse(h + ""));
                            }

                        } // Font
                    } // Pen
                    picGraph2.Image = bm;
                }
            }
        }


    }
}
