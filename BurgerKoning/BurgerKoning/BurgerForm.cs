using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BurgerKoning
{
    public partial class BurgerForm : Form
    {
        // constanten met de prijzen
        const double burgerPrice = 5.00;
        const double bunCost = 1.00;
        const double meatCost = 2.00;

        // het bedrag waar we mee starten
        double cash = 5.00;

        // De keuken
        private Kitchen kitchen = new Kitchen();

        // We hebben nog een wachtrij nodig om klanten in te plaatsen.
        Queue<Customer> wachtrij = new Queue<Customer>();

        // De constructor, deze is standaard voor een windows applicatie
        public BurgerForm()
        {
            InitializeComponent();
        }

        // De Load methode wordt uitgevoerd zodra het form voor de eerste keer opent. We werken meteen de cijfers bij op het scherm.
        private void BurgerForm_Load(object sender, EventArgs e)
        {
            updateNumbers();
        }



        // De timer Tick wordt elke 5 seconden uitgevoerd. We voegen een klant toe en werken de cijfers bij.
        private void timer_Tick(object sender, EventArgs e)
        {
            // voeg een klant toe
            Customer a = new Customer();
            wachtrij.Enqueue(a);

            // werk de cijfers bij op het form
            updateNumbers();

            
        }

        // Cijfers bijwerken doen we met deze methode
        private void updateNumbers()
        {
            lblCustomersWaiting.Text = wachtrij.Count.ToString(); // laat hier het aantal klanten in de wachtrij zien
            lblCash.Text = cash.ToString("C");
            lblBuns.Text = kitchen.getAmountBuns().ToString();
            lblMeat.Text = kitchen.getAmountMeat().ToString();
            lblBurgers.Text = kitchen.getAmountHamburgers().ToString();
        }

        // Gebruiker koopt een broodje
        private void btnBuyBun_Click(object sender, EventArgs e)
        {
            kitchen.addBun();

            cash -= bunCost;
            // misschien moet hier nog de hoeveelheid geld die we hebben worden verlaagd?
            updateNumbers();
        }

        // Gebruiker koopt wat vlees
        private void btnBuyMeat_Click(object sender, EventArgs e)
        {
            kitchen.addMeat();
            cash -= meatCost;
            // hier ook geld van ons cash bedrag afhalen
            updateNumbers();
        }

        // Gebruiker maakt een hamburger
        private void btnMakeBurger_Click(object sender, EventArgs e)
        {
            kitchen.makeHamburger();
            updateNumbers();
        }

        // Gebruiker verkoopt een hamburger
        private void btnSellBurger_Click(object sender, EventArgs e)
        {
            // hamburger weghalen uit de keuken, hoeveelheid geld verhogen, klant vertrekt weer
            if (kitchen.getAmountHamburgers() > 0) //check hier ook of er wel een klant in de wachtrij staat
            {
                kitchen.removeHamburger();
                cash += burgerPrice;
                //haal de klant uit de wachtrij
                wachtrij.Dequeue();
                updateNumbers();
            }
        }
    }
}
