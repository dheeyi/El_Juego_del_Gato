using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;


namespace Tresenraya
{
    [Activity(Label = "Tresenraya", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TextView tvTitulo, tv_jugar;
        private Button bt_jugar;
        private byte[,] M = new byte[,] { {3,4,5}, {6,7,8}, {9,10,11} };
        private int jugador = 1,empate=0;
        #region declarando Imagenes
        private ImageView iv_1;
        private ImageView iv_2;
        private ImageView iv_3;
        private ImageView iv_4;
        private ImageView iv_5;
        private ImageView iv_6;
        private ImageView iv_7;
        private ImageView iv_8;
        private ImageView iv_9;
        #endregion
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Typeface font = Typeface.CreateFromAsset(Application.Context.Assets, "gloriahallelujah.ttf");
            #region inicializando Imagenes
            iv_1 = FindViewById<ImageView>(Resource.Id.imageV_uno);
            iv_2 = FindViewById<ImageView>(Resource.Id.imageV_dos);
            iv_3 = FindViewById<ImageView>(Resource.Id.imageV_tres);
            iv_4 = FindViewById<ImageView>(Resource.Id.imageV_cuatro);
            iv_5 = FindViewById<ImageView>(Resource.Id.imageV_cinco);
            iv_6 = FindViewById<ImageView>(Resource.Id.imageV_seis);
            iv_7 = FindViewById<ImageView>(Resource.Id.imageV_siete);
            iv_8 = FindViewById<ImageView>(Resource.Id.imageV_ocho);
            iv_9 = FindViewById<ImageView>(Resource.Id.imageV_nueve);
            #endregion

            tvTitulo = FindViewById<TextView>(Resource.Id.tv_titulo);
            tv_jugar = FindViewById<TextView>(Resource.Id.tv_jugador);            
            tvTitulo.SetTypeface(font, TypefaceStyle.Bold);
            tv_jugar.SetTypeface(font, TypefaceStyle.Bold);
            bt_jugar = FindViewById<Button>(Resource.Id.bt_jugar);
            bt_jugar.SetTypeface(font, TypefaceStyle.Bold);
            bt_jugar.Click += new EventHandler(bt_jugar_Click);

            #region eventos Imagenes
            iv_1.Click += iv_1_Click;
            iv_2.Click += iv_2_Click;
            iv_3.Click += iv_3_Click;
            iv_4.Click += iv_4_Click;
            iv_5.Click += iv_5_Click;
            iv_6.Click += iv_6_Click;
            iv_7.Click += iv_7_Click;
            iv_8.Click += iv_8_Click;
            iv_9.Click += iv_9_Click;
            #endregion
        }

        void bt_jugar_Click(object sender, EventArgs e)
        {
            EnableAllTrue();
            iv_1.SetImageResource(Resource.Drawable.a);
            iv_2.SetImageResource(Resource.Drawable.a);
            iv_3.SetImageResource(Resource.Drawable.a);
            iv_4.SetImageResource(Resource.Drawable.a);
            iv_5.SetImageResource(Resource.Drawable.a);
            iv_6.SetImageResource(Resource.Drawable.a);
            iv_7.SetImageResource(Resource.Drawable.a);
            iv_8.SetImageResource(Resource.Drawable.a);
            iv_9.SetImageResource(Resource.Drawable.a);
            tv_jugar.Text = "Empiece a jugar de Nuevo";
            jugador = 1;
            M[0, 0] = 3; M[0, 1] =4; M[0, 2] = 5;
            M[1, 0] = 6; M[1, 1] = 7; M[1, 2] = 8;
            M[2, 0] = 9; M[2, 1] = 10; M[2, 2] = 11;
            empate = 0;
            bt_jugar.Visibility = ViewStates.Invisible;
        }
        
        void iv_9_Click(object sender, EventArgs e)
        {
            if (jugador % 2 == 0)
            {
                iv_9.SetImageResource(Resource.Drawable.o);
                M[2, 2] = 1;
            }
            else
            {
                iv_9.SetImageResource(Resource.Drawable.x);
                M[2, 2] = 2;
            }
            jugador++;
            iv_9.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_8_Click(object sender, EventArgs e)
        {
            if (jugador % 2 == 0)
            {
                iv_8.SetImageResource(Resource.Drawable.o);
                M[2, 1] = 1;
            }
            else
            {
                iv_8.SetImageResource(Resource.Drawable.x);
                M[2, 1] = 2;
            }
            jugador++;
            iv_8.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_7_Click(object sender, EventArgs e)
        {
            if (jugador % 2 == 0)
            {
                iv_7.SetImageResource(Resource.Drawable.o);
                M[2, 0] = 1;
            }
            else
            {
                iv_7.SetImageResource(Resource.Drawable.x);
                M[2, 0] = 2;
            }
            jugador++;
            iv_7.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_6_Click(object sender, EventArgs e)
        {
            if (jugador % 2 == 0)
            {
                iv_6.SetImageResource(Resource.Drawable.o);
                M[1, 2] = 1;
            }
            else
            {
                iv_6.SetImageResource(Resource.Drawable.x);
                M[1, 2] = 2;
            }
            jugador++;
            iv_6.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_5_Click(object sender, EventArgs e)
        {
            if (jugador % 2 == 0)
            {
                iv_5.SetImageResource(Resource.Drawable.o);
                M[1, 1] = 1;
            }
            else
            {
                iv_5.SetImageResource(Resource.Drawable.x);
                M[1, 1] = 2;
            }
            jugador++;
            iv_5.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_4_Click(object sender, EventArgs e){
            if (jugador % 2 == 0)
            {
                iv_4.SetImageResource(Resource.Drawable.o);
                M[1, 0] = 1;
            }
            else
            {
                iv_4.SetImageResource(Resource.Drawable.x);
                M[1, 0] = 2;
            }
            jugador++;
            iv_4.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_3_Click(object sender, EventArgs e){
            if (jugador % 2 == 0)
            {
                iv_3.SetImageResource(Resource.Drawable.o);
                M[0, 2] = 1;
            }
            else
            {
                iv_3.SetImageResource(Resource.Drawable.x);
                M[0, 2] = 2;
            }
            jugador++;
            iv_3.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_2_Click(object sender, EventArgs e){
            if (jugador % 2 == 0)
            {
                iv_2.SetImageResource(Resource.Drawable.o);
                M[0, 1] = 1;
            }
            else
            {
                iv_2.SetImageResource(Resource.Drawable.x);
                M[0, 1] = 2;
            }
            jugador++;
            iv_2.Enabled = false;
            if (Verifica() != 0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        void iv_1_Click(object sender, EventArgs e){
            if(jugador%2==0)
            {
                iv_1.SetImageResource(Resource.Drawable.o);
                M[0, 0] = 1;
            }
            else
            {
                iv_1.SetImageResource(Resource.Drawable.x);
                M[0, 0] = 2;
            }
            jugador++;
            iv_1.Enabled = false;
            if(Verifica()!=0)
            {
                tv_jugar.Text = "Gano el Jugador : " + Verifica() + ",";
                EnableAll();
                this.bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;
            }
            empate++;
            Empate();
        }

        public byte Verifica()
        {
            for (int i = 0; i < this.M.GetLength(0); i++)
            {
                if (this.M[i, 0] == this.M[i, 1] && this.M[i, 1] == this.M[i, 2])
                {
                    return this.M[i, 0];
                }
                if (this.M[0, i] == this.M[1, i] && this.M[1, i] == this.M[2, i])
                {
                    return this.M[0, i];
                }
            }
            if (this.M[0, 0] == this.M[1, 1] && this.M[1, 1] == this.M[2, 2])
            {
                return this.M[0, 0];
            }
            if (this.M[2, 0] == this.M[1, 1] && this.M[1, 1] == this.M[0, 2])
            {
                return this.M[2, 0];
            }
            return 0;
        }
        
        public void EnableAll()
        {
            iv_1.Enabled = false;
            iv_2.Enabled = false;
            iv_3.Enabled = false;
            iv_4.Enabled = false;
            iv_5.Enabled = false;
            iv_6.Enabled = false;
            iv_7.Enabled = false;
            iv_8.Enabled = false;
            iv_9.Enabled = false;
        }
        
        public void EnableAllTrue()
        {
            iv_1.Enabled = true;
            iv_2.Enabled = true;
            iv_3.Enabled = true;
            iv_4.Enabled = true;
            iv_5.Enabled = true;
            iv_6.Enabled = true;
            iv_7.Enabled = true;
            iv_8.Enabled = true;
            iv_9.Enabled = true;
        }

        public void Empate()
        {   
            if(empate==9)
            {
                tv_jugar.Text = "Fue un Empate !!!";
                bt_jugar.Visibility = ViewStates.Visible;
                empate = 0;                
            }
        }
        
    }
}

