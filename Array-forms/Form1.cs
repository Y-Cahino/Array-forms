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
        int []a=new int[10];
        public Form1()
        {
            InitializeComponent();
            CreateMyMainMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void CreateMyMainMenu()
        {
            // Creazione menù vuoto
            MainMenu mainMenu1 = new MainMenu();
            //categorie menù
            MenuItem menu1 = new MenuItem();
            MenuItem menu2= new MenuItem();
            MenuItem menu3 = new MenuItem();
            MenuItem menu4 = new MenuItem();

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
        
    }
}
