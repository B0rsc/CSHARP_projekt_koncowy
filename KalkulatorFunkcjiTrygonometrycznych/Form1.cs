using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorFunkcjiTrygonometrycznych
{
    public partial class Form1 : Form
    {

        Data data = new Data();
        public Form1()
        {
            InitializeComponent();

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {

            Validation();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Validation()
        {



            string value = textBox_value.Text;


            int check = 0;
            try
            {




                for (int x = 0; x < value.Length; x++)

                {

                    bool znakiFunkcja = char.IsNumber(value, x);

                    if (znakiFunkcja == false)
                    {
                        throw new Exception("Niepoprawne znaki");





                    }
                }



                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    MessageBox.Show("Wpisz wartość kąta");
                    value = "0";

                    float value1 = float.Parse(value);

                }
                else if (radioButton_cosinus.Checked == true || radioButton_cotangens.Checked == true || radioButton_sinus.Checked == true || radioButton_tangens.Checked == true)
                {



                    if (radioButton_cosinus.Checked)
                    {

                        check = 1;


                    }
                    else if (radioButton_sinus.Checked)
                    {

                        check = 2;



                    }
                    else if (radioButton_cotangens.Checked)
                    {



                        check = 3;

                    }
                    else if (radioButton_tangens.Checked)
                    {


                        check = 4;


                    }

                    switch (check)
                    {
                        case 1:
                            Cosinus();
                            break;

                        case 2:
                            Sinus();
                            break;

                        case 3:
                            Cotangens();
                            break;

                        case 4:
                            Tangens();
                            break;


                    }


                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);


            }


        }


        private void Tangens()
        {
            string value = textBox_value.Text;

            float value1 = float.Parse(value);

            if (value1 > 360)
            {

                MessageBox.Show("Kąt nie może być większy niż 360 stopni");

            } else
            {
                double radiany = (Math.PI / 180) * value1;

                double wynik = Math.Tan(radiany);

                string wynik_text = wynik.ToString();

                textBox_result.Text = wynik_text;
                Data.textbox_value_trygonometryczne = wynik_text;
            }


        }


        private void Cosinus()
        {
            string value = textBox_value.Text;

            float value1 = float.Parse(value);
            if (value1 > 360)
            {

                MessageBox.Show("Kąt nie może być większy niż 360 stopni");

            } else
            {

                double radiany = (Math.PI / 180) * value1;

                double wynik = Math.Cos(radiany);

                string wynik_text = wynik.ToString();

                textBox_result.Text = wynik_text;
                Data.textbox_value_trygonometryczne = wynik_text;
            }


        }

        private void Sinus()
        {
            string value = textBox_value.Text;

            float value1 = float.Parse(value);

            if (value1 > 360)
            {

                MessageBox.Show("Kąt nie może być większy niż 360 stopni");

            } else
            {

                double radiany = (Math.PI / 180) * value1;

                double wynik = Math.Sin(radiany);

                string wynik_text = wynik.ToString();

                textBox_result.Text = wynik_text;
                Data.textbox_value_trygonometryczne = wynik_text;
            }

        }

        private void Cotangens()
        {
            string value = textBox_value.Text;

            float value1 = float.Parse(value);

            if (value1 > 360)
            {

                MessageBox.Show("Kąt nie może być większy niż 360 stopni");

            } else
            {

                double radiany = (Math.PI / 180) * value1;

                double wynik = 1 / (Math.Tan(radiany));

                string wynik_text = wynik.ToString();

                textBox_result.Text = wynik_text;
                Data.textbox_value_trygonometryczne = wynik_text;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string A_check = textBox_A.Text;

            string X_check = textBox_X.Text;

            if (string.IsNullOrWhiteSpace(A_check) == true)
            {

                MessageBox.Show("Wpisz wartość a");


            }
            else if (string.IsNullOrWhiteSpace(X_check) == true)
            {

                MessageBox.Show("Wpisz wartość x");

            }
            else
            {


                funkcja_liniowa();
            }

        }


        private void funkcja_liniowa()
        {
            try
            {
                string A = textBox_A.Text;
                float A1 = float.Parse(A);

                string B = textBox_B.Text;
                float B1;

                string X = textBox_X.Text;
                float X1 = float.Parse(X);

                double wynik;

                string B_check = textBox_B.Text;

                string walidacja = X + B + A;


                  for (int i = 0; i < walidacja.Length; i++)

                    {

                        bool funkcja_znakil = char.IsNumber(walidacja, i);

                      
                    if (funkcja_znakil == false)
                    
                    {

                                throw new Exception("Niepoprawne znaki");




                     }
         


                        if (string.IsNullOrWhiteSpace(B_check) == true)
                        {

                            B = " ";
                            wynik = (A1 * X1);
                        }
                        else
                        {

                            B1 = float.Parse(B);
                            wynik = (A1 * X1) + B1;

                        }


                        string wynik_liniowa = wynik.ToString();






                        textBox_liniowa_value.Text = wynik_liniowa;
                    Data.textbox_result_liniowa = wynik_liniowa.ToString();
                    }

                
            }

            catch
            {

                MessageBox.Show("Niepoprawne znaki");

            }

        }

    }




    }

