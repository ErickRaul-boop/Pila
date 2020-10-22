using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//Para leer archivos externos

namespace Evaluación_de_Expresiones_Pila_
{
    public partial class Form1 : Form
    {
        Stack<char> caracter1 = new Stack<char>();//Pila que almacenará los siguientes caracteres: "{,[,("
        Stack<char> caracter2 = new Stack<char>();//Pila que almacenará los siguientes caracteres: "},],)"
        
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = txtExpresion.Text;//se toma la expresión del textBox y se asigna a una variable string
            char[] arreglo = palabra.ToCharArray();//se crea un arreglo  tipo string con los datos de la expresión


            bool bandera = false;
            bool Procesa(int inicio)
            {
                

                for (int i = inicio; i < arreglo.Length; i++)
                {
                    if (palabra[i] == '(' || palabra[i] == '{' || palabra[i] == '[')
                    {
                        caracter1.Push(palabra[i]);
                        Procesa(i + 1);
                    }
                    else if (palabra[i] == ')' || palabra[i] == '}' || palabra[i] == ']')
                    {
                        caracter2.Push(palabra[i]);
                        if (caracter1.Count() != 0 )
                        {
                            
                            char aux = caracter1.Pop();
                            char aux2 = caracter2.Pop();
                            if (aux == '(' && aux2 == ')')
                            {
                                bandera = true;
                            }
                            if (aux == '{' && aux2 == '}')
                            {
                                bandera = true;
                            }
                            if (aux == '[' && aux2 == ']')
                            {
                                bandera = true;
                            }
                            else { caracter1.Push(aux); caracter2.Push(aux2); bandera = false; }

                        }
                        
                        
                    }
                    
                   
                }
                return bandera;
            }
            if (Procesa(0) == true)
            {
                txtResultado.Text = "CORRECTO";
            }
            else { txtResultado.Text = "INCORRECTO"; }








        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            txtArchivo.InitialDirectory = "C:/";
            if (txtArchivo.ShowDialog() == DialogResult.OK)//Verifica que el usuario haya selecionado un archivo
            {
                this.txtUbicacion.Text = txtArchivo.FileName;//Se toma la ubiacion del archivo y se agrega a un textbox

                System.IO.StreamReader sr = new System.IO.StreamReader(txtUbicacion.Text, System.Text.Encoding.Default);
                string contenido;
                contenido = sr.ReadToEnd();
                sr.Close();
                txtExpresion.Text = contenido;
            }
        }

    }
}
