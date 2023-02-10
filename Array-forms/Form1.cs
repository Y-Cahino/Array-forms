using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_forms
{
    public partial class Form1 : Form
    {
        public string[] a;
        public int d;
        // Creazione menù vuoto
        MainMenu mainMenu1 = new MainMenu();
        //categorie menù
        MenuItem menu1 = new MenuItem();
        MenuItem menu2 = new MenuItem();
        MenuItem menu3 = new MenuItem();
        MenuItem menu4 = new MenuItem();
        public Form1()
        {
            // tutte le inizializzazioni va fatto dentro questa funzione ("Costruttore della classe")
            InitializeComponent();
            CreateMyMainMenu();
            a= new string[10];
            d = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void CreateMyMainMenu()
        {

            menu1.Text = "Inserisci Elemento";
            menu2.Text = "Calcola somma";
            menu3.Text = "Visualizza Array";
            menu4.Text = "Cancellazione";
            menu2.Text = "Modifica Array";
            // Questo porta le scritte in alto
            mainMenu1.MenuItems.Add(menu1);
            mainMenu1.MenuItems.Add(menu2);
            mainMenu1.MenuItems.Add(menu3);
            mainMenu1.MenuItems.Add(menu4);

            // Questo definisce quale tra i main è il menù
            Menu = mainMenu1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(a, ref d, button1.Text); 
        }

        //funzioni di servizio
        private void aggiunta(string[] a, ref int d, string nome)
        {
            a[d] = nome;
            d++;
        }


    }
}
