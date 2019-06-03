namespace BurgerKoning
{
    partial class BurgerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMakeBurger = new System.Windows.Forms.Button();
            this.btnBuyBun = new System.Windows.Forms.Button();
            this.btnBuyMeat = new System.Windows.Forms.Button();
            this.btnSellBurger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCustomersWaiting = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblBuns = new System.Windows.Forms.Label();
            this.lblMeat = new System.Windows.Forms.Label();
            this.lblBurgers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeBurger
            // 
            this.btnMakeBurger.Location = new System.Drawing.Point(12, 156);
            this.btnMakeBurger.Name = "btnMakeBurger";
            this.btnMakeBurger.Size = new System.Drawing.Size(132, 23);
            this.btnMakeBurger.TabIndex = 0;
            this.btnMakeBurger.TabStop = false;
            this.btnMakeBurger.Text = "Maak een hamburger";
            this.btnMakeBurger.UseVisualStyleBackColor = true;
            this.btnMakeBurger.Click += new System.EventHandler(this.btnMakeBurger_Click);
            // 
            // btnBuyBun
            // 
            this.btnBuyBun.Location = new System.Drawing.Point(12, 54);
            this.btnBuyBun.Name = "btnBuyBun";
            this.btnBuyBun.Size = new System.Drawing.Size(132, 23);
            this.btnBuyBun.TabIndex = 1;
            this.btnBuyBun.Text = "Koop een broodje";
            this.btnBuyBun.UseVisualStyleBackColor = true;
            this.btnBuyBun.Click += new System.EventHandler(this.btnBuyBun_Click);
            // 
            // btnBuyMeat
            // 
            this.btnBuyMeat.Location = new System.Drawing.Point(12, 96);
            this.btnBuyMeat.Name = "btnBuyMeat";
            this.btnBuyMeat.Size = new System.Drawing.Size(132, 23);
            this.btnBuyMeat.TabIndex = 2;
            this.btnBuyMeat.Text = "Koop een vleesschijf";
            this.btnBuyMeat.UseVisualStyleBackColor = true;
            this.btnBuyMeat.Click += new System.EventHandler(this.btnBuyMeat_Click);
            // 
            // btnSellBurger
            // 
            this.btnSellBurger.Location = new System.Drawing.Point(12, 225);
            this.btnSellBurger.Name = "btnSellBurger";
            this.btnSellBurger.Size = new System.Drawing.Size(132, 23);
            this.btnSellBurger.TabIndex = 3;
            this.btnSellBurger.Text = "Verkoop een hamburger";
            this.btnSellBurger.UseVisualStyleBackColor = true;
            this.btnSellBurger.Click += new System.EventHandler(this.btnSellBurger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geld: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wachtende klanten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aantal hamburgers: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Voorraad vlees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Voorraad broodjes: ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCustomersWaiting
            // 
            this.lblCustomersWaiting.AutoSize = true;
            this.lblCustomersWaiting.Location = new System.Drawing.Point(115, 209);
            this.lblCustomersWaiting.Name = "lblCustomersWaiting";
            this.lblCustomersWaiting.Size = new System.Drawing.Size(13, 13);
            this.lblCustomersWaiting.TabIndex = 9;
            this.lblCustomersWaiting.Text = "0";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(42, 9);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(13, 13);
            this.lblCash.TabIndex = 10;
            this.lblCash.Text = "0";
            // 
            // lblBuns
            // 
            this.lblBuns.AutoSize = true;
            this.lblBuns.Location = new System.Drawing.Point(109, 38);
            this.lblBuns.Name = "lblBuns";
            this.lblBuns.Size = new System.Drawing.Size(13, 13);
            this.lblBuns.TabIndex = 11;
            this.lblBuns.Text = "0";
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Location = new System.Drawing.Point(94, 80);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(13, 13);
            this.lblMeat.TabIndex = 12;
            this.lblMeat.Text = "0";
            // 
            // lblBurgers
            // 
            this.lblBurgers.AutoSize = true;
            this.lblBurgers.Location = new System.Drawing.Point(109, 140);
            this.lblBurgers.Name = "lblBurgers";
            this.lblBurgers.Size = new System.Drawing.Size(13, 13);
            this.lblBurgers.TabIndex = 13;
            this.lblBurgers.Text = "0";
            // 
            // BurgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 264);
            this.ControlBox = false;
            this.Controls.Add(this.lblBurgers);
            this.Controls.Add(this.lblMeat);
            this.Controls.Add(this.lblBuns);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblCustomersWaiting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSellBurger);
            this.Controls.Add(this.btnBuyMeat);
            this.Controls.Add(this.btnBuyBun);
            this.Controls.Add(this.btnMakeBurger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BurgerForm";
            this.Text = "Burgerkoning";
            this.Load += new System.EventHandler(this.BurgerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBurger;
        private System.Windows.Forms.Button btnBuyBun;
        private System.Windows.Forms.Button btnBuyMeat;
        private System.Windows.Forms.Button btnSellBurger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCustomersWaiting;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblBuns;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.Label lblBurgers;
    }
}

